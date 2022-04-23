using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.Ints.Tests
{
    [TestClass()]
    public class P1_IsPrimeTests
    {
        [TestMethod()]
        [DataRow(-1, false)]
        [DataRow(0, false)]
        [DataRow(1, true)]
        [DataRow(2, true)]
        [DataRow(3, true)]
        [DataRow(4, false)]
        [DataRow(5, true)]
        [DataRow(6, false)]
        [DataRow(7, true)]
        [DataRow(25, false)]
        [DataRow(17, true)]
        public void IsPrimeTest(int n, bool expected)
        {
            Assert.AreEqual(expected, P1_IsPrime.IsPrime(n));
        }
    }
}