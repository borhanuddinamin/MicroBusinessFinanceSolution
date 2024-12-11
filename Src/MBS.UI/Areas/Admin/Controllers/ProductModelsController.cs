using MBS.DAL.Repository.IRpository;
using MBS.Models.EntityModel;
using MBS.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MBS.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductModelsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductModelsController(IUnitOfWork unitOfWork )
        {
            _unitOfWork = unitOfWork;
        }
        // GET: ProductModelsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductModelsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductModelsController/Create
        public ActionResult Upsert()
        {
            List<ProductModel> products = new List<ProductModel>();
            products=_unitOfWork.ProductModel.GetAll().ToList();
            foreach (var item in products)
            {
                item.Product = _unitOfWork.Product.GetFirstOrDefault(x => x.Id == item.ProductId);
            }

            ProductModelVM productModelVM = new()
            {
                ProductModel = new(),
                ProductList = products.Select(i => new SelectListItem
                {
                    Text = i.Product.Name+'-'+i.Product.Code,
                    Value = i.Id.ToString()
                }),

            };



            return View(productModelVM);
        }

        // POST: ProductModelsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upsert(ProductModel obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductModel.Update(obj);
                _unitOfWork.Save();

            }

            return RedirectToAction("Upsert");
        }




        public ActionResult UpdateProductModel(int id)
        {
            var productModelData=_unitOfWork.ProductModel.GetFirstOrDefault(x=>x.Id==id);
            productModelData.Product=_unitOfWork.Product.GetFirstOrDefault(x=>x.Id==productModelData.ProductId);

            return View(productModelData);

        }

        // GET: ProductModelsController/Edit/5
        public ActionResult Edit(int id)
        {
            var model=new ProductModelVM();

			if (id!= 0)
            {
               model.ProductModel =_unitOfWork.ProductModel.GetFirstOrDefault(x=>x.Id==id);
                if (model ==null)
                {
                    return NotFound();
                }

				
			}
			return View(model);

		}

        // POST: ProductModelsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductModelsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductModelsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        #region API CALL

        public IActionResult GetProductDetailsById(int id)
        {

			var itemVm = _unitOfWork.ProductModel.GetFirstOrDefault(x=>x.Id==id);
            if (itemVm != null)
            {
                itemVm.Product = _unitOfWork.Product.GetFirstOrDefault(x => x.Id == itemVm.ProductId);

			}
			

			return Json(new { data = itemVm });
		}

		#endregion
	}
}
