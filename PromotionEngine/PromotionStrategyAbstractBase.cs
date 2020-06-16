using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public abstract class PromotionStrategyAbstractBase : IPromotionStrategy
    {
        public abstract int Calculate(Dictionary<char, int> orderList);

        protected int GroupOfSameSKUsPromotion(Dictionary<char, int> orderList, char skuType, int groupSize, int offerValue)
        {
            if (orderList == null || orderList.Count == 0)
                return 0;

            var itemCount = orderList.FirstOrDefault(x => x.Key == skuType).Value;
            int newItemCount = itemCount % groupSize;
            orderList[skuType] = newItemCount;
            return (itemCount / groupSize) * offerValue;
        }
    }
}
