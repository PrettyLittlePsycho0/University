using ShopManagementSystem.Common;

namespace ShopManagementSystem.Product
{
    internal class ProductService
    {
        private readonly IProductRepository _repo;



        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public bool Create(ProductModel product)
        {
            return _repo.Create(product);
        }

        public bool Update(ProductModel updated)
        { 
            return _repo.Update(new ProductModel(updated));
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public List<ProductModel> GetAll()
        {
            return _repo.GetAll();
        }

        public ProductModel GetProductById(int id)
        {
            return _repo.GetProductById(id);
        }

        public List<ProductModel> GetProductByName(string name)
        {
            return _repo.GetByName(name);
        }

        public List<ProductModel> GetProductsByPrice(double price)
        {
            return _repo.GetByPrice(price);
        }
        public List<ProductModel> GetProductsByPriceRange(double from, double to)
        {
            return _repo.GetByPriceRange(from, to);
        }
        public List<ProductModel> GetProductsByPriceDifference(double difference)
        {
            return _repo.GetByPriceDifference(difference);
        }
        public List<ProductModel> GetProductsBySubString(string subString)
        {
            return _repo.GetBySubString(subString);
        }
        public bool Exists(int id)
        {
            return _repo.Exists(id);
        }
    }
} 