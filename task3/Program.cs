using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Bir method olsun göndərilən "n" sayda ədədin hamsını toplayıb geri qaytarsın.

            int sum = 0;
            Console.WriteLine("ededlerin sayin qeyd edin");
            int array = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[array];
            Arr(myArray, sum);
        }
        static int Arr(int[] myArray, int sum)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{i + 1}-ci ededi qeyd edin:");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + myArray[i];
            }
            Console.WriteLine($"ededlerin cemi --> {sum}");
            return sum;
        }

    }
}
