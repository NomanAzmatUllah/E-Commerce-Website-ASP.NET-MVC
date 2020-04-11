using E_commerce.Models;
using E_commerce.Models.Repository;
using E_commerce.Models.view_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_commerce.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            categoryRepositoryPattern c = new categoryRepositoryPattern();
            List<categoryviewmodel> li = c.viewcategory();
            ViewBag.catlist = li;
            return View();
        }

        public ActionResult products(int? id)
        {

            productrepositorypattern r = new productrepositorypattern();
            List<productviewmodel> li = r.viewpeoduct().Where(x => x.pro_fk_cat_id == id).ToList();
            ViewBag.productlist = li;
           
            return View();
        }
    }
}