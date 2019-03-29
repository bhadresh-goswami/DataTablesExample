using DataTablesExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DataTablesExample.Controllers
{
    public class UserController : Controller
    {
        private dbMRMEntities db = new dbMRMEntities();
        // GET: User
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(UserMaster userModel,string ReturnUrl)
        {
            try
            {
                var data = db.UserMasters.SingleOrDefault(a => a.UserName == userModel.UserName && a.UserPassword == userModel.UserPassword);
                if(data!=null)
                {
                    FormsAuthentication.SetAuthCookie(userModel.UserName, false);

                    if (ReturnUrl != null)
                        return Redirect(ReturnUrl);
                    else
                        return RedirectToAction("Index", "DisplayData");
                }
                ViewBag.error = "User Name or Password is Wrong!";
            }
            catch (Exception ex)
            {

                ViewBag.error = ex.Message;
            }
            return View();
        }

        #region New User Registration
        public ActionResult NewUser()
        {

            ViewBag.UserRole = new SelectList(db.RoleMasters.ToList(), "RoleId", "RoleDescription");
            return View();
        }

        [HttpPost]
        public ActionResult NewUser(UserMaster userModel)
        {
            try
            {

                db.UserMasters.Add(userModel);
                db.SaveChanges();

                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {

                ViewBag.error = ex.Message;
            }
            ViewBag.UserRole = new SelectList(db.RoleMasters.ToList(), "RoleId", "RoleDescription");

            return View();
        }

        #endregion

        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }


    }
}