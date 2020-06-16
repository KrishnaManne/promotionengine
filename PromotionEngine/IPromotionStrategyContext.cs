using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public interface IPromotionStrategyContext
    {
        List<IPromotionStrategy> Promotions { get; }

    }
}
