using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public interface IOrderValueCalculator
    {
        int Calculate(List<char> orderList);
    }
}
