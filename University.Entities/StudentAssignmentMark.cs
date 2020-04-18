using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Entities
{
    public class StudentAssignmentMark
    {
        [Key, Column(Order = 0)]
        public int AssignmentId { get; set; }
        [Key, Column(Order = 1)]
        public int StudentId { get; set; }
        [Range(0, 100), Display(Name = "Oral Mark")]
        public double OralMark { get; set; }
        [Range(0, 100), Display(Name = "Total Mark")]
        public double TotalMark { get; set; }

        public virtual Student Student { get; set; }
        public virtual Assignment Assignment { get; set; }
    }
}
