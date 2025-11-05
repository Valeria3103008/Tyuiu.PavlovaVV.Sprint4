using Tyuiu.PavlovaVV.Sprint4.Task0.V7.Lib;
namespace Tyuiu.PavlovaVV.Sprint4.Task0.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");


            int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };


            Console.WriteLine("Массив = { 9,8,7,9,5,4,3,2,3,7}");

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Произведение нечетных элементов массива = " + ds.GetMultOddArrEl(array));
            Console.ReadKey();
        }
    }
}

