using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpenseProjectDemo.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult FirstPage(int? id)
        {
            if (id.HasValue)
            {
                if (Request.QueryString["year"] == null)
                    ViewData["selectedyear"] = DateTime.Now.Year.ToString();
                else
                    ViewData["selectedyear"] = Request.QueryString["year"];
                ViewData["bid"] = id.Value;
                return View("Index");
            }
            else
            {
                return View("FirstPage");
            }
        }
        public ActionResult Ind()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Profile1()
        {
            return View();
        }
        public ActionResult GraphPage()
        {
            return View("GraphPage");
        }


        [HttpGet]
        public ActionResult Sessionvalidate(string sesssion)
        {
            Session["uid"] = sesssion;
            if (Session["uid"] != null)
            {
                return RedirectToAction("FirstPage", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            Session.RemoveAll();
            Session.Remove("uid");
            Response.Cookies["uid"].Value = string.Empty;
            return RedirectToAction("Login", "Home");
        }

        public ActionResult Draft()
        {
            return View();
        }

        public ActionResult ProposeNewBudget(int? id)
        {
            if (id.HasValue)
            {
                ViewData["id"] = id.Value;
                return View("ProposeNewBudget1");
            }
            else
            {
                return View("ProposeNewBudget");
            }
        }

       
        //public ActionResult ProposeNewBudget1(int? bid)
        //{
        //    //JsonResult Budgetid = new JsonResult { Data = bid };
        //    ViewData["bid"] = bid;

        //    return View();
        //}

    }
}