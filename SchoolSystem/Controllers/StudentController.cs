using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolSystem.Models;

namespace SchoolSystem.Controllers
{
    public class StudentController : Controller
    {
        SchoolContext db = new SchoolContext();
        // GET: Student
        public ActionResult Student(Student student)
        {
            return View(student);
        }

        [HttpPost]
        //View or Form theke Data Anbe model object
        public ActionResult AddStudent(Student model)
        {
            //Data Receive hobe eitate
            
                Student student = new Student();

                if (ModelState.IsValid)
                {
                    student.ID = model.ID;
                    student.Name = model.Name;
                    student.FatherName = model.FatherName;
                    student.Email = model.Email;
                    student.MobileNo = model.MobileNo;
                    student.Description = model.Description;

                    if (model.ID == 0)
                    {
                        db.Students.Add(student);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Entry(student).State = EntityState.Modified;
                        db.SaveChanges();
                    }
            }

                ModelState.Clear();

                return View("Student");
        }

        public ActionResult StudentList()
        {
            var list = db.Students.ToList();
            return View(list);
        }

        public ActionResult Delete(int id)
        {
            var del = db.Students.Where(x => x.ID == id).First();
            db.Students.Remove(del);
            db.SaveChanges();

            var list = db.Students.ToList();
            return View("StudentList",list);
        }
    }
}