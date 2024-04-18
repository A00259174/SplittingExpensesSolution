using System;

namespace ExpenseSplitterLib
{
    public class ExpenseSplitter
    {
        public decimal SplitAmountByNumberOfPeople(decimal totalAmount, int numberOfPeople)
        {
            if (numberOfPeople <= 0)
            {
                throw new ArgumentException("Number of people must be greater than zero.", nameof(numberOfPeople));
            }

            return totalAmount / numberOfPeople;
        }
    }


}
