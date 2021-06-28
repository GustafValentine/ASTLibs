using System.Diagnostics;
using ASTLibs.Numbers;
using ASTLibs.Tests.Abstracts;
using Xunit;
using Xunit.Abstractions;

namespace ASTLibs.Tests.Numbers
{
    public class DecimalTests : BaseTest
    {
        public DecimalTests(ITestOutputHelper helper) : base(helper)
        {
        }

        [Fact]
        public void Test_PercentageDiff()
        {
            var stopwatch = Stopwatch.StartNew();
            var a = 100m;
            var b = a * 1.5m;
            Assert.Equal(40m, b.PercentageDifference(a));
            Debug.WriteLine(stopwatch.ElapsedTicks.ToString());
        }

        [Fact]
        public void Test_PercentageChange()
        {
            var stopwatch = Stopwatch.StartNew();
            var a = 100m;
            var b = a * 1.5m;
            Assert.Equal(50m, b.PercentageChange(a));
            Debug.WriteLine(stopwatch.ElapsedTicks.ToString());
        }

        [Fact]
        public void Test_PercentageRatio()
        {
            var stopwatch = Stopwatch.StartNew();
            var a = 100m;
            var b = a * 1.05m;
            var ratio = b.Ratio(a);
            Debug.WriteLine($"Ratio: {ratio}");
            Assert.Equal(5m, ratio);
            Debug.WriteLine(stopwatch.ElapsedTicks.ToString());
        }
    }
}