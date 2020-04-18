using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace University.Entities.ValidationMethods
{
    public class ValidationMethods
    {

        public static ValidationResult ValidateGreateOrEqualToZero (decimal value, ValidationContext context)
        {
            bool isValid = true;

            if (value < 0)
            {
                isValid = false;
            }

            if (isValid)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(string.Format("The field {0} must be greater than or equal to zero.", context.MemberName), new List<string> { context.MemberName });
            }
        }

    }
}
