using Tyuiu.PavlovaVV.Sprint4.Task0.V7.Lib;
namespace Tyuiu.PavlovaVV.Sprint4.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int res = ds.GetMultOddArrEl(array);
            int result = 178605;
            Assert.AreEqual(result, res);
        }
    }
}
