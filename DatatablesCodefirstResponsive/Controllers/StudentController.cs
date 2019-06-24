using DatatablesCodefirstResponsive.Models;
using DataTablesWithResponsive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatatablesCodefirstResponsive.Controllers
{
    public class StudentController : Controller
    {
        StudentDb sd = new StudentDb();
        // GET: Student
        public ActionResult Index()
        {
            List<ViewStudents> s = new List<ViewStudents>();
            var listHobby = sd.hobbies.ToList();
            foreach (var item in sd.students.ToList())
            {
                if (item.Hobies == 0)
                {
                    item.Hobies = 1;
                }

                s.Add(new ViewStudents { Name = item.Name, STD = item.STD, Hobies = listHobby.Where(h => h.idhobbies == item.Hobies).Select(c => c.hobbiesName).FirstOrDefault() });
            }
          
           return View(s);
        }
        // GET: Student/Create
        public ActionResult Index2()
        {
            return View();
        }
        public JsonResult BindStudentDatatable()
        {
            List<ViewStudents> s = new List<ViewStudents>();
            var listHobby = sd.hobbies.ToList();
            foreach (var item in sd.students.ToList())
            {
                if (item.Hobies == 0)
                {
                    item.Hobies = 1;
                }

                s.Add(new ViewStudents { Name = item.Name, STD = item.STD, Hobies = listHobby.Where(h => h.idhobbies == item.Hobies).Select(c => c.hobbiesName).FirstOrDefault() });
            }
            return Json(s, JsonRequestBehavior.AllowGet);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Students stud)
        {
            try
            {
                //Random rr = new Random();
                //List<Students> s = new List<Students>();
                //for (Int64 i = 4001; i <= 10000; i++)
                //{
                //    int h = rr.Next(6);
                //    int S = rr.Next(1, 13);
                //    s.Add(new Students { Name = "T" + i, STD = S.ToString(), Hobies = h });
                //}

                //sd.students.AddRange(s);

                //sd.SaveChanges();

                //TODO: Add insert logic here

                sd.students.Add(stud);
                sd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
