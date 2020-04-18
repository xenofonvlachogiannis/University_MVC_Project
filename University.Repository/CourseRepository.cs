using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities;
using University.Database;
using System.Data.Entity;

namespace University.Repository
{
    public class CourseRepository
    {

        MyDatabase db = new MyDatabase();

        public IEnumerable<Course> GetAll()
        {
                return db.Courses.ToList();
        }

        public Course GetById(int? id)
        {
                return db.Courses.Find(id);
        }

        public void Insert(Course course, IEnumerable<int> SelectedTrainersId, IEnumerable<int> SelectedStudentsId, IEnumerable<int> SelectedAssignmentsId)
        {
            db.Courses.Attach(course);
            db.Entry(course).Collection("Trainers").Load();
            db.Entry(course).Collection("Students").Load();
            db.Entry(course).Collection("Assignments").Load();
            db.Entry(course).State = EntityState.Added;

            if (!(SelectedTrainersId is null))
            {
                foreach (var id in SelectedTrainersId)
                {
                    Trainer trainer = db.Trainers.Find(id);
                    if (trainer != null)
                    {
                        course.Trainers.Add(trainer);
                    }
                }
                db.SaveChanges();
            }

            if (!(SelectedStudentsId is null))
            {
                foreach (var id in SelectedStudentsId)
                {
                    Student student = db.Students.Find(id);
                    if (student != null)
                    {
                        course.Students.Add(student);
                    }
                }
                db.SaveChanges();
            }

            if (!(SelectedAssignmentsId is null))
            {
                foreach (var id in SelectedAssignmentsId)
                {
                    Assignment assignment = db.Assignments.Find(id);
                    if (assignment != null)
                    {
                        course.Assignments.Add(assignment);
                    }
                }
                db.SaveChanges();
            }
            db.SaveChanges();
        }

        public void Update(Course course, IEnumerable<int> SelectedTrainersId, IEnumerable<int> SelectedStudentsId, IEnumerable<int> SelectedAssignmentsId)
        {
            db.Courses.Attach(course);
            db.Entry(course).Collection("Trainers").Load();
            db.Entry(course).Collection("Students").Load();
            db.Entry(course).Collection("Assignments").Load();
            course.Trainers.Clear();
            course.Students.Clear();
            course.Assignments.Clear();
            db.SaveChanges();

            if (!(SelectedTrainersId is null))
            {
                foreach (var id in SelectedTrainersId)
                {
                    Trainer trainer = db.Trainers.Find(id);
                    if (trainer != null)
                    {
                        course.Trainers.Add(trainer);
                    }
                }
                db.SaveChanges();
            }

            if (!(SelectedStudentsId is null))
            {
                foreach (var id in SelectedStudentsId)
                {
                    Student student = db.Students.Find(id);
                    if (student != null)
                    {
                        course.Students.Add(student);
                    }
                }
                db.SaveChanges();
            }
            if (!(SelectedAssignmentsId is null))
            {
                foreach (var id in SelectedAssignmentsId)
                {
                    Assignment assignment = db.Assignments.Find(id);
                    if (assignment != null)
                    {
                        course.Assignments.Add(assignment);
                    }
                }
                db.SaveChanges();
            }

            db.Entry(course).State = EntityState.Modified;
            db.SaveChanges();
        }
        
        public void Delete(Course course)
        {


            db.Entry(course).State = EntityState.Deleted;
                db.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
