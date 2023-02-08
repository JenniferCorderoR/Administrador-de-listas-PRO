using Entities.Entities;

namespace API.IServices
{
    public interface IProductService
    {
        int InsertProduct(Product product);
        List<Product> GetAllProducts();
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }

}


