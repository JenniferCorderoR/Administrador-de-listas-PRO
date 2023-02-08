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
        void InsertProduct(Product product);
        void DeleteProduct(int id);

    }
}
