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
    public class StudentController : Controller
    {
        private UniversityDBContext db = new UniversityDBContext();

        // GET: Student
        public ActionResult Index()
        {
         
            var students = db.Students.ToList();

            return View(students.ToList());
        }


        // GET: Student/Create
        
        public ActionResult Create()
        {
            //ViewBag.DepartmentId = new SelectList(db.Deparments, "Id", "DeptName");
            return View ();
        }



        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        
        //[ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,StudentRegNo,Name,Email,Contact,RegDate,Address,DepartmentId")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
              
            }

            //ViewBag.DepartmentId = new SelectList(db.Deparments, "Id", "DeptName", student.DepartmentId);
            return View();
        }

        // GET: Student/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Student student = db.Students.Find(id);
        //    if (student == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.DepartmentId = new SelectList(db.Deparments, "Id", "DeptName", student.DepartmentId);
        //    return View(student);
        //}

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,StudentRegNo,Name,Email,Contact,RegDate,Address,DepartmentId")] Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(student).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.DepartmentId = new SelectList(db.Deparments, "Id", "DeptName", student.DepartmentId);
        //    return View(student);
        //}

        //// GET: Student/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Student student = db.Students.Find(id);
        //    if (student == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(student);
        //}

        //// POST: Student/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Student student = db.Students.Find(id);
        //    db.Students.Remove(student);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
