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

namespace University.Web.Controllers
{
    public class StudentAssignmentMarksController : Controller
    {
        StudentAssignmentMarkRepository studentAssignmentMarkRepository = new StudentAssignmentMarkRepository();

        // GET: StudentAssignmentMarks
        public ActionResult Index()
        {
            var marks = studentAssignmentMarkRepository.GetAll();
            return View(marks);
        }

        // GET: StudentAssignmentMarks/Details/5
        public ActionResult Details(int? aid, int? sid)
        {
            if (aid == null || sid == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssignmentMark studentAssignmentMark = studentAssignmentMarkRepository.GetById(aid,sid);
            if (studentAssignmentMark == null)
            {
                return HttpNotFound();
            }
            return View(studentAssignmentMark);
        }

        // GET: StudentAssignmentMarks/Create
        public ActionResult Create()
        {
            ViewBag.AssignmentId = new SelectList(studentAssignmentMarkRepository.GetAllAssignmetns(), "AssignmentId", "Title");
            ViewBag.StudentId = new SelectList(studentAssignmentMarkRepository.GetAllStudents(), "StudentId", "FirstName");
            return View();
        }

        // POST: StudentAssignmentMarks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssignmentId,StudentId,OralMark,TotalMark")] StudentAssignmentMark studentAssignmentMark)
        {
            if (ModelState.IsValid)
            {
                studentAssignmentMarkRepository.Insert(studentAssignmentMark);
                return RedirectToAction("Index");
            }

            ViewBag.AssignmentId = new SelectList(studentAssignmentMarkRepository.GetAllAssignmetns(), "AssignmentId", "Title", studentAssignmentMark.AssignmentId);
            ViewBag.StudentId = new SelectList(studentAssignmentMarkRepository.GetAllStudents(), "StudentId", "FirstName", studentAssignmentMark.StudentId);
            return View(studentAssignmentMark);
        }

        // GET: StudentAssignmentMarks/Edit/5
        public ActionResult Edit(int? aid, int? sid)
        {
            if (aid == null || sid == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssignmentMark studentAssignmentMark = studentAssignmentMarkRepository.GetById(aid, sid);
            if (studentAssignmentMark == null)
            {
                return HttpNotFound();
            }
            ViewBag.AssignmentId = new SelectList(studentAssignmentMarkRepository.GetAllAssignmetns(), "AssignmentId", "Title", studentAssignmentMark.AssignmentId);
            ViewBag.StudentId = new SelectList(studentAssignmentMarkRepository.GetAllStudents(), "StudentId", "FirstName", studentAssignmentMark.StudentId);
            return View(studentAssignmentMark);
        }

        // POST: StudentAssignmentMarks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssignmentId,StudentId,OralMark,TotalMark")] StudentAssignmentMark studentAssignmentMark)
        {
            if (ModelState.IsValid)
            {
                studentAssignmentMarkRepository.Update(studentAssignmentMark);
                return RedirectToAction("Index");
            }
            ViewBag.AssignmentId = new SelectList(studentAssignmentMarkRepository.GetAllAssignmetns(), "AssignmentId", "Title", studentAssignmentMark.AssignmentId);
            ViewBag.StudentId = new SelectList(studentAssignmentMarkRepository.GetAllStudents(), "StudentId", "FirstName", studentAssignmentMark.StudentId);
            return View(studentAssignmentMark);
        }

        // GET: StudentAssignmentMarks/Delete/5
        public ActionResult Delete(int? aid, int? sid)
        {
            if (aid == null || sid == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssignmentMark studentAssignmentMark = studentAssignmentMarkRepository.GetById(aid, sid);
            if (studentAssignmentMark == null)
            {
                return HttpNotFound();
            }
            return View(studentAssignmentMark);
        }

        // POST: StudentAssignmentMarks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int aid, int sid)
        {
            StudentAssignmentMark studentAssignmentMark = studentAssignmentMarkRepository.GetById(aid, sid);
            studentAssignmentMarkRepository.Delete(studentAssignmentMark);
            return RedirectToAction("Index");
        }
    }
}
