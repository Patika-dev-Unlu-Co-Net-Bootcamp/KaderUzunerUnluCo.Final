using ProductUnluCo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Domain.Models
{
    public class Brand : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string BrandName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
