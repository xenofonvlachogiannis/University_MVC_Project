using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Database;
using University.Entities;

namespace University.Repository
{
    public class StudentRepository
    {
        MyDatabase db = new MyDatabase();
        public IEnumerable<Student> GetAll()
        {
                return db.Students.ToList();
        }

        public Student GetById(int? id)
        {
                return db.Students.Find(id);
        }

        public void Insert(Student student, IEnumerable<int> SelectedCoursesId)
        {
            db.Students.Attach(student);
            db.Entry(student).Collection("Courses").Load();
            db.Entry(student).State = EntityState.Added;

            if (!(SelectedCoursesId is null))
            {
                foreach (var id in SelectedCoursesId)
                {
                    Course course = db.Courses.Find(id);
                    if (course != null)
                    {
                        student.Courses.Add(course);
                    }
                }
                db.SaveChanges();
            }
                db.SaveChanges();
        }

        public void Update(Student student, IEnumerable<int> SelectedCoursesId)
        {
            db.Students.Attach(student);
            db.Entry(student).Collection("Courses").Load();
            student.Courses.Clear();
            db.SaveChanges();

            if (!(SelectedCoursesId is null))
            {
                foreach (var id in SelectedCoursesId)
                {
                    Course course = db.Courses.Find(id);
                    if (course != null)
                    {
                        student.Courses.Add(course);
                    }
                }
                db.SaveChanges();
            }

            db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
        }

        public void Delete(Student student)
        {
                db.Entry(student).State = EntityState.Deleted;
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
