using System.Collections.Generic;

namespace PromotionEngine
{
    public class PromotionStrategyContext : IPromotionStrategyContext
    {
        public PromotionStrategyContext()
        {
            Promotions = new List<IPromotionStrategy>();
            Promotions.Add(new ThreeAsPromotion());
            Promotions.Add(new TwoBsPromotion());
            Promotions.Add(new OneCAndOneDPromotion());
        }

        public List<IPromotionStrategy> Promotions { get; private set; }
    }
}
