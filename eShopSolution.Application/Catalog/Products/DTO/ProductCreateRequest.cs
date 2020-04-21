using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.DTO
{
    public class ProductCreateRequest
    {
        public String Name { get; set; }
        public decimal Price { get; set; }
    }
}
