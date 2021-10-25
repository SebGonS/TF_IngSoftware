using Ecommerce.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Services
{
    public interface ICustomerService
    { 
        ICollection<CustomerDto> GetCollection(string filter);
        CustomerDto GetCustomer(int id);
        void Create(CustomerDto entity);
        void Update(int id, CustomerDto entity);
        void Delete(int id);

    }
}
