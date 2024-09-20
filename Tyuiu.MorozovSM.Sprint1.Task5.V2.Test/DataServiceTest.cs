using Tyuiu.MorozovSM.Sprint1.Task5.V2.Lib;

namespace Tyuiu.MorozovSM.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double temp = 32;
            int res = ds.FahrenheitTo—elsius(temp);
            int wait = 0;
            Assert.AreEqual(res, wait);
        }
    }
}