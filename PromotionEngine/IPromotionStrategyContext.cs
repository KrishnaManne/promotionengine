using System.Collections.Generic;

namespace PromotionEngine
{
    public interface IPromotionStrategyContext
    {
        List<IPromotionStrategy> Promotions { get; }

    }
}
