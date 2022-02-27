using FluentValidation;
using ProductUnluCo.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.ValidationRules
{
    public class ProductValidator : AbstractValidator<ProductDto>
    {
        public ProductValidator()
    {
        RuleFor(x => x.ProductName).NotEmpty().NotNull().WithMessage("Ürün adı boş geçilemez");
     RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("Ürünün adı en fazla 100 karakter olabilir.");
     RuleFor(x => x.Descripton).MaximumLength(500).WithMessage("Açıklama 500 karakterden fazla olamaz.");
        RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez");

    

}
      
    }
}
