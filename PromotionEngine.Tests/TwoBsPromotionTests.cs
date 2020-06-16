using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PromotionEngine.Tests
{
    public class TwoBsPromotionTests
    {
        [Fact]
        public void GivenMoreThanTwoBsPrmotionShouldBeApplied()
        {
            IPromotionStrategy strategy = new TwoBsPromotion();
            var result = strategy.Calculate(new Dictionary<char, int> { { 'B', 3 } });
            Assert.Equal(45, result);
        }

        [Fact]
        public void GivenEmptyListThenTwoBsPrmotionShouldReturnZero()
        {
            IPromotionStrategy strategy = new TwoBsPromotion();
            var result = strategy.Calculate(new Dictionary<char, int>());
            Assert.Equal(0, result);
        }
    }
}
