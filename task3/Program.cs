using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Bir method olsun göndərilən "n" sayda ədədin hamsını toplayıb geri qaytarsın.
            int sum = 0;
            Console.WriteLine("Massivlerin sayin qeyd edin");
            int array = Convert.ToInt32(Console.ReadLine());
            int [] myArray = new int[array];
            
            
            Arr(myArray , sum);

        }
        static int Arr(int [] myArray , int sum)
        {
            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(1,100);
                sum = sum + myArray[i];

            }

            Console.WriteLine(sum);
            return sum;
            
        }
    }
}
