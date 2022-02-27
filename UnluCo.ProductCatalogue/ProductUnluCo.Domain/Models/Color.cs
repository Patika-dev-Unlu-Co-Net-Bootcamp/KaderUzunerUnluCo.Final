using ProductUnluCo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Domain.Models
{
    public class Color : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
