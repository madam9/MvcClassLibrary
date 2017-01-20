using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcWebsiteSystem.Entities;
using MvcWebsite.Models;
using MvcWebsiteSystem.BLL;

namespace MvcWebsite.Controllers
{
    public class TestController : Controller
    {
        private RegionController rc = new RegionController();

        // GET: Test
        public ActionResult Index()
        {
            return View(regionModel.Region_List());
            //return View(rc.Region_List());
        }
    }
}