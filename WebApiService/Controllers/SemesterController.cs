using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using WebApiService.Models;

namespace WebApiService.Controllers
{
    public class SemesterController : ApiController
    {
        private UniversityDBContext db = new UniversityDBContext();

        // GET: Semester
        public IHttpActionResult Index()
        {
            return Ok(db.Semesters.ToList());
        }

     
        // GET: Semester/Create
        public IHttpActionResult Create()
        {
            return Ok();
        }

        // POST: Semester/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
      

        public IHttpActionResult Create([Bind(Include = "Id,Semester_Name")] Semester semester)
        {
            if (ModelState.IsValid)
            {
                db.Semesters.Add(semester);
                db.SaveChanges();
               
            }

            return Ok(semester);
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
