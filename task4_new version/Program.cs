using System;


namespace test
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //4) Sahe deyə Method(lar) yaradılır.

            // Çevrənin sahəsi - S = p*r² (p=3)
            // Düzbucaqlının sahəsi - S = a * b
            // Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S = p * r; p = (a + b + c) / 2

            Console.WriteLine(" A. Cevrenin sahesi\n B. Duzbucaqlinin sahesi \n C. Ucbucaqlinin daxiline ceklimis secvrenin sahesi");
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.A:

                    double p = 3;
                    Sahe(p);
                    break;

                case ConsoleKey.B:
                    Sahe(0, 0);
                    break;

                case ConsoleKey.C:
                    Sahe();
                    break;

            }
        }
        static void Sahe(double p)
        {
            double S;
            Console.WriteLine();
            Console.Write("\nRadiusu daxil edin:");
            double r = Convert.ToDouble(Console.ReadLine());
            r = r * r;
            S = p * r;
            Console.WriteLine($"Cevrenin sahesi --> {S}");

        }
        static void Sahe(double a, double b)
        {
            Console.WriteLine();
            Console.Write("\nDuzbucaqlinin sahesin bilmek ucun uzunluqun reqemle qeyd edin:");
            Console.WriteLine();
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Duzbucaqlinin sahesin bilmek ucun enin reqemle qeyd edin:");
            Console.WriteLine();
            b = Convert.ToInt32(Console.ReadLine());
            double S = b * a;
            Console.WriteLine($"Duzbucaqlinin sahesi --> {S}");
        }
        static void Sahe()
        {
            Console.WriteLine();
            Console.Write("\nXaiw edirik birinci ededi qeyd edin:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Xaiw edirik ikinci ededi qeyd edin:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Xaiw edirik ucuncu ededi qeyd edin:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("xaiw edirik radiusu qeyd edin:");
            double r = Convert.ToDouble(Console.ReadLine());
            double p = (a + b + c) / 2;
            double s = p * r;
            Console.WriteLine($"Ucbucaqlinin daxiline cekilmis cevrenin sahesi --> {s}");

        }

    }
}


