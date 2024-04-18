using Xunit;
using System.Collections.Generic;

namespace ExpenseSplitterTests
{
    public class ExpenseSplitterTests
    {
        // Existing test methods...

        [Fact]
        public void CalculateTipPerPerson_ReturnsCorrectTipAmounts()
        {
            // Arrange
            var expenseSplitter = new ExpenseSplitterLib.ExpenseSplitter();
            var mealCosts = new Dictionary<string, decimal>
            {
                {"Alice", 50},
                {"Bob", 60},
                {"Charlie", 40}
            };
            float tipPercentage = 0.15f; // 15%

            // Act
            var tipAmounts = expenseSplitter.CalculateTipPerPerson(mealCosts, tipPercentage);

            // Assert
            Assert.Equal(7.5m, tipAmounts["Alice"]);   // 50 * 0.15 = 7.5
            Assert.Equal(9m, tipAmounts["Bob"]);       // 60 * 0.15 = 9
            Assert.Equal(6m, tipAmounts["Charlie"]);   // 40 * 0.15 = 6
        }
    }
}
