using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace UtilitiesUnitTest
{
    [TestClass]
    public class TraceUnitTest
    {
        [TestMethod]
        public void TestTrace()
        {
            double[,] elements = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            Matrix<double> A = new Matrix<double>(elements);
            int result = 34;

            Assert.AreEqual(result, Matrix<double>.Trace(A));
        }
    }
}
