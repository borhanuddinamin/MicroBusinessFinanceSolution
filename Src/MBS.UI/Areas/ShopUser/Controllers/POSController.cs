using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MBS.DAL.Repository.IRpository;
using MBS.Models.AppVM;
using MBS.Models.EntityModel;

namespace MBS.UI.Areas.ShopUser.Controllers
{
    [Area("ShopUser")]
    public class POSController : Controller
    {


        private readonly IWebHostEnvironment _webHost;
        private IUnitOfWork _unitOfWork;
        public POSController(IWebHostEnvironment webHost, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _webHost = webHost;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(PosVM posVM, string code)
        {
            //if (code != null)
            //{
            //    var product = new PosVM();
            //    product.Product = _unitOfWork.Product.GetFirstOrDefault(x => x.Code == code);

            //}

            List<Product> productList = new List<Product>();
            List<Customer> customerList = new List<Customer>();
            List<Category> categoryList = new List<Category>();

            customerList = _unitOfWork.Customer.GetAll().ToList();
            productList = _unitOfWork.Product.GetAll().ToList();
            categoryList = _unitOfWork.Category.GetAll().ToList();

            PosVM purchaseVM = new()
            {
                Pos = new(),
                ProductList = productList.Select(i => new SelectListItem
                {
                    Text = i.Name + " - " + i.Code,
                    Value = i.Id.ToString()
                }),

                CustomerList = customerList.Select(i => new SelectListItem
                {
                    Text = i.Name + " - " + i.Phone.ToString(),
                    Value = i.Id.ToString()
                }),
                CategoryList = categoryList.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            };

            return View(purchaseVM);
        }


        #region API Calls
        [HttpGet]
        public IActionResult GetProducts(string? searchFilter, int? categoryId)
        {
            var productList = _unitOfWork.Product.GetAll();
            if (searchFilter != "null" && searchFilter != "undefined")
            {
                productList = productList.Where(w => w.Name.ToLower().Contains(searchFilter.ToLower()) || !string.IsNullOrWhiteSpace(w.Code) && w.Code.ToLower().Contains(searchFilter.ToLower())).ToList();
            }
            if (categoryId != null)
            {
                productList = productList.Where(w => w.CategoryId == categoryId).ToList();
            }


            return Json(new { data = productList });
        }
        #endregion
    }
}
