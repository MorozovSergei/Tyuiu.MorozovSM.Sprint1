using Tyuiu.MorozovSM.Sprint1.Task6.V3.Lib;

namespace Tyuiu.MorozovSM.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "паи авпп осв ";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);
            string wait = "ипв";
            Assert.AreEqual(res, wait);
        }
    }
}