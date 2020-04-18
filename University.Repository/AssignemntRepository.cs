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
    public class AssignemntRepository
    {
        MyDatabase db = new MyDatabase();
        public IEnumerable<Assignment> GetAll()
        {
                return db.Assignments.ToList();
        }

        public Assignment GetById(int? id)
        {
                return db.Assignments.Find(id);
        }

        public void Insert(Assignment assignment)
        {
                db.Entry(assignment).State = EntityState.Added;
                db.SaveChanges();
        }

        public void Update(Assignment assignment)
        {
                db.Entry(assignment).State = EntityState.Modified;
                db.SaveChanges();
        }

        public void Delete(Assignment assignment)
        {
                db.Entry(assignment).State = EntityState.Deleted;
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
