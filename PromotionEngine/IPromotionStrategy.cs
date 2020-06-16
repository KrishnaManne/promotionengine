using System.Collections.Generic;

namespace PromotionEngine
{
    public interface IPromotionStrategy
    {
        int Calculate(Dictionary<char, int> orderList);
    }
}
