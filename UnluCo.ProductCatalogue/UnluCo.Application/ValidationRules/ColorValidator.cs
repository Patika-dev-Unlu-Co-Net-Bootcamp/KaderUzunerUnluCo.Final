using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Domain.Models;

namespace UnluCo.Application.ValidationRules
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(x => x.ColorName).MaximumLength(1).NotNull().WithMessage("Ürünün tek rengi olabilir");
        }
    }
}
