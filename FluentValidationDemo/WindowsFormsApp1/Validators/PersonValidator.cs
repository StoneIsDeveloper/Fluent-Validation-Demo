using CoreModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://fluentvalidation.net/

namespace WindowsFormsApp1.Validators
{
    public class PersonValidator : AbstractValidator<PersonalModel>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2,10).WithMessage("Length ({TotalLength}) of {PropertyName} Invalid, length should between 2 and 10.")
                .Must(BaAValidName).WithMessage("{PropertyName} Contains Invalid Characters.");
            
            RuleFor(p => p.LastName)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("{PropertyName} is Empty")
               .Length(2, 10).WithMessage("Length ({TotalLength}) of {PropertyName} Invalid, length should between 2 and 10.")
               .Must(BaAValidName).WithMessage("{PropertyName} Contains Invalid Characters.");

            RuleFor(p => p.DateOfBirth)
                .Must(BaAValidAge).WithMessage("Invalid {PropertyName}");

        }

        private bool BaAValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dobYear = date.Year;
            
            if(dobYear <= currentYear && dobYear > (currentYear - 120))
            {
                return true;
            }

            return false;
        }

        protected bool BaAValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }
    }
}
