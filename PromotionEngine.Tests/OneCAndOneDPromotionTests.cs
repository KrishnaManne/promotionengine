using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace PromotionEngine.Tests
{
    public class OneCAndOneDPromotionTests
    {
        [Fact]
        public void GivenMultipleCAndOneDThenPrmotionShouldBeApplied()
        {
            IPromotionStrategy strategy = new OneCAndOneDPromotion();
            var result = strategy.Calculate(new Dictionary<char, int> { { 'C', 3 },{'D' , 1 } });
            Assert.Equal(30, result);
        }

        [Fact]
        public void GivenTwoCAndTwoDThenPrmotionShouldBeAppliedTwoTimes()
        {
            IPromotionStrategy strategy = new OneCAndOneDPromotion();
            var result = strategy.Calculate(new Dictionary<char, int> { { 'C', 2 }, { 'D', 2 } });
            Assert.Equal(60, result);
        }

        [Fact]
        public void GivenEmptyListThenTwoBsPrmotionShouldReturnZero()
        {
            IPromotionStrategy strategy = new OneCAndOneDPromotion();
            var result = strategy.Calculate(new Dictionary<char, int>());
            Assert.Equal(0, result);
        }
    }
}
