using API.IServices;
using Entities.Entities;
using Logic.Ilogic;
using Logic.Logic;

namespace API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        public void DeleteProduct(int id)
        {
            _productLogic.DeleteProduct(id);
        }

        public List<Product> GetAllProducts()
        {
            return _productLogic.GetAllProducts();
        }
        public int InsertProduct(Product product)
        {
            _productLogic.InsertProduct(product);
            return product.Id;
        }
        public void UpdateProduct(Product product)
        {
            _productLogic.UpdateProduct(product);

        }
    }
}


