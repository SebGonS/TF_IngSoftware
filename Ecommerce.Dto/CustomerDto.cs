using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string NumberId { get; set; }
    }
}
