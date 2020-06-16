using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class OneCAndOneDPromotion : PromotionStrategyAbstractBase
    {
        public override int Calculate(Dictionary<char, int> orderList)
        {
            if (orderList == null || orderList.Count() == 0)
                return 0;

            int cCount = orderList.FirstOrDefault(y => y.Key == 'C').Value;
            int dCount = orderList.FirstOrDefault(y => y.Key == 'D').Value;
            int offer = cCount > 0 && dCount > 0 ? cCount & dCount : 0;
            int diff = cCount ^ dCount;

            if (cCount > dCount)
            {
                orderList['C'] = diff;
                orderList['D'] = 0;
            }
            else if (dCount > cCount)
            {
                orderList['D'] = diff;
                orderList['C'] = 0;
            }
            else
            {
                orderList['C'] = orderList['D'] = 0;
            }

            return offer * 30;
        }
    }
}
