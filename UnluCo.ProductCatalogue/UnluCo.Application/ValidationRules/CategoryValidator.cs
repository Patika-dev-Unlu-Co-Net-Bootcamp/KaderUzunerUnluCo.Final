using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Concrete;

namespace UnluCo.Application.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().NotNull().WithMessage("Kategori boş geçilemez");
            RuleFor(x => x.CategoryName).MaximumLength(1).NotNull().WithMessage(" Bir kategori seçiniz");
        }
    }

}
