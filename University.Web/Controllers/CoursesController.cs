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
    public class CoursesController : Controller
    {
        CourseRepository courseRepository = new CourseRepository();

        // GET: Courses
        public ActionResult Index()
        {
            var courses = courseRepository.GetAll();
            ViewBag.coursescount = courses.Count();
            return View(courses);
        }

        public ActionResult CourseInfo(string sortOrder, string searchTitle, string searchStream, string searchType, decimal? searchMinFees, decimal? searchMaxFees, DateTime? searchStartDate, DateTime? searchEndDate, int? page, int? pSize)
        {
            ViewBag.CurrentTitle = searchTitle;
            ViewBag.CurrentStream = searchStream;
            ViewBag.CurrentType = searchType;
            ViewBag.CurrentMinFees = searchMinFees;
            ViewBag.CurrentMaxFees = searchMaxFees;
            ViewBag.CurrentStartDate = searchStartDate;
            ViewBag.CurrentEndDate = searchEndDate;
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpSize = pSize;

            ViewBag.TitleSortParam = String.IsNullOrEmpty(sortOrder) ? "TitleDesc" : "";
            ViewBag.StreamSortParam = sortOrder == "StreamAsc" ? "StreamDesc" : "StreamAsc";
            ViewBag.TypeSortParam = sortOrder == "TypeAsc" ? "TypeDesc" : "TypeAsc";
            ViewBag.FeesSortParam = sortOrder == "FeesAsc" ? "FeesDesc" : "FeesAsc";
            ViewBag.StartDateSortParam = sortOrder == "StartDateAsc" ? "StartDateDesc" : "StartDateAsc";
            ViewBag.EndDateSortParam = sortOrder == "EndDateAsc" ? "EndDateDesc" : "EndDateAsc";

            ViewBag.TView = "";
            ViewBag.STRView = "";
            ViewBag.TYView = "";
            ViewBag.FView = "";
            ViewBag.SDView = "";
            ViewBag.EDView = "";

            var courses = courseRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(searchTitle))
            {
                courses = courses.Where(x => x.Title.ToUpper().Contains(searchTitle.ToUpper()));
            }
            if (!string.IsNullOrWhiteSpace(searchStream))
            {
                courses = courses.Where(x => x.Stream.ToUpper().Contains(searchStream.ToUpper()));
            }
            if (!string.IsNullOrWhiteSpace(searchType))
            {
                courses = courses.Where(x => x.CourseType.ToString().ToUpper().Contains(searchType.ToUpper()));
            }
            if (!(searchMinFees is null))
            {
                courses = courses.Where(x => x.Fees >= searchMinFees);
            }
            if (!(searchMaxFees is null))
            {
                courses = courses.Where(x => x.Fees <= searchMaxFees);
            }
            if (!(searchStartDate is null))
            {
                courses = courses.Where(x => x.StartDate >= searchStartDate);
            }
            if (!(searchEndDate is null))
            {
                courses = courses.Where(x => x.EndDate <= searchEndDate);
            }

            switch (sortOrder)
            {
                case "TitleDesc": courses = courses.OrderByDescending(x => x.Title); ViewBag.TView = "bg-info text-white"; break;
                case "StreamAsc": courses = courses.OrderBy(x => x.Stream); ViewBag.STRView = "bg-primary text-white"; break;
                case "StreamDesc": courses = courses.OrderByDescending(x => x.Stream); ViewBag.STRView = "bg-info text-white"; break;
                case "TypeAsc": courses = courses.OrderBy(x => x.CourseType); ViewBag.TYView = "bg-primary text-white"; break;
                case "TypeDesc": courses = courses.OrderByDescending(x => x.CourseType); ViewBag.TYView = "bg-info text-white"; break;
                case "FeesAsc": courses = courses.OrderBy(x => x.Fees); ViewBag.FView = "bg-primary text-white"; break;
                case "FeesDesc": courses = courses.OrderByDescending(x => x.Fees); ViewBag.FView = "bg-info text-white"; break;
                case "StartDateAsc": courses = courses.OrderBy(x => x.StartDate); ViewBag.SDView = "bg-primary text-white"; break;
                case "StartDateDesc": courses = courses.OrderByDescending(x => x.StartDate); ViewBag.SDView = "bg-info text-white"; break;
                case "EndDateAsc": courses = courses.OrderBy(x => x.EndDate); ViewBag.EDView = "bg-primary text-white"; break;
                case "EndDateDesc": courses = courses.OrderByDescending(x => x.EndDate); ViewBag.EDView = "bg-info text-white"; break;
                default: courses = courses.OrderBy(x => x.Title); ViewBag.TView = "bg-primary text-white"; break;

            }


            int pageSize = pSize ?? 3;
            int pageNumber = page ?? 1;  //nullable coehelesing operator


            return View(courses.ToPagedList(pageNumber, pageSize));
        }



        // GET: Courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = courseRepository.GetById(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            AssignemntRepository assignemntRepository = new AssignemntRepository();
            ViewBag.SelectedAssignmentsId = assignemntRepository.GetAll().Select(x => new SelectListItem()
            {
                Value = x.AssignmentId.ToString(),
                Text = x.Title
            });

            TrainerRepository trainerRepository = new TrainerRepository();
            ViewBag.SelectedTrainersId = trainerRepository.GetAll().Select(x => new SelectListItem()
            {
                Value = x.TrainerId.ToString(),
                Text = x.LastName
            });

            StudentRepository studentRepository = new StudentRepository();
            ViewBag.SelectedStudentsId = studentRepository.GetAll().Select(x => new SelectListItem()
            {
                Value = x.StudentId.ToString(),
                Text = x.LastName
            });

            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseID,Title,Stream,PhotoUrl,CourseType,StartDate,EndDate,Fees")] Course course, IEnumerable<int> SelectedTrainersId, IEnumerable<int> SelectedStudentsId, IEnumerable<int> SelectedAssignmentsId)
        {
            if (ModelState.IsValid)
            {
                courseRepository.Insert(course, SelectedTrainersId, SelectedStudentsId, SelectedAssignmentsId);
                return RedirectToAction("CourseInfo");
            }

            return View(course);
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = courseRepository.GetById(id);
            if (course == null)
            {
                return HttpNotFound();
            }

            TrainerRepository trainerRepository = new TrainerRepository();
            ViewBag.SelectedTrainersId = trainerRepository.GetAll().Select(x => new SelectListItem()
            {
                Value = x.TrainerId.ToString(),
                Text = x.LastName,
                Selected = course.Trainers.Any(y => y.TrainerId == x.TrainerId)
            });

            StudentRepository studentRepository = new StudentRepository();

            ViewBag.SelectedStudentsId = studentRepository.GetAll().Select(x => new SelectListItem()
            {
                Value = x.StudentId.ToString(),
                Text = x.LastName,
                Selected = course.Students.Any(y => y.StudentId == x.StudentId)
            });

            AssignemntRepository assignemntRepository = new AssignemntRepository();
            ViewBag.SelectedAssignmentsId = assignemntRepository.GetAll().Select(x => new SelectListItem()
            {
                Value = x.AssignmentId.ToString(),
                Text = x.Title,
                Selected = course.Assignments.Any(y => y.AssignmentId == x.AssignmentId)
            });

            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseID,Title,Stream,PhotoUrl,CourseType,StartDate,EndDate,Fees")] Course course, IEnumerable<int> SelectedTrainersId, IEnumerable<int> SelectedStudentsId, IEnumerable<int> SelectedAssignmentsId)
        {
            if (ModelState.IsValid)
            {
                courseRepository.Update(course, SelectedTrainersId, SelectedStudentsId, SelectedAssignmentsId);
                return RedirectToAction("CourseInfo");
            }
            return View(course);
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = courseRepository.GetById(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course course = courseRepository.GetById(id);
            if (course.Assignments.Count > 0)
            {
                return View("Error");
            }
            else
            {
                courseRepository.Delete(course);
                return RedirectToAction("CourseInfo");
            }

        }

    }
}
