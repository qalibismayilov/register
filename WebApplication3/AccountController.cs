using Microsoft.AspNetCore.Mvc;
using YourProject.ViewModels;

namespace YourProject.Controllers
{
    public class AccountController : Controller
    {
      
        public ActionResult Register()
        {
            return View();
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
             
                return RedirectToAction("Login", "Account");
            }

            
            return View(model);
        }
    }
}
