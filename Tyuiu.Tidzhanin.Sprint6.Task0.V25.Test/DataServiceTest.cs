using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NargondoTI.Sprint6.Task0.V25.Lib;
using Tyuiu.NgargondoTI.Sprint6.Task1.V25.Lib;

namespace Tyuiu.NargondoTI.Sprint6.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(3);

            double wait = 3 / Math.Sqrt(3 * 3 + 3);
            wait = Math.Round(wait, 3);

            Assert.AreEqual(wait, result);
        }
    }
}