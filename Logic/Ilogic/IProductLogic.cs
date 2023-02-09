using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Logic.Ilogic
{
    public interface IProductLogic
    {
        List<Product> GetAllProducts();
        int InsertProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);



    }
}
