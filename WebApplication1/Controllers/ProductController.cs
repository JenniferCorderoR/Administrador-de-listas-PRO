using API.IServices;
using Entities.Entities;
using Entities.SearchFilters;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{


    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpPost(Name = "InsertProduct")]
        public int Post([FromBody] Product product)
        {
            return _productService.InsertProduct(product);
        }

        [HttpGet(Name = "GetAllProducts")]
        public List<Product> GetAll()
        {
            //     _userService.ValidateCredentials(userItem);
            return _productService.GetAllProducts();
        }

        [HttpDelete(Name = "DeleteProduct")]

        public void DeleteProductItem([FromQuery] int id)
          {
           _productService.DeleteProduct(id);
        }

        [HttpPatch(Name = "ModifyProduct")]
        public void Patch([FromBody] Product product)
            {
              _productService.UpdateProduct(product);
        }
    }
}

