using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProduct.Helper
{
    public class UserResourceParameter
    {
        public string searchQuery { get; set; }
        
        const int maxPageSize = 8;
        public string category { get; set; }
        public int PageNo { get; set; } = 1;

        private int _pageSize = 2;
        public int PageSize {
            get => _pageSize;
            set => _pageSize = (value > maxPageSize ? maxPageSize : value);
        }
        public string OrderType { get; set; }

        public string OrderBy { get; set; }
    }
}
