using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.DTO
{
    public class PagedViewModel<T>
    {
        public List<T> Items { set; get; }
        public int TotalRecord { set; get; }
    }
}
