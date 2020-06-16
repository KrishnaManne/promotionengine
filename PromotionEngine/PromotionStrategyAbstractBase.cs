﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{
    public abstract class PromotionStrategyAbstractBase : IPromotionStrategy
    {
        public abstract int Calculate(Dictionary<char, int> orderList);

        protected int GroupOfSameSKUsPromotion(Dictionary<char, int> orderList, char key, int groupSize, int offerValue)
        {
            var itemCount = orderList.FirstOrDefault(x => x.Key == key).Value;
            int newItemCount = itemCount % groupSize;
            orderList[key] = newItemCount;
            return (itemCount / groupSize) * offerValue;            
        }
    }
}
