using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Concrete;

namespace UnluCo.Application.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().NotNull().WithMessage("Ürün adı boş geçilemez");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("Ürünün adı en fazla 100 karakter olabilir.");
            RuleFor(x => x.Descripton).MaximumLength(500).WithMessage("Açıklama 500 karakterden fazla olamaz.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez");
           
            RuleFor(x => x.Status).NotEmpty().WithMessage("Kullanım durumu boş geçilemez");
            
        }
      
    }
}
