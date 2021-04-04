using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<Image>
    {
        public CarImageValidator()
        {
            RuleFor(c => c.CarId).NotNull();
            RuleFor(c => c.CarId).NotNull();
        }
    }
}
