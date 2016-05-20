using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HSFUniverse;
using Utilities;

namespace UniverseUnitTest
{
    [TestClass]
    public class CloudCoverUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sun mysun = new Sun();
            Matrix<double> esVec = new Matrix<double>();

            mysun.getEarSunVec(30.0);
        }
    }
}
