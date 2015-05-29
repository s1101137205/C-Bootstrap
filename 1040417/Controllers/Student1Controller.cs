using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Net;
using System.Web.Mvc;
using _1040417.Models;
using System.Data.Entity;

namespace _1040417.Controllers
{
    public class Student1Controller : Controller
    {
        // GET: Student1
        KUASDB1Entities db = new KUASDB1Entities();
        
        // GET: Student1
        public ActionResult Index()
        {
            
            return View(db.Student.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(_1040417.Models.Student student)
        {
            if (ModelState.IsValid)
            {
                Student stu = new Student();
                stu.ID = Guid.NewGuid();
                stu.SNo = student.SNo;
                stu.SName = student.SName;
                stu.ModifiedDT = System.DateTime.Now;
                db.Student.Add(stu);
                db.SaveChanges();

                 bool haved = (db.Student.Where(s => s.SNo == stu.SNo).Count())>0 ? true : false;
                 if (haved) db.Student.Add(stu);
            }
            db.SaveChanges();
            return View();
        }

        public ActionResult Edit(Guid id)
        {
            var stu = db.Student.Where(s => s.ID == id).First();
            return View(stu);
        }

         [HttpPost]
        public ActionResult Edit(Student stu)
        {
             if(ModelState.IsValid)
             {
                 Student myStu = db.Student.Where(s => s.ID == stu.ID).First();
                 myStu.SNo = stu.SNo;
                 myStu.SName = stu.SName;

             }
             db.SaveChanges();
             return RedirectToAction("Index");
        }

        public ActionResult EntryRow()
        {
            Student itemModel = new Student();
            return PartialView("EntryRow",itemModel);

        }
    }
}