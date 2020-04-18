using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using University.Database;
using University.Repository;
using University.Entities;
using PagedList;
using PagedList.Mvc;

namespace University.Web.Controllers
{
    public class StudentsController : Controller
    {
        StudentRepository studentRepository = new StudentRepository();

        // GET: Students
        public ActionResult Index()
        {
            var students = studentRepository.GetAll();
            ViewBag.StudentsCount = students.Count();
            return View(students);
        }

        public ActionResult StudentInfo(string sortOrder, string searchFirstName, string searchLastName, DateTime? searchMinBirthDate, DateTime? searchMaxBirthDate, int? page, int? pSize)
        {
            ViewBag.CurrentFirstName = searchFirstName;
            ViewBag.CurrentLastName = searchLastName;
            ViewBag.CurrentMinBDate = searchMinBirthDate;
            ViewBag.CurrentMaxBDate = searchMaxBirthDate;
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpSize = pSize;

            ViewBag.FNameSortParam = String.IsNullOrEmpty(sortOrder) ? "FirstNameDesc" : "";
            ViewBag.LNameSortParam = sortOrder == "LastNameAsc" ? "LastNameDesc" : "LastNameAsc";
            ViewBag.BirthDateSortParam = sortOrder == "BirthDateAsc" ? "BirthDateDesc" : "BirthDateAsc";

            ViewBag.FView = "";
            ViewBag.LView = "";
            ViewBag.BDView = "";

            var students = studentRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(searchFirstName))
            {
                students = students.Where(x => x.FirstName.ToUpper().Contains(searchFirstName.ToUpper()));
            }
            if (!string.IsNullOrWhiteSpace(searchLastName))
            {
                students = students.Where(x => x.LastName.ToUpper().Contains(searchLastName.ToUpper()));
            }
            if (!(searchMinBirthDate is null))
            {
                students = students.Where(x => x.DateOfBirth >= searchMinBirthDate);
            }
            if (!(searchMaxBirthDate is null))
            {
                students = students.Where(x => x.DateOfBirth <= searchMaxBirthDate);
            }


            switch (sortOrder)
            {
                case "FirstNameDesc": students = students.OrderByDescending(x => x.FirstName); ViewBag.FView = "bg-info text-white"; break;
                case "LastNameAsc": students = students.OrderBy(x => x.LastName); ViewBag.LView = "bg-primary text-white"; break;
                case "LastNameDesc": students = students.OrderByDescending(x => x.LastName); ViewBag.LView = "bg-info text-white"; break;
                case "BirthDateAsc": students = students.OrderBy(x => x.DateOfBirth); ViewBag.BDView = "bg-primary text-white"; break;
                case "BirthDateDesc": students = students.OrderByDescending(x => x.DateOfBirth); ViewBag.BDView = "bg-info text-white"; break;
                default: students = students.OrderBy(x => x.FirstName); ViewBag.FView = "bg-primary text-white"; break;

            }


            int pageSize = pSize ?? 5;
            int pageNumber = page ?? 1;  //nullable coehelesing operator


            return View(students.ToPagedList(pageNumber, pageSize));
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = studentRepository.GetById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            CourseRepository courseRepository = new CourseRepository();
            ViewBag.SelectedCoursesId = courseRepository.GetAll().Select(x => new SelectListItem()
            {
                Value = x.CourseID.ToString(),
                Text = x.Title
            });

            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,FirstName,LastName,DateOfBirth")] Student student, IEnumerable<int> SelectedCoursesId)
        {
            if (ModelState.IsValid)
            {
                studentRepository.Insert(student, SelectedCoursesId);
                return RedirectToAction("StudentInfo");
            }

            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = studentRepository.GetById(id);
            if (student == null)
            {
                return HttpNotFound();
            }

            CourseRepository courseRepository = new CourseRepository();
            ViewBag.SelectedCoursesId = courseRepository.GetAll().Select(x => new SelectListItem()
            {
                Value = x.CourseID.ToString(),
                Text = x.Title,
                Selected = student.Courses.Any(y=>y.CourseID == x.CourseID)
            });


            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,FirstName,LastName,DateOfBirth")] Student student, IEnumerable<int> SelectedCoursesId)
        {
            if (ModelState.IsValid)
            {
                studentRepository.Update(student, SelectedCoursesId);
                return RedirectToAction("StudentInfo");
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = studentRepository.GetById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = studentRepository.GetById(id);
            studentRepository.Delete(student);
            return RedirectToAction("StudentInfo");
        }
    }
}
