using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClaimWebApplication.DataLayers;
using ClaimWebApplication.Models;

namespace ClaimWebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Category> lstCategories = new ProductsData().GetAllCategories();
            ViewBag.lstCategory = new SelectList(lstCategories, "CategoryID", "CategoryName");
            return View(new ProductsData().GetAllProducts().Take(20).ToList());
        }
    }
}