using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using University.Entities;

namespace University.Database
{
    public class MyDatabase : DbContext
    {
        public MyDatabase() : base ("UniversityConnection")
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<StudentAssignmentMark> StudentAssignmentMarks { get; set; }
    }
}
