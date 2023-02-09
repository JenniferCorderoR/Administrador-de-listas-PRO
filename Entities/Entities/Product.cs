using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Product
    {
        public Product()
        {
            IsActive = true;
            IsPublic = true;
        }
       /* public Guid IdWeb { get; set; }*/
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
    }
}