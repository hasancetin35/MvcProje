﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class CategoryController : Controller


    {

        CategoryManager cm = new CategoryManager(new EfCategoryDal());


        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {

          var categoryvalues = cm.GetList();

            return View(categoryvalues);
        
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }



        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
         //   cm.CategoryAddBL(p);
            return RedirectToAction("GetCategoryList");



        }


    }
}