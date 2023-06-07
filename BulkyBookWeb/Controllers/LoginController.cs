using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Cryptography;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Controllers
{


    
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Index(User objUser)
        {
            if (ModelState.IsValid)
            {
                //using (DB_Entities db = new DB_Entities())
                //{
                //    var obj = db.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                //    if (obj != null)
                //    {
                //        Session["UserID"] = obj.UserId.ToString();
                //        Session["UserName"] = obj.UserName.ToString();
                //        return RedirectToAction("UserDashBoard");
                //    }
                //}
            }
            return RedirectToAction("Index", "Category");
            //return RedirectToAction("UserDashBoard");
            //return View(objUser);
        }


    }
}
