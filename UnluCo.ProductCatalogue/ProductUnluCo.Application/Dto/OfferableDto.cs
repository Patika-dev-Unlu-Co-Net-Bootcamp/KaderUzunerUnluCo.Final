using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.Dto
{
    public class OfferableDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Guid UserId { get; set; }

        public double OfferedPrice { get; set; }

        public bool Vote { get; set; }
    }
}
