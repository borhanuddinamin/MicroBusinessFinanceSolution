using MBS.DAL.Data;
using MBS.DAL.Repository.IRpository;
using MBS.Models.EntityModel;
using MBS.UI.Models.ClientVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace MBS.UI.Areas.PublicUser.Controllers
{
    [Area("PublicUser")]
    [Authorize(Roles = "Super Admin,Admin,SimpleUser,Retailer,ServiceProvider")]
    public class PlacedController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private ApplicationDbContext _db;
        public PlacedController( IUnitOfWork unitOfWork,ApplicationDbContext db)
        {
            _unitOfWork = unitOfWork;
            _db = db; 
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

        [HttpGet]
        public IActionResult GetShippingAddresses()
        {
            var userId  = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ; // Get logged-in user
            var addresses = _db.ShippingAddress
                .Where(a => a.UserId == userId)
                .ToList();
            return Json(addresses);
        }

        [HttpPost]
        [Route("PublicUser/Placed/SaveShippingAddress")]
        public JsonResult SaveShippingAddress([FromBody] ShippingAddress address)
        {
            address.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (address.IsDefault)
            {
                // Ensure only one default address per user
                var existingDefaults = _db.ShippingAddress
                    .Where(a => a.UserId == address.UserId && a.IsDefault)
                    .ToList();

                if (existingDefaults.Any())
                {
                    foreach (var defaultAddress in existingDefaults)
                        defaultAddress.IsDefault = false;

                    _db.UpdateRange(existingDefaults);
                }
                
            }

            try
            {
                _db.ShippingAddress.Add(address);
                _db.SaveChanges();
            }
            catch {
                throw;
            }

            return Json(new { success = true, savedAddress = address });
        }


       
    }
}
