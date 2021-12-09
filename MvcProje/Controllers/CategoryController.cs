﻿using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class CategoryController : Controller


    {

        CategoryManager cm = new CategoryManager();


        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {

            var categoryvalues = cm.GetAllBL();

            return View(categoryvalues);
        
        }


    }
}