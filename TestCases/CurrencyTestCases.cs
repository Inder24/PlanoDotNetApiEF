using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PlanoCurrency.TestCases
{
    public class CurrencyTestCases
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1() => Assert.AreEqual(1, 1);
    }
}
