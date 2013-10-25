using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AdvantexeVLE.Filter;
using AdvantexeVLE.Models;
using WebMatrix.WebData;
using BusinessObject;

namespace AdvantexeVLE.Controllers
{
    public class UserController : Controller
    {
        AdvantexeService.Service1Client ObjService = new AdvantexeService.Service1Client();
         //
        // GET: /User/
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }


        //
        // POST: /Account/Login

        [HttpPost]
        // [AllowAnonymous]
        public ActionResult Login(ManageLogin Model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                BusinessObject.ManageLogin GetLoginInfo = new BusinessObject.ManageLogin();
                GetLoginInfo = ObjService.CheckValidLoginUser(Model);
                if (GetLoginInfo.UserName != null)
                {
                    ViewData["Msg"] = "Login Successfully";
                    // return RedirectToAction("SelectClasses", "Registration");
                }
                else
                {
                    ViewData["Msg"] = "Login Failed";
                }

            }
            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            return View();
        }

    }
}
