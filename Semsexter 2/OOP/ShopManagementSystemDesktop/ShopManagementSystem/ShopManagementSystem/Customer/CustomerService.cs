using ShopManagementSystem.Common;

namespace ShopManagementSystem.Customer
{
    internal class CustomerService
    {
        private readonly ICustomerRepository _repo;
 
        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public bool Create(CustomerModel customer)
        {
            if (_repo.GetByPhoneNumber(customer.phoneNumber) != null)
            {
                return false;
            }
            return _repo.Create(customer);
        }

        public bool Update(CustomerModel updated)
        {
            return _repo.Update(new CustomerModel(updated));
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public List<CustomerModel> GetAll()
        {
            return _repo.GetAll();
        }

        public CustomerModel GetCustomerById(int id)
        {
            return _repo.GetCustomerById(id);
        }

        public List<CustomerModel> GetCustomerByName(string name)
        {
            return _repo.GetByName(name);
        }
        public List<CustomerModel> GetCustomerByFirstChar(string ch)
        {
            return _repo.GetByFirstChar(ch);
        }
        public CustomerModel GetCustomerByPhoneNumber(string phoneNumber)
        {
            return _repo.GetByPhoneNumber(phoneNumber);
        }

        public List<CustomerModel> GetCustomerByAddress(string address)
        {
            return _repo.GetByAddress(address);
        }

        public List<CustomerModel> GetCustomerByAge(int age)
        {
            return _repo.GetByAge(age);
        }

        public bool Exists(int id)
        {
            return _repo.Exists(id);
        }
    }
}