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
            //return View(regionModel.Region_List());
            return View(rc.Region_List());
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Regions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RegionID,RegionDescription")] Region region)
        {
            if (ModelState.IsValid)
            {
                rc.Region_Create(region);
                return RedirectToAction("Index");
            }

            return View(region);
        }
        // GET: Regions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                int regionid = id ?? default(int);
                Region region = rc.Region_Get(regionid);
                if (region == null)
                {
                    return HttpNotFound();
                }
                return View(region);

            }
        }

        // POST: Regions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed([Bind(Include = "RegionID")]int regionId)
        {
            rc.Region_Delete(regionId);
            return RedirectToAction("Index");

        }

        //protected override void Remove(bool remove)
        //{
        //    if (Remove)
        //    {
        //        rc.Region_Delete();
        //    }
        //    base.Dispose(Remove);
        //}
    }
}