using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace WebApiService.Models
{
    public class MarkController : Controller
    {
        private UniversityDBContext db = new UniversityDBContext();

        // GET: Mark
        public ActionResult Index()
        {
            return View(db.Marks.ToList());
        }



        public ActionResult Create()
        {
            //ViewBag.DepartmentId = new SelectList(db.Deparments, "Id", "DeptName");
            return View();
        }



        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        //[ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Mark Mark)
        {
            if (ModelState.IsValid)
            {
                db.Marks.Add(Mark);
                db.SaveChanges();

            }

  
            return View();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
