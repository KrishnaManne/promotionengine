using System.Collections.Generic;

namespace PromotionEngine
{
    public class TwoBsPromotion : PromotionStrategyAbstractBase
    {
        public override int Calculate(Dictionary<char, int> orderList)
        {
            return GroupOfSameSKUsPromotion(orderList, 'B', 2, 45);
        }
    }
}
