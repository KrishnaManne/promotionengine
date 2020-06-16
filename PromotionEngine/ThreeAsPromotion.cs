using System;
using System.Collections.Generic;
using System.Text;

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
