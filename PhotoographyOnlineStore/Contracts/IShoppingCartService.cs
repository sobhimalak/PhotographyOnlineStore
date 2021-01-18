using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoographyOnlineStore.Contracts
{
    public interface IShoppingCartService
    {
        void AddToShoppingCart(HttpContextBase httpContext, string productId);
        void RemoveFromShoppingCart(HttpContextBase httpContext, string itemId);
        List<ShoppingCartItemViewModel> GetShoppingCartItems(HttpContextBase httpContext);
        ShoppingCartSummaryViewModel GetShoppingCartSummary(HttpContextBase httpContext);
    }
}
