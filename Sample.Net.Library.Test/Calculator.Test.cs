using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sample.Net.Library.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public static void Add()
        {
            Assert.AreEqual(10.0, Calculator.Add(5, 5));
        }
    }
}
