using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoographyOnlineStore.Contracts
{
    public class IBasketServices
    {
        void AddToBasket(HttpContextBase httpContext, string productId);

        void RemoveFromBasket(HttpContextBase httpContext, string itemId);

        List<BasketItemViewModel> GetBasketItems(HttpContextBase httpContext);

        BasketSummaryViewModel GetBasketSummary(HttpContextBase httpContext);
    }
}