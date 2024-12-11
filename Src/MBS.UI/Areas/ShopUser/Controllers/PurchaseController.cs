using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using MBS.DAL.Repository;
using MBS.DAL.Repository.IRpository;
using MBS.Models.AppVM;
using MBS.Models.EntityModel;
using System.Text;
using System.Drawing;
using MBS.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace MBS.UI.Areas.ShopUser.Controllers
{
    [Area("ShopUser")]
    public class PurchaseController : Controller
    {

        private readonly IWebHostEnvironment _webHost;
        private IUnitOfWork _unitOfWork;
        public PurchaseController(IWebHostEnvironment webHost, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _webHost = webHost;
        }

        public IActionResult Create()
        {
            List<Supplier> supplierList = new List<Supplier>();
            List<Product> productList = new List<Product>();


            supplierList = _unitOfWork.Supplier.GetAll().ToList();
            productList = _unitOfWork.Product.GetAll().ToList();

            PurchaseVM purchaseVM = new()
            {
                Purchase = new(),
                SupplierList = supplierList.Select(i => new SelectListItem
                {
                    Text = i.SupplierName,
                    Value = i.Id.ToString()
                }),
                ProductList = productList.Select(i => new SelectListItem
                {
                    Text = i.Name + " - " + i.Code,
                    Value = i.Id.ToString()
                }),
            };

            return View(purchaseVM);
        }

        public IActionResult Invoice(int Id)
        {
            var purchase = _unitOfWork.Purchase.GetFirstOrDefault(f => f.Id == Id);
            purchase.PurchaseItems = _unitOfWork.Purchase.GetPurchaseItems(Id);
            foreach (var item in purchase.PurchaseItems)
            {
                item.Product = _unitOfWork.Product.GetFirstOrDefault(f => f.Id == item.ProductId);
            }
            var supplier = _unitOfWork.Supplier.GetFirstOrDefault(f => f.Id == purchase.SupplierId);
            var PurchaseInvoice = new PurchaseInvoiceVM();
            PurchaseInvoice.InvoiceId = purchase.Id.ToString();
            PurchaseInvoice.Date = DateTime.Now.ToString("dd/mm/yyyy");
            PurchaseInvoice.Note = purchase.Note;
            PurchaseInvoice.Due = purchase.Due.ToString();
            PurchaseInvoice.Paid = purchase.Paid.ToString();
            PurchaseInvoice.GrandTotal = purchase.GrandTotal.ToString();
            PurchaseInvoice.SupplierName = supplier.SupplierName.ToString();
            PurchaseInvoice.Address = supplier.Address != null ? supplier.Address : "";
            PurchaseInvoice.Phone = supplier.Phone.ToString();
            PurchaseInvoice.Email = supplier.Email != null ? supplier.Email : "";
            PurchaseInvoice.TransactionAccount = TransactionAccount.CASH.ToString();
            List<PurchaseItemsInvoiceVM> purchaseItems = new List<PurchaseItemsInvoiceVM>();
            foreach (var product in purchase.PurchaseItems)
            {
                var obj = new PurchaseItemsInvoiceVM();
                obj.ProductName = product.Product != null ? product.Product.Name : "";
                obj.ProductCode = product.Product != null ? product.Product.Code : "";
                obj.Price = product.Product != null ? product.Product.SalePrice.ToString() : "";
                obj.SubTotal = product.SubTotal.ToString();

                obj.UnitName = _unitOfWork.Unit.GetFirstOrDefault(f => f.Id == product.Product.UnitId).Name;

                obj.UnitValue = product.Quantity;


                if (product.Product.SubUnitId > 0)
                {
                    obj.SubUnitName = _unitOfWork.Unit.GetFirstOrDefault(f => f.Id == product.Product.SubUnitId).Name;
                    obj.SubUnitValue = product.SubQuantity;

                }


                purchaseItems.Add(obj);
            }
            PurchaseInvoice.PurchaseItems = purchaseItems;

            return View(PurchaseInvoice);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult<Purchase>> CreatePurchase(PurchaseVM purchaseVM)
        {
            if (ModelState.IsValid)
            {
                var purchase = new Purchase();
                purchase = purchaseVM.Purchase;
                // Validate the purchase object
                if (purchase == null || purchase.PurchaseItems == null || !purchase.PurchaseItems.Any())
                {
                    return BadRequest("Purchase or purchase items are not valid.");
                }



                // Calculate the GrandTotal before saving
                purchase.CalculateGrandTotal();

                // Add purchase to the context
                _unitOfWork.Purchase.Add(purchase);



                // Update stock for each purchase item
                foreach (var item in purchase.PurchaseItems)
                {
                    var product = _unitOfWork.Product.GetFirstOrDefault(x => x.Id == item.ProductId);
                    var stock = _unitOfWork.Stock.GetFirstOrDefault(x => x.ProductId == product.Id);
                    stock.StockQuantity += item.Quantity;
                    // Update stock
                    _unitOfWork.Stock.Update(stock);
                }

                // Save changes to the database
                _unitOfWork.Save();

                return RedirectToAction("Invoice", new { id = purchase.Id });
            }
            return View(purchaseVM);

        }



    }
}
