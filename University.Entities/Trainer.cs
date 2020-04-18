using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Entities
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        [Required, StringLength(25), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, StringLength(35), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required, StringLength(20)]
        public string Subject { get; set; }
        [Display(Name = "Photo")]
        public string PhotoUrl { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
