using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoographyOnlineStore.ViewModels
{
    public class ShoppingCartSummaryViewModel
    {
        public int ShoppingCartCount { get; set; }
        public decimal ShoppingCartTotal { get; set; }

        public ShoppingCarttSummaryViewModel()
        {

        }
        public ShoppingCartSummaryViewModel(int shoppingCartCount, decimal shoppingCartTotal)
        {
            this.ShoppingCartCount = shoppingCartCount;
            this.ShoppingCartTotal = shoppingCartTotal;
        }
    }
}