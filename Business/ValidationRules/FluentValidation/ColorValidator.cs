using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.ColorName).NotEmpty();
            RuleFor(c => c.ColorName).MinimumLength(3).WithMessage("Renk adı en az 3 karakter uzunluğunda olmalıdır.");
            RuleFor(p => p.ColorName).NotNull();
        }
    }
}
