using System.Collections.Generic;
using Xunit;
namespace PromotionEngine.Tests
{
    public class OneCAndOneDPromotionTests
    {
        [Fact]
        public void GivenMultipleCAndOneDThenPrmotionShouldBeApplied()
        {
            IPromotionStrategy strategy = new OneCAndOneDPromotion();
            var result = strategy.Calculate(new Dictionary<char, int> { { 'C', 3 }, { 'D', 1 } });
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
        public void GivenOneCAndZeroDThenPrmotionShouldNotBeApplied()
        {
            IPromotionStrategy strategy = new OneCAndOneDPromotion();
            var result = strategy.Calculate(new Dictionary<char, int> { { 'C', 1 }, { 'D', 0 } });
            Assert.Equal(0, result);
        }

        [Fact]
        public void GivenEmptyListThenPrmotionShouldReturnZero()
        {
            IPromotionStrategy strategy = new OneCAndOneDPromotion();
            var result = strategy.Calculate(new Dictionary<char, int>());
            Assert.Equal(0, result);
        }
    }
}
