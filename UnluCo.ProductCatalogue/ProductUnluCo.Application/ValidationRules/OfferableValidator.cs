using FluentValidation;
using ProductUnluCo.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.ValidationRules
{
    public class OfferableValidator : AbstractValidator<OfferableDto>
    {
        public OfferableValidator()
        {
            RuleFor(o => o.OfferedPrice).GreaterThan(0);
            RuleFor(o => o.ProductId).GreaterThan(0);
          
            
        }
    }
}
