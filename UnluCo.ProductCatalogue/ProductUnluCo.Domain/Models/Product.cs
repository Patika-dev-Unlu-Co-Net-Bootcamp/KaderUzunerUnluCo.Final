using ProductUnluCo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Domain.Models
{
    public class Product : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Descripton { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }  
        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }
        public int CategoryId { get; set; }
        public  virtual Category Category { get; set; }
        public string UserId { get; set; }
        public virtual User  User { get; set; }
        public virtual List<Offerable> Offerables { get; set; }

    }
}
