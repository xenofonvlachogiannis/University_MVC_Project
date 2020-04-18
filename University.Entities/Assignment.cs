using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Entities
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        [Required, StringLength(35, MinimumLength = 2)]
        public string Title { get; set; }
        [Required, StringLength(50,MinimumLength =5)]
        public string Description { get; set; }
        [DataType(DataType.Date),Display(Name="Submission Date")]
        public DateTime? SubDate { get; set; }
        [Display(Name = "Photo")]
        public string PhotoUrl { get; set; }

        public int? CourseID { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<StudentAssignmentMark> StudentAssignmentMarks { get; set; }
    }
}
