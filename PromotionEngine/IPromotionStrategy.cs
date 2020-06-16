using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public interface IPromotionStrategy
    {
        int Calculate(Dictionary<char, int> orderList);
    }
}
