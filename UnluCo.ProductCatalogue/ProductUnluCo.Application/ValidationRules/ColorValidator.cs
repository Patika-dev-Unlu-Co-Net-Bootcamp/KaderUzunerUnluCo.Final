using FluentValidation;
using ProductUnluCo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.ValidationRules
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(x => x.ColorName).MaximumLength(1).WithMessage("Ürünün tek rengi olabilir");
        }
    }
}
