using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities.Entities;
using Logic.Ilogic;

namespace Logic.Logic
{
    public class ProductLogic : BaseContextLogic, IProductLogic
    {
        public ProductLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public List<Product> GetAllProducts()
        {
            return _serviceContext.Set<Product>().ToList();
        }
        public int InsertProduct(Product product)
        {
            _serviceContext.Products.Add(product);
            _serviceContext.SaveChanges();
            return product.Id;
        }
  
        public void DeleteProduct(int id)
        {
            var productToDelete = _serviceContext.Set<Product>()
                .Where(x => x.Id == id);
            _serviceContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
