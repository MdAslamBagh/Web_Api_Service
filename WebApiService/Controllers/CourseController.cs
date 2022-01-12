using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

using WebApiService.Models;

namespace WebApiService.Controllers
{
    public class CourseController : Controller
    {
        private UniversityDBContext db = new UniversityDBContext();

        // GET: Course
        public ActionResult Index()
        {
            var courses = db.Courses.ToList();
              
            return View(courses.ToList());
        }

        // GET: Course/Details/5
    

        // GET: Course/Create
        public ActionResult Create()
        {
            //ViewBag.DepartmentId = new SelectList(db.Deparments, "Id", "DeptName");
            //ViewBag.SemesterId = new SelectList(db.Semesters, "Id", "Semester_Name");
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
      
      [HttpPost]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
               // ViewBag.Message = "Course Saved Successfully.";
              
            }

          
            return View(course);
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
