// Do this first: Add references:
// - nunit.framework
// - StatDescriptive project

using NUnit.Framework;
using StatDescriptive;

namespace NunitStatDescriptive
{

    [TestFixture()]
    public class DescriptiveUnit
    {
        [SetUp]
        public void SetUp()
        {
            // nothing to setup, just a placeholder
        }
        [TearDown]
        public void TearDown()
        {
            // nothing to teardown, just a placeholder
        }


        [Test]
        public void Test_Descriptive()
        {
            double[] x = { 1, 5, 2, 7, 11 };

            Descriptive desp = new Descriptive(x);
            desp.Analyze(); // analyze the data
            Assert.AreEqual(5, desp.Result.Count, 0.00001, "count error!");
            Assert.AreEqual(1, desp.Result.Min, 0.00001, "min error!");
            Assert.AreEqual(11, desp.Result.Max, 0.00001, "max error!");
            Assert.AreEqual(10, desp.Result.Range, 0.00001, "range error!");
            Assert.AreEqual(26, desp.Result.Sum, 0.00001, "sum error!");
            Assert.AreEqual(5.2, desp.Result.Mean, 0.00001, "mean error!");
            Assert.AreEqual(3.778314848556, desp.Result.GeometricMean, 0.00001, "mean error!");
            Assert.AreEqual(2.5856279382135661, desp.Result.HarmonicMean, 0.00001, "mean error!");
            Assert.AreEqual(16.2, desp.Result.Variance, 0.00001, "var error!");
            Assert.AreEqual(4.02492, desp.Result.StdDev, 0.00001, "stdev error!");
            Assert.AreEqual(0.6011924877777, desp.Result.Skewness, 0.00001, "skewness error!");
            Assert.AreEqual(-0.57841792, desp.Result.Kurtosis, 0.00001, "kurtosis error!");

        }

        [Test]
        public void Test_Quartile()
        {
        double[] x  = {1, 2, 4, 7, 8, 9, 10, 12};
        Descriptive desp = new Descriptive(x);
desp.Analyze(); // analyze the data
Assert.AreEqual(3.5, desp.Result.FirstQuartile, 0.00001, "1st quartile error");
            Assert.AreEqual(7.5, desp.Result.Median, 0.00001, "2nd quartile error");
            Assert.AreEqual(9.25, desp.Result.ThirdQuartile, 0.00001, "3rd quartile error");
            Assert.AreEqual(5.75, desp.Result.IQR, 0.00001, "IQR quartile error");
        }

        [Test]
        public void Test_Percentile()
        {
            double[] x  = {1, 3, 2, 4};
            Descriptive desp = new Descriptive(x);
            desp.Analyze(); // analyze the data

            Assert.AreEqual(1.9, desp.Result.Percentile(30), 0.00001, "percentile error");
        }




    }


}