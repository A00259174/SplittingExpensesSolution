﻿using System;
using System.Collections.Generic;

namespace ExpenseSplitterLib
{
    public class ExpenseSplitter
    {
        // Existing methods...

        public Dictionary<string, decimal> CalculateTipPerPerson(Dictionary<string, decimal> mealCosts, float tipPercentage)
        {
            if (mealCosts == null)
            {
                throw new ArgumentNullException(nameof(mealCosts));
            }

            if (tipPercentage < 0 || tipPercentage > 1)
            {
                throw new ArgumentException("Tip percentage must be between 0 and 1.", nameof(tipPercentage));
            }

            var tipPerPerson = new Dictionary<string, decimal>();

            foreach (var kvp in mealCosts)
            {
                decimal tipAmount = kvp.Value * (decimal)tipPercentage;
                tipPerPerson[kvp.Key] = tipAmount;
            }

            return tipPerPerson;
        }
    }
}
