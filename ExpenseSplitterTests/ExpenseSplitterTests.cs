using System;
using Xunit;

namespace ExpenseSplitterTests
{
    public class ExpenseSplitterTests
    {
        [Fact]
        public void SplitAmountByNumberOfPeople_WhenTotalAmountIsZero_ReturnsZero()
        {
            // Arrange
            var expenseSplitter = new ExpenseSplitterLib.ExpenseSplitter();
            decimal totalAmount = 0;
            int numberOfPeople = 4; // Assuming there are 4 people

            // Act
            decimal splitAmount = expenseSplitter.SplitAmountByNumberOfPeople(totalAmount, numberOfPeople);

            // Assert
            Assert.Equal(0, splitAmount);
        }

        [Fact]
        public void SplitAmountByNumberOfPeople_WhenNumberOfPeopleIsZero_ThrowsArgumentException()
        {
            // Arrange
            var expenseSplitter = new ExpenseSplitterLib.ExpenseSplitter();
            decimal totalAmount = 100; // Assuming total amount is 100
            int numberOfPeople = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => expenseSplitter.SplitAmountByNumberOfPeople(totalAmount, numberOfPeople));
        }

        [Fact]
        public void SplitAmountByNumberOfPeople_ReturnsCorrectSplitAmount()
        {
            // Arrange
            var expenseSplitter = new ExpenseSplitterLib.ExpenseSplitter();
            decimal totalAmount = 100;
            int numberOfPeople = 5;

            // Act
            decimal splitAmount = expenseSplitter.SplitAmountByNumberOfPeople(totalAmount, numberOfPeople);

            // Assert
            Assert.Equal(20, splitAmount); // 100 / 5 = 20
        }

        // Add more test methods as needed
    }
}
