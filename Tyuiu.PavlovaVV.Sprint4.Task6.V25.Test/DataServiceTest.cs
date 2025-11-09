using Tyuiu.PavlovaVV.Sprint4.Task6.V25.Lib;
namespace Tyuiu.PavlovaVV.Sprint4.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var ok = new string[] { "Òåííèñ", "Ôóòáîë", "Êðèêåò", "Áàñêåòáîë", "Áåéñáîë", "Ðåãáè", "Õîêêåé" };
            int res = ds.Calculate(ok);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
