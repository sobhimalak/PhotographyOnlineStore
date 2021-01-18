using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoographyOnlineStore.Models
{
    public class Basket : BaseEntity
    {
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCartItem()
        {
            this.ShoppingCartItems = new List<ShoppingCartItem>();
        }
    }
}