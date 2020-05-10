using eShopSolution.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.DTO.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int CatagoryId { get; set; }
    }
}
