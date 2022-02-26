using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Abstract;

namespace UnluCo.Entities.Concrete
{
    public class Offerable:IEntity
    {

        public int OfferableId { get; set; }
            
        public double OfferedPrice { get; set; }
        public bool Status { get; set; }

        public bool Vote { get; set; }        
            
        public List<Product> Products { get; set; }

        
        public User User { get; set; }
    }
}
