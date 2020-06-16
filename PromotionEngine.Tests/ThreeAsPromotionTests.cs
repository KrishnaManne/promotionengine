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
        public void GivenEmptyListThenThreeAsPrmotionShouldReturnZero()
        {
            IPromotionStrategy strategy = new ThreeAsPromotion();
            var result = strategy.Calculate(new Dictionary<char, int>());
            Assert.Equal(0, result);
        }
    }
}
