using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Ecommerce.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly EcommerceDbContext _context;
        public CustomerRepository(EcommerceDbContext context)
        {
            _context = context;
        }
        public void Create(Customer entity)
        {
            _context.Set<Customer>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Entry(new Customer
            {
                Id = id
            }).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public ICollection<Customer> GetCollection(string filter)
        {
            return _context.Customers
                .Where(c => c.Name.Contains(filter))
                .ToList();
        }

        public Customer GetItem(int id)
        {
            return _context.Customers.Find(id);
        }

        public void Update(Customer entity)
        {
            _context.Set<Customer>().Attach(entity);
            _context.Entry(entity).State=EntityState.Modified;
            _context.SaveChanges();
        }
    }
}