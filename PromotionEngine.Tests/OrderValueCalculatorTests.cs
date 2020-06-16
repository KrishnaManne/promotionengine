using System.Collections.Generic;
using Xunit;

namespace PromotionEngine.Tests
{
    public class OrderValueCalculatorTests
    {
        private IOrderValueCalculator orderValueCalculator;
        public OrderValueCalculatorTests()
        {
            orderValueCalculator = new OrderValueCalculator();
        }

        [Fact]
        public void ScenarioA()
        {
            var testList = new List<char>() { 'A', 'B', 'C' };
            var result = orderValueCalculator.Calculate(testList);
            Assert.Equal(100, result);
        }

        [Fact]
        public void ScenarioB()
        {
            var testList = new List<char>() { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C' };
            var result = orderValueCalculator.Calculate(testList);
            Assert.Equal(370, result);
        }

        [Fact]
        public void ScenarioC()
        {
            var testList = new List<char>() { 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'D' };
            var result = orderValueCalculator.Calculate(testList);
            Assert.Equal(280, result);
        }

        [Fact]
        public void GivenOnlyDsThenAppropriateResultShouldBeShown()
        {
            var testList = new List<char>() { 'D', 'D' };
            var result = orderValueCalculator.Calculate(testList);
            Assert.Equal(30, result);
        }

        [Fact]
        public void GivenEmptyListThenAppropriateResultShouldBeShown()
        {
            var testList = new List<char>();
            var result = orderValueCalculator.Calculate(testList);
            Assert.Equal(0, result);
        }

        [Fact]
        public void GivenNullThenAppropriateResultShouldBeShown()
        {            
            var result = orderValueCalculator.Calculate(null);
            Assert.Equal(0, result);
        }
    }
}
