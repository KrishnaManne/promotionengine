using System;
using System.Collections.Generic;
using System.Text;

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
