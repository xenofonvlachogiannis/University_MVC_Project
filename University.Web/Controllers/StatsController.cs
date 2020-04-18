using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Entities;
using University.Repository;
using University.Web.Models;
using University.Database;

namespace University.Web.Controllers
{
    public class StatsController : Controller
    {
        // GET: Stats
        public ActionResult Index()
        {
            StatsViewModel svm = new StatsViewModel();
            MyDatabase db = new MyDatabase();
            StudentRepository studentRepository = new StudentRepository();
            var students = studentRepository.GetAll();
            AssignemntRepository assignemntRepository = new AssignemntRepository();
            var assignments = assignemntRepository.GetAll();
            TrainerRepository trainerRepository = new TrainerRepository();
            var trainers = trainerRepository.GetAll();
            CourseRepository courseRepository = new CourseRepository();
            var courses = courseRepository.GetAll();

            svm.StudentsCount = students.Count();
            svm.AssignmentsCount = assignments.Count();
            svm.TrainersCount = trainers.Count();
            svm.CoursesCount = courses.Count();

            //Grouping Course Student
            svm.StudentsPerCourse = students
                         .SelectMany(x => x.Courses.Select(y => new
                         {
                             Key = y,
                             Value = x
                         }))
                         .GroupBy(y => y.Key, x => x.Value);

            //Grouping Course Trainer
            svm.TrainersPerCourse = trainers
                        .SelectMany(x => x.Courses.Select(y => new
                        {
                            Key = y,
                            Value = x
                        }))
                        .GroupBy(y => y.Key, x => x.Value);

            //Grouping Course Assignment
            svm.AssignmentPerCourse = courses
                        .SelectMany(x => x.Assignments.Select(y => new
                        {
                            Key = x,
                            Value = y
                        }))
                        .GroupBy(y => y.Key, x => x.Value);

            svm.Students = students;
            svm.Courses = courses;
            svm.Assignments = assignments;

            return View(svm);
        }
    }
}