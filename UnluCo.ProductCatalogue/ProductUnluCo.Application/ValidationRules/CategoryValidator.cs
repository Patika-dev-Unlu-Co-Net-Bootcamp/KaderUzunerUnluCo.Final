using FluentValidation;
using ProductUnluCo.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.ValidationRules
{
    public class CategoryValidator : AbstractValidator<CategoryDto>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().NotNull().WithMessage("Kategori boş geçilemez");
            RuleFor(x => x.CategoryName).MaximumLength(1).NotNull().WithMessage(" Bir kategori seçiniz");
        }
    }
}
