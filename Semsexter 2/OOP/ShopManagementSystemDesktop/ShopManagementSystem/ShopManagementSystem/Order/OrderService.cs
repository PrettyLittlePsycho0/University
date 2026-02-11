using ShopManagementSystem.Customer;

namespace ShopManagementSystem.Order
{
    internal class OrderService
    {
        private readonly IOrderRepository _repo;

        public OrderService(IOrderRepository repository)
        {
            _repo = repository;
        }

        public bool Create(OrderModel order)
        {
            return _repo.Create(order);
        }

        public List<OrderModel> GetAll()
        {
            return _repo.GetAll();
        }
        public List<OrderModel> GetOrdersByCustomerId(int customerId)
        {
            return _repo.GetOrdersByCustomerId(customerId);
        }
    }
}