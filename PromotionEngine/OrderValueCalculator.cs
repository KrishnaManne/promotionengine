using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{    
    public class OrderValueCalculator : IOrderValueCalculator
    {
        private IPromotionStrategyContext promotionsContext;

        public OrderValueCalculator()
        {
            promotionsContext = new PromotionStrategyContext();
        }
        public int Calculate(List<char> orderList)
        {
            int result = 0;
            if (orderList == null || orderList.Count() == 0)
                return result;

            var aggList = orderList.GroupBy(x => x).ToDictionary(k => k.Key, k => k.Count());

            foreach(var promotion in promotionsContext.Promotions)
            {
                result += promotion.Calculate(aggList);
            }

            // Calculate individual SKU values
            result += aggList
                .Join(SKU.SKUTypes, k => k.Key, s => s.Key, (k, s) => new { k, s })
                .Sum(x => x.k.Value * x.s.Value);

            return result;
        }
    }
}
