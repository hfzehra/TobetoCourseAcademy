using Entity.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator :AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(3);
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Price).GreaterThan(0);
            RuleFor(c => c.Price).GreaterThanOrEqualTo(10).When(c => c.CategoryId == 1);
            RuleFor(c => c.Name).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
