using Tyuiu.MorozovSM.Sprint1.Task7.V4.Lib;

namespace Tyuiu.MorozovSM.Sprint1.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = -0.511;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait,res);

        }
    }
}