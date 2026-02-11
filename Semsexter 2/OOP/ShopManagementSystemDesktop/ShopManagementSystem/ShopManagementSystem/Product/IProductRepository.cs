using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementSystem.Product
{
    internal interface IProductRepository
    {
        bool Create(ProductModel product);
        bool Update(ProductModel updated);
        bool Delete(int id);
        List<ProductModel> GetAll();
        ProductModel GetProductById(int id);
        List<ProductModel> GetByName(string name);
        List<ProductModel> GetByPrice(double price);
        List<ProductModel> GetByPriceRange(double from, double to);
        List<ProductModel> GetBySubString(string subString);
        List<ProductModel> GetByPriceDifference(double difference);
        bool Exists(int id);
    }
}
