using System;
using System.Reflection;

namespace ASTLibs.Numbers
{
    public static class DecimalExtensions
    {
        private const decimal Percent = 100m;

        public static decimal PercentageChange(this decimal newValue, decimal oldValue)
        {
            return ((newValue - oldValue) / oldValue) * Percent;
        }

        public static decimal PercentageDifference(this decimal firstValue, decimal secondValue)
        {
            return (Math.Abs(firstValue - secondValue) / ((firstValue + secondValue) / 2.0m)) * Percent;
        }

        public static decimal PercentageError(this decimal exactValue, decimal approximateValue)
        {
            return (Math.Abs(approximateValue - exactValue) / Math.Abs(exactValue)) * Percent;
        }

        public static decimal Ratio(this decimal newValue, decimal oldValue, int digits = 2)
        {
            return decimal.Round(PercentageChange(newValue, oldValue), digits, MidpointRounding.AwayFromZero);
        }
    }
}