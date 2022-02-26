using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Domain.Models;
using UnluCo.Entities.Abstract;

namespace UnluCo.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Descripton { get; set; }
        public string Image { get; set; }
        
        public int Price { get; set; }
        public bool Status { get; set; }
     
        public Brand Brand { get; set; }
   
        public Color Color { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Offerable> Offerables { get; set; }

    }
}
