using ProductUnluCo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Domain.Models
{
    public class Offerable : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OfferableId { get; set; }

        public double OfferedPrice { get; set; }
        public bool Status { get; set; }

        public bool Vote { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
