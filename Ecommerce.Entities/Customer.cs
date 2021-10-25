using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Entities
{
    public class Customer:EntityBase
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        [StringLength(11)]
        public string NumberId { get; set; }
    }
}
