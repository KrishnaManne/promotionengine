using System.Collections.Generic;
using Xunit;

namespace PromotionEngine.Tests
{
    public class ThreeAsPromotionTests
    {
        [Fact]
        public void GivenMoreThanThreeAsPrmotionShouldBeApplied()
        {
            IPromotionStrategy strategy = new ThreeAsPromotion();
            var result = strategy.Calculate(new Dictionary<char, int> { { 'A', 4 } });
            Assert.Equal(130, result);
        }

        [Fact]
        public void GivenLessThanThreeAsPrmotionShouldNotBeApplied()
        {
            IPromotionStrategy strategy = new ThreeAsPromotion();
            var result = strategy.Calculate(new Dictionary<char, int> { { 'A', 2 } });
            Assert.Equal(0, result);
        }

        [Fact]
        public void GivenSevenAsPrmotionShouldBeAppliedTwoTimes()
        {
            IPromotionStrategy strategy = new ThreeAsPromotion();
            var result = strategy.Calculate(new Dictionary<char, int> { { 'A', 7 } });
            Assert.Equal(260, result);
        }

        [Fact]
        public void GivenEmptyListThenThreeAsPrmotionShouldReturnZero()
        {
            IPromotionStrategy strategy = new ThreeAsPromotion();
            var result = strategy.Calculate(new Dictionary<char, int>());
            Assert.Equal(0, result);
        }
    }
}
