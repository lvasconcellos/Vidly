using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YeardsIfMember : ValidationAttribute
    {   
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.Unknown 
                || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.BirthDate == null)
                return new ValidationResult("BirthDate is required");

            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;
            if (DateTime.Now.DayOfYear < customer.BirthDate.Value.DayOfYear)
                age -= 1;

            return age > 17 
                ? ValidationResult.Success 
                : new ValidationResult("Customer must be 18 years old or older to go on a membership");
        }
    }
}