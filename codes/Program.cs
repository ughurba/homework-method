using System;

namespace codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region method
            //Console.WriteLine(Sum(10,20));

            //string info = Info("lorem", "Ipsum", 25);
            //Console.WriteLine(info);

            //Print();

            //Console.WriteLine(Divide(5,3));

            //int result = SumMassiveElement(1,2,3,4,5,6,7,8);
            //Console.WriteLine(result);

            //Console.WriteLine(Subtract(10,4));

            #endregion

            Console.WriteLine(Sum(10, "okey"));

        }
        #region method
        /// <summary>
        /// ededleri toplayir 
        /// </summary>
        /// <param name="num1"> int num1 qebul edir </param>
        /// <param name="num2">int num2 qebul edir</param>
        /// <returns></returns>


        // static int Sum (int num1 , int num2)
        // {

        //     Console.WriteLine("sum methodu isledi");
        //     return num1 + num2;
        // }
        // static string Info(string name , string surname , int age)
        // {
        //     return $"{name} {surname} {age}";
        // }

        // static void Print()
        // {
        //     Console.WriteLine("void method ishledi");

        // }
        //static int Divide(int num1 , int num2)
        // {
        //     if (num1 > num2)
        //     {
        //         return num1;
        //     }else
        //     {
        //         return num2;
        //     }

        // }



        // static void Multiplay(int num)
        // {
        //     if (num > 5)
        //     {
        //         Console.WriteLine($"{num}");
        //         return;
        //     }
        //     Console.WriteLine("test");



        // }

        // static int SumMassiveElement(int num, int num2, params int[] arr)
        // {
        //     int sum = 0;
        //     foreach (var item in arr)
        //     {
        //         sum = sum + item;

        //     }
        //     return sum;


        // }

        // static int Subtract(int num1 , int num2)
        // {
        //     return num1 - num2;
        // }

        #endregion

        static int Sum(int num)
        {
            return 3;
        }
        static int Sum(double num, string word)
        {
            return 5;
        }
    }
}

