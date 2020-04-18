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
    public class TrainersController : Controller
    {
        TrainerRepository trainerRepository = new TrainerRepository();

        // GET: Trainers
        public ActionResult Index()
        {
            var trainers = trainerRepository.GetAll();
            ViewBag.TrainersCount = trainers.Count();
            return View(trainers);
        }

        public ActionResult TrainerInfo(string sortOrder, string searchFirstName, string searchLastName, string searchSubject, int? page, int? pSize)
        {
            ViewBag.CurrentFirstName = searchFirstName;
            ViewBag.CurrentLastName = searchLastName;
            ViewBag.CurrentSubject = searchSubject;
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpSize = pSize;

            ViewBag.FNameSortParam = String.IsNullOrEmpty(sortOrder) ? "FirstNameDesc" : "";
            ViewBag.LNameSortParam = sortOrder == "LastNameAsc" ? "LastNameDesc" : "LastNameAsc";
            ViewBag.SubjectSortParam = sortOrder == "SubjectAsc" ? "SubjectDesc" : "SubjectAsc";

            ViewBag.FView = "";
            ViewBag.LView = "";
            ViewBag.SView = "";

            var trainers = trainerRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(searchFirstName))
            {
                trainers = trainers.Where(x => x.FirstName.ToUpper().Contains(searchFirstName.ToUpper()));
            }
            if (!string.IsNullOrWhiteSpace(searchLastName))
            {
                trainers = trainers.Where(x => x.LastName.ToUpper().Contains(searchLastName.ToUpper()));
            }
            if (!string.IsNullOrWhiteSpace(searchSubject))
            {
                trainers = trainers.Where(x => x.Subject.ToUpper().Contains(searchSubject.ToUpper()));
            }


            switch (sortOrder)
            {
                case "FirstNameDesc": trainers = trainers.OrderByDescending(x => x.FirstName); ViewBag.FView = "bg-info text-white"; break;
                case "LastNameAsc": trainers = trainers.OrderBy(x => x.LastName); ViewBag.LView = "bg-primary text-white"; break;
                case "LastNameDesc": trainers = trainers.OrderByDescending(x => x.LastName); ViewBag.LView = "bg-info text-white"; break;
                case "SubjectAsc": trainers = trainers.OrderBy(x => x.Subject); ViewBag.SView = "bg-primary text-white"; break;
                case "SubjectDesc": trainers = trainers.OrderByDescending(x => x.Subject); ViewBag.SView = "bg-info text-white"; break;
                default: trainers = trainers.OrderBy(x => x.FirstName); ViewBag.FView = "bg-primary text-white"; break;

            }


            int pageSize = pSize ?? 3;
            int pageNumber = page ?? 1;  //nullable coehelesing operator


            return View(trainers.ToPagedList(pageNumber, pageSize));
        }


        // GET: Trainers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = trainerRepository.GetById(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        // GET: Trainers/Create
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

        // POST: Trainers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrainerId,FirstName,LastName,Subject")] Trainer trainer, IEnumerable<int> SelectedCoursesId)
        {
            if (ModelState.IsValid)
            {
                trainerRepository.Insert(trainer, SelectedCoursesId);
                return RedirectToAction("TrainerInfo");
            }

            return View(trainer);
        }

        // GET: Trainers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = trainerRepository.GetById(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }

            CourseRepository courseRepository = new CourseRepository();
            ViewBag.SelectedCoursesId = courseRepository.GetAll().Select(x => new SelectListItem()
            {
                Value = x.CourseID.ToString(),
                Text = x.Title,
                Selected = trainer.Courses.Any(y=>y.CourseID == x.CourseID)
            });

            return View(trainer);
        }

        // POST: Trainers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrainerId,FirstName,LastName,Subject")] Trainer trainer, IEnumerable<int> SelectedCoursesId)
        {
            if (ModelState.IsValid)
            {
                trainerRepository.Update(trainer, SelectedCoursesId);
                return RedirectToAction("TrainerInfo");
            }
            return View(trainer);
        }

        // GET: Trainers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = trainerRepository.GetById(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        // POST: Trainers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trainer trainer = trainerRepository.GetById(id);
            trainerRepository.Delete(trainer);
            return RedirectToAction("TrainerInfo");
        }
    }
}
