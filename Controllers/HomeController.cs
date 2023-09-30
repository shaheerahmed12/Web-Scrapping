using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Scrapping.Models;
using HtmlAgilityPack;
using DevExtreme.AspNet.Data;

namespace Web_Scrapping.Controllers
{
    public class HomeController : Controller
    {
        Scrapping scrap = new Scrapping();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult Get(curren cr)
        {
            return Json(scrap.GetCurrency(), JsonRequestBehavior.AllowGet);
        }
    }
}