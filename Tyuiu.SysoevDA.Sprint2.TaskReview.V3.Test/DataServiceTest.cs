using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint2.TaskReview.V3.Lib;
namespace Tyuiu.SysoevDA.Sprint2.TaskReview.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}
