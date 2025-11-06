using Tyuiu.PavlovaVV.Sprint4.Task2.V27.Lib;
namespace Tyuiu.PavlovaVV.Sprint4.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(2, 7);

            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            int res = ds.Calculate(numsArray);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
