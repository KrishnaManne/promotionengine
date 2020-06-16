using System.Collections.Generic;

namespace PromotionEngine
{
    public interface IOrderValueCalculator
    {
        int Calculate(List<char> orderList);
    }
}
