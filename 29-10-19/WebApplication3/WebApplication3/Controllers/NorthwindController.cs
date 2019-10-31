using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class NorthWindController : Controller
    {
     
        NorthWindContext db = new NorthWindContext();
        public ActionResult Index()
        {
            db.CategoryTable.ToList();
            db.ProductTable.ToList();
            return View();
        }
    }
}