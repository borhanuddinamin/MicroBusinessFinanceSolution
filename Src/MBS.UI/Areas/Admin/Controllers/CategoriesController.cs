using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MBS.DAL.Repository.IRpository;
using MBS.Models.AppVM;
using MBS.Models.EntityModel;

using System.Text;

namespace MBS.UI.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHost;

        public CategoriesController(IUnitOfWork unitOfWork, IWebHostEnvironment webHost)
        {
            this._unitOfWork = unitOfWork;
            _webHost = webHost;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Upsert(int? id)
        {

            CategoryVM categoryVM = new()
            {
                Category = new()
            };
            if (id == null || id == 0)
            {
                return View(categoryVM);
            }
            else
            {
                categoryVM.Category = _unitOfWork.Category.GetFirstOrDefault(x => x.Id == id);
                return View(categoryVM);
            }




        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Upsert(CategoryVM obj, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                var model = new Category();
                model = obj.Category;
                string mmRoot = _webHost.WebRootPath;


                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    string filePath = Path.Combine(mmRoot, @"img\CategoryImages");
                    if (!Directory.Exists(filePath))
                    {
                        Directory.CreateDirectory(filePath);
                    }
                    var fileExtention = file.FileName;
                    if (obj.Category.ImageUrl != null)
                    {
                        string oldPath = Path.Combine(mmRoot, obj.Category.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldPath))
                        {
                            System.IO.File.Delete(oldPath);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(filePath, fileName + fileExtention), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    model.ImageUrl = @"\img\CategoryImages\" + fileName + fileExtention;

                }
                Category category = obj.Category;
                //Create Product
                if (category.Id == 0)
                {

                    _unitOfWork.Category.Add(category);
                    _unitOfWork.Save();
                    return RedirectToAction("Index");
                }

                //Update Products
                else
                {
                    _unitOfWork.Category.Update(category);
                    _unitOfWork.Save();
                    return RedirectToAction("Index");
                }

            }
            return View(obj);
        }

       
       
        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var categoryList = _unitOfWork.Category.GetAll();

            return Json(new { data = categoryList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var product = _unitOfWork.Category.GetFirstOrDefault(f => f.Id == id);
            if (product == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            
            _unitOfWork.Category.Remove(product);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Deleted Successfully!" });
        }
        #endregion
    }
}
