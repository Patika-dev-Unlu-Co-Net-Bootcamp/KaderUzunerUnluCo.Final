using ProductUnluCo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Domain.Models
{
    public class Category : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }
        public virtual List<Product> Products { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
 }

