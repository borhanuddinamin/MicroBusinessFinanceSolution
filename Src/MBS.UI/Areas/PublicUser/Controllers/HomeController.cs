using MBS.DAL.Repository.IRpository;
using MBS.Models.EntityModel;
using MBS.UI.Models;
using MBS.UI.Models.ClientVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;


namespace MBS.UI.Areas.PublicUser.Controllers
{
    [Area("PublicUser")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger,IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<ProductModel>productModels = new List<ProductModel>();
            productModels=_unitOfWork.ProductModel.GetAll().ToList();

            foreach (var item in productModels)
            {
                item.Product = _unitOfWork.Product.GetFirstOrDefault(x => x.Id == item.ProductId);
            }

            List<ProductModel> activeProducts = new List<ProductModel>();
            List<ProductModel> latestProducts = new List<ProductModel>();
           // List<Category> categories = new List<Category>();
           
                var activeProduct= _unitOfWork.ProductModel.GetAllById(x => x.IsActive == true).ToList();
                var latestProduct = _unitOfWork.ProductModel.GetAllById(x => x.IsLatest == true).ToList();
                var categoryList = _unitOfWork.Category.GetAll().ToList();


            HomePageVM homePageData = new ()
            {
                
                ActiveProductList= activeProduct,
                LatestProductList=latestProduct,
                CategoryList=categoryList,
                
                //NewArrivalProductList= NewArrivalProducts,
            };


            return View(homePageData);
        }

        public IActionResult Privacy()
        {
            return View();
        }


       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        [HttpGet]
        public ActionResult GetProductById(int id)
        {


            var item=_unitOfWork.Product.GetFirstOrDefault(x=>x.Id == id);
            return Json(new { data = item });
        }
        
        [HttpGet]
        public ActionResult GetProductById(int[] id)
        {


            var item=_unitOfWork.Product.GetFirstOrDefault(x=>x.Id == id);
            return Json(new { data = item });
        }


        [HttpGet]
        public ActionResult GetAllDivision()
        {


            var item = _unitOfWork.UserDivision.GetAll();
            return Json(new { data = item });
        }

        //GetAllDistrictById
        [HttpGet]
        public ActionResult GetAllDistrictById(int id)
        {

            var item = _unitOfWork.District.GetAllById(x=>x.DivisionId==id);
            return Json(new { data = item });
        }

        [HttpGet]
        public ActionResult GetAllSubDistrictById(int id)
        {

            var item = _unitOfWork.SubDistrict.GetAllById(x => x.DistrictId == id);
            return Json(new { data = item });
        }
    }
}
