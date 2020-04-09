using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPIDapper.Models;
namespace CoreAPIDapper.Repository
{
   public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer> GetCustomerByID(int id);
        Task<Customer> ADDEditCustomer(Customer customer);
        Task<Customer> DeleteCustomer(int id);
    }
}
