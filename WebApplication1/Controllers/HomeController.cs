﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Donaldo Trumpski
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// /////asldghfasldjkfbhsipaelaskdjfhasdfasdfawef
        /// </summary>
        /// <returns></returns>
        /// //sdfgsdfgsdfggggggggggggggggggggggggggggg
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}