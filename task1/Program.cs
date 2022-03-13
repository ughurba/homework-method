using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Bir method olsun iki parametr qəbul etsin,
            //və bu parametrlərdən birincini ikinciyə bölüb nəticəni geri qaytarsın.


            double result = 0;
            Console.WriteLine("birinci ededi qeyd eliyin");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("ikinci ededi qeyd eliyin");
            double num2 = double.Parse(Console.ReadLine());
            Compute(num, num2, result);
        }
        static double Compute(double num, double num2, double result)
        {

            Console.WriteLine("secim edin: + , -  , * , /");
            string str = Console.ReadLine();
            switch (str)
            {
                case "+":
                    result = num + num2;
                    break;
                case "-":
                    result = num - num2;
                    break;
                case "*":
                    result = num * num2;
                    break;
                case "/":
                    result = num / num2;
                    if (num2 == 0)
                    {
                        Console.WriteLine("SIFIRA BOLMEK OLMAZ!!!");
                    }
                    else
                    {
                        Console.WriteLine("= " + num / num2);
                    }

                    return result;
                    break;

                default:
                    Console.WriteLine("bele bir emeliyyat sistemi yoxdur");
                    break;
            }
            Console.WriteLine(result);
            return result;

        }
    }
}
