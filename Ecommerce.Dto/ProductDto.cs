using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string UrlImage { get; set; }
        public bool Enabled { get; set; }
    }
}
