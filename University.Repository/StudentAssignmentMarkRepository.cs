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
    public class StudentAssignmentMarkRepository
    {
        MyDatabase db = new MyDatabase();

        public IEnumerable<StudentAssignmentMark> GetAll()
        {
                return db.StudentAssignmentMarks.ToList();
        }

        public StudentAssignmentMark GetById(int? aid, int? sid)
        {
                return db.StudentAssignmentMarks.Find(aid, sid);
        }

        public void Insert(StudentAssignmentMark studentAssignmentMark)
        {
                db.Entry(studentAssignmentMark).State = EntityState.Added;
                db.SaveChanges();
        }

        public void Update(StudentAssignmentMark studentAssignmentMark)
        {
                db.Entry(studentAssignmentMark).State = EntityState.Modified;
                db.SaveChanges();
        }

        public void Delete(StudentAssignmentMark studentAssignmentMark)
        {
                db.Entry(studentAssignmentMark).State = EntityState.Deleted;
                db.SaveChanges();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return db.Students.ToList();
        }

        public IEnumerable<Assignment> GetAllAssignmetns()
        {
            return db.Assignments.ToList();
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
