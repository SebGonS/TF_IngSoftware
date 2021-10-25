using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DataAccess
{
    public interface ICustomerRepository
    {
        ICollection<Customer> GetCollection(string filter);
        Customer GetItem(int id);
        void Create(Customer entity);
        void Update(Customer entity);
        void Delete(int id);
    }
}
