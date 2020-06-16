using System.Collections.Generic;

namespace PromotionEngine
{
    public class ThreeAsPromotion : PromotionStrategyAbstractBase
    {
        public override int Calculate(Dictionary<char, int> orderList)
        {
            return GroupOfSameSKUsPromotion(orderList, 'A', 3, 130);
        }
    }
}
