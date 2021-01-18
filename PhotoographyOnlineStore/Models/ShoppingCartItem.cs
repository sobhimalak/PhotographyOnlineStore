using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoographyOnlineStore.Models
{
    public class ShoppingCartItem
    {
        public string ShoppingCartId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}