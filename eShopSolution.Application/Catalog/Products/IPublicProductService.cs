using eShopSolution.Application.Catalog.Products.DTO;
using eShopSolution.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedViewModel<ProductViewModel> GetAllPaging(string keyword, int pageIndex, int pageSize);
    }
}
