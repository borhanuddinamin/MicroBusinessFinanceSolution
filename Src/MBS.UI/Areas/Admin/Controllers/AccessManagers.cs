using MBS.DAL.Data;
using MBS.DAL.Repository.IRpository;
using MBS.Models;
using MBS.Models.AppVM;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MBS.UI.Areas.Admin
{
    [Area("Admin")]
    
    public class AccessManagers : Controller
    {

        //private readonly ApplicationDbContext _db;
          private readonly IDbInitializer _db;
          private readonly IUnitOfWork _unitOfWork;

        public AccessManagers(IDbInitializer db, IUnitOfWork unitOfWork)
        {
            _db= db;
            _unitOfWork= unitOfWork;
            
           
        }
        public IActionResult UserList()
        {


            return View();
        }
        public async  Task<IActionResult> UserManager(string id)
        {
            AppUser user = await _db.GetUserById(id);
            //List<IdentityRole> roleList = new List<IdentityRole>();
            var roles= _db.GetAllRole().ToList();
            //var user = await _userManager.FindByIdAsync(id);
            //var user = await _db.Users.FirstOrDefaultAsync(x=>x.Id==id);
            UserManagerVM userManagerVM = new()
            {
                User = user,
                Roles= roles.Select(i=> new SelectListItem
                {
                    Text=i.Name,
                    Value=i.Name
                })
            };


            return View(userManagerVM);
        }
        [HttpPost]
        public async Task< IActionResult> UserManager(UserManagerVM obj)
        {
            AppUser user = await _db.GetUserById(obj.User.Id);
           
               // var user = await _userManager.FindByIdAsync(userId); // Fetch the user
                if (user != null)
                {
                    _db.UpdateAssignRole(user, obj.Role); 
                    return RedirectToAction("UserList");
                }


              
                
            
            return View(obj);
        }
        public IActionResult UpsertRole()
        {
            return View();
        }
        public IActionResult RoleManager()
        {
            return View();
        }

        public IActionResult RoleManage()
        {
            RoleVM roleVM = new()
            {
                
            };
            roleVM.IdentityRole=_db.GetAllRole().ToList();
            return View(roleVM);
        }

            [HttpGet]
              public IActionResult CreateRole()
                {
                     RoleUpsertVM role = new()
                     {
                         IdentityRole=new(),
                     };
                    return View(role);
                }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRole( RoleUpsertVM obj)
        {
            if (ModelState.IsValid)
            {
                var model = obj.IdentityRole;
                _db.CreateRole(model.Name);
                return RedirectToAction("RoleManage");
            }
            return View(obj);

        }

        #region API Call
        [HttpGet]
        public IActionResult GetAllUser() 
        { 

            var userList=_db.GetAllUser().ToList();
            return Json(new {data=userList});
        }
        [HttpGet]
        public IActionResult GetAllRole()
        {

            var roleList = _db.GetAllRole().ToList();
            return Json(new { data = roleList });
        }
        #endregion
    }
}
