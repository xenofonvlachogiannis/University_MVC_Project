using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Entities
{
    public class Course :IValidatableObject
    {
        public int CourseID { get; set; }
        [Required, StringLength(30,MinimumLength =2)]
        public string Title { get; set; }
        [Required, StringLength(20)]
        public string Stream { get; set; }
        [Display(Name ="Photo")]
        public string PhotoUrl { get; set; }
        [Required,Display(Name ="Course Type")]
        public CourseType CourseType { get; set; }
        [DataType(DataType.Date), Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }
        [DataType(DataType.Date), Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        [Required,CustomValidation(typeof(ValidationMethods.ValidationMethods), "ValidateGreateOrEqualToZero")]
        public decimal Fees { get; set; }

        public virtual ICollection<Trainer> Trainers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }


        //Validation for End Date and Start Date
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EndDate<StartDate)
            {
               yield return new ValidationResult("End date can't be earlier than Start date.");
            }
        }
    }
}
