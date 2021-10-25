using Ecommerce.DataAccess;
using Ecommerce.Dto;
using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }
        public void Create(CustomerDto entity)
        {
            _repository.Create(new Customer
            {
                Name = entity.Name,
                BirthDate = entity.BirthDate,
                NumberId = entity.NumberId
            });
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public ICollection<CustomerDto> GetCollection(string filter)
        {
            var collection = _repository.GetCollection(filter ?? string.Empty);
            return collection
                .Select(c => new CustomerDto
                {
                    Id = c.Id,
                    Name=c.Name,
                    BirthDate=c.BirthDate,
                    NumberId=c.NumberId
                })
                .ToList();
        }

        public CustomerDto GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, CustomerDto entity)
        {
            _repository.Update(new Customer
            {
                Name = entity.Name,
                BirthDate = entity.BirthDate,
                NumberId = entity.NumberId
            });
        } 
    }
}
 