using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Entities
{
     public class Product:EntityBase
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string Price { get; set; }
        public bool Enabled { get;set; }
    }
}
