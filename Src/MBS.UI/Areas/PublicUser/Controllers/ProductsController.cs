using MBS.DAL.Repository.IRpository;
using MBS.UI.Models.ClientVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MBS.UI.Areas.PublicUser.Controllers
{
    [Area("PublicUser")]
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: ProductsController
        public ActionResult Index(int id)
        {

            var itemList = _unitOfWork.Product.GetAllById(x => x.CategoryId == id).ToList();
            var location= _unitOfWork.Division.GetAll().ToList();
            CategoriesVM categoriesVM = new()
            {
                ProductsList = itemList,
                Divisions = location,
            };
            

            return View(categoriesVM);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
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

        [HttpGet]
        public IActionResult GetAllByDivisionId(int id) {

			var post = _unitOfWork.Product.GetAllById(x => x.DivisionId == id);



			return Json(new { data = post });
		}


		#endregion
	}
}
