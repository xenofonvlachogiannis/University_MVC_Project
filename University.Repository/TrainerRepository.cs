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
    public class TrainerRepository
    {
        MyDatabase db = new MyDatabase();
        public IEnumerable<Trainer> GetAll()
        {
            return db.Trainers.ToList();
        }

        public Trainer GetById(int? id)
        {
            return db.Trainers.Find(id);
        }

        public void Insert(Trainer trainer, IEnumerable<int> SelectedStudentsId)
        {

            db.Trainers.Attach(trainer);
            db.Entry(trainer).Collection("Courses").Load();
            db.Entry(trainer).State = EntityState.Added;

            if (!(SelectedStudentsId is null))
            {
                foreach (var id in SelectedStudentsId)
                {
                    Course course = db.Courses.Find(id);
                    if (course != null)
                    {
                        trainer.Courses.Add(course);
                    }
                }
                db.SaveChanges();
            }
            db.SaveChanges();
        }

        public void Update(Trainer trainer, IEnumerable<int> SelectedStudentsId)
        {
            db.Trainers.Attach(trainer);
            db.Entry(trainer).Collection("Courses").Load();
            trainer.Courses.Clear();
            db.SaveChanges();

            if (!(SelectedStudentsId is null))
            {
                foreach (var id in SelectedStudentsId)
                {
                    Course course = db.Courses.Find(id);
                    if (course != null)
                    {
                        trainer.Courses.Add(course);
                    }
                }
                db.SaveChanges();
            }

            db.Entry(trainer).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Trainer trainer)
        {
            db.Entry(trainer).State = EntityState.Deleted;
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
