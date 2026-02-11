using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementSystem.Customer
{
    internal interface ICustomerRepository
    {
        bool Create(CustomerModel customer);
        bool Update(CustomerModel updated);
        bool Delete(int id);
        List<CustomerModel> GetAll();
        CustomerModel GetCustomerById(int id);
        List<CustomerModel> GetByName(string name);
        List<CustomerModel> GetByAge(int age);
        List<CustomerModel> GetByFirstChar(string ch);
        CustomerModel GetByPhoneNumber(string phoneNumber);
        List<CustomerModel> GetByAddress(string address);
        bool Exists(int id);
    }
}
