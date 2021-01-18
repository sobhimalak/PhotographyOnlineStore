using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using.PhotoographyOnlineStore.Core.Models;

namespace PhotoographyOnlineStore.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}