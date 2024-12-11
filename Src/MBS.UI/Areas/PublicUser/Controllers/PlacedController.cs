using MBS.DAL.Repository.IRpository;
using MBS.UI.Models.ClientVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MBS.UI.Areas.PublicUser.Controllers
{
    [Area("PublicUser")]
    [Authorize(Roles = "Super Admin")]
    public class PlacedController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public PlacedController( IUnitOfWork unitOfWork)
        {
           
            _unitOfWork = unitOfWork;
        }
        // GET: PlacedController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult PlaceOrder([FromQuery] List<CartItem> cart)
        {



            return View(cart);
        }

        [HttpGet]
        public IActionResult PaymentOrder(int totalItems, decimal totalAmount)
        {

            var item = new PlaceOrderPaymentTotalVM()
            {
                Totall = totalAmount,
                Qty = totalItems
            };



            return View(item); // Return the view where you will handle the payment
        }

        // GET: PlacedController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlacedController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlacedController/Create
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

        // GET: PlacedController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlacedController/Edit/5
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

        // GET: PlacedController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlacedController/Delete/5
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
    }
}
