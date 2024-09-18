using Tyuiu.MorozovSM.Sprint1.Task2.V14.Lib;

namespace Tyuiu.MorozovSM.Sprint1.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertKelvinToCelsius(x);
            Assert.AreEqual(-272, res);
        }
    }
}