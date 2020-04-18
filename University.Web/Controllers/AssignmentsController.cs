using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using University.Database;
using University.Entities;
using University.Repository;
using PagedList;
using PagedList.Mvc;

namespace University.Web.Controllers
{
    public class AssignmentsController : Controller
    {
        AssignemntRepository assignemntRepository = new AssignemntRepository();

        // GET: Assignments
        public ActionResult Index()
        {
            var assignments = assignemntRepository.GetAll();
            ViewBag.assignementscount = assignments.Count();
            return View(assignments);

        }

        public ActionResult AssignmentInfo(string sortOrder, string searchTitle, string searchDescription, DateTime? searchMinSubDate, DateTime? searchMaxSubDate, int? page, int? pSize)
        {
            ViewBag.CurrentTitle = searchTitle;
            ViewBag.CurrentDesciption = searchDescription;
            ViewBag.CurrentMinSDate = searchMinSubDate;
            ViewBag.CurrentMaxSDate = searchMaxSubDate;
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpSize = pSize;

            ViewBag.TitleSortParam = String.IsNullOrEmpty(sortOrder) ? "TitleDesc" : "";
            ViewBag.DescriptionSortParam = sortOrder == "DescriptionAsc" ? "DescriptionDesc" : "DescriptionAsc";
            ViewBag.SubDateSortParam = sortOrder == "SubDateAsc" ? "SubDateDesc" : "SubDateAsc";

            ViewBag.TView = "";
            ViewBag.DView = "";
            ViewBag.SDView = "";

            var assignments = assignemntRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(searchTitle))
            {
                assignments = assignments.Where(x => x.Title.ToUpper().Contains(searchTitle.ToUpper()));
            }
            if (!string.IsNullOrWhiteSpace(searchDescription))
            {
                assignments = assignments.Where(x => x.Description.ToUpper().Contains(searchDescription.ToUpper()));
            }
            if (!(searchMinSubDate is null))
            {
                assignments = assignments.Where(x => x.SubDate >= searchMinSubDate);
            }
            if (!(searchMaxSubDate is null))
            {
                assignments = assignments.Where(x => x.SubDate <= searchMaxSubDate);
            }


            switch (sortOrder)
            {
                case "TitleDesc": assignments = assignments.OrderByDescending(x => x.Title); ViewBag.TView = "bg-info text-white"; break;
                case "DescriptionAsc": assignments = assignments.OrderBy(x => x.Description); ViewBag.DView = "bg-primary text-white"; break;
                case "DescriptionDesc": assignments = assignments.OrderByDescending(x => x.Description); ViewBag.DView = "bg-info text-white"; break;
                case "SubDateAsc": assignments = assignments.OrderBy(x => x.SubDate); ViewBag.SDView = "bg-primary text-white"; break;
                case "SubDateDesc": assignments = assignments.OrderByDescending(x => x.SubDate); ViewBag.SDView = "bg-info text-white"; break;
                default: assignments = assignments.OrderBy(x => x.Title); ViewBag.TView = "bg-primary text-white"; break;

            }


            int pageSize = pSize ?? 5;
            int pageNumber = page ?? 1;  //nullable coehelesing operator


            return View(assignments.ToPagedList(pageNumber, pageSize));
        }

        // GET: Assignments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = assignemntRepository.GetById(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        // GET: Assignments/Create
        public ActionResult Create()
        {
            CourseRepository courseRepository = new CourseRepository();
            var courses = courseRepository.GetAll();

            ViewBag.CourseID = new SelectList(courses, "CourseID", "Title");
            return View();
        }

        // POST: Assignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssignmentId,Title,Description,SubDate,CourseID")] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                assignemntRepository.Insert(assignment);
                return RedirectToAction("AssignmentInfo");
            }

            CourseRepository courseRepository = new CourseRepository();
            var courses = courseRepository.GetAll();
            ViewBag.CourseID = new SelectList(courses, "CourseID", "Title", assignment.CourseID);

            return View(assignment);
        }

        // GET: Assignments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = assignemntRepository.GetById(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }

            CourseRepository courseRepository = new CourseRepository();
            var courses = courseRepository.GetAll();
            ViewBag.CourseID = new SelectList(courses, "CourseID", "Title", assignment.CourseID);

            return View(assignment);
        }

        // POST: Assignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssignmentId,Title,Description,SubDate,CourseID")] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                assignemntRepository.Update(assignment);
                return RedirectToAction("AssignmentInfo");
            }

            CourseRepository courseRepository = new CourseRepository();
            var courses = courseRepository.GetAll();
            ViewBag.CourseID = new SelectList(courses, "CourseID", "Title", assignment.CourseID);

            return View(assignment);
        }

        // GET: Assignments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = assignemntRepository.GetById(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        // POST: Assignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assignment assignment = assignemntRepository.GetById(id);
            assignemntRepository.Delete(assignment);
            return RedirectToAction("AssignmentInfo");
        }
    }
}
