using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Sahe deyə Method(lar) yaradılır.

            // Çevrənin sahəsi - S = p*r² (p=3)
            // Düzbucaqlının sahəsi - S = a * b
            // Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S = p * r; p = (a + b + c) / 2
            double s = 0;
            double r = 0;
            double p = 3;
            Console.WriteLine("Xaiw edirik secim edin");
            Console.WriteLine();
            Console.WriteLine(" A. Cevrenin sahesi\n B. Duzbucaqlinin sahesi \n C. Ucbucaqlinin daxiline ceklimis secvrenin sahesi");
            string str = Console.ReadLine();
            str = str.ToUpper();
            Sahe(p, str);
            Sahe(str);
            Sahe(str, s, r);
        }
        static void Sahe(double p, string str)
        {
            switch (str)
            {
                case "A":

                    double S;
                    Console.Write("Radiusu daxil edin:");
                    double r = Convert.ToDouble(Console.ReadLine());
                    r = r * r;
                    S = p * r;
                    Console.WriteLine($"Cevrenin sahesi --> {S}");

                    break;
            }
        }
        static void Sahe(string str)
        {
            switch (str)
            {
                case "B":
                    double a, b;
                    Console.Write("Duzbucaqlinin sahesin bilmek ucun uzunluqun reqemle qeyd edin:");
                    Console.WriteLine();
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Duzbucaqlinin sahesin bilmek ucun enin reqemle qeyd edin:");
                    Console.WriteLine();
                    b = Convert.ToInt32(Console.ReadLine());
                    double S = b * a;
                    Console.WriteLine($"Duzbucaqlinin sahesi --> {S}");
                    break;
            }
        }
        static void Sahe(string str, double s, double r)
        {
            switch (str)
            {

                case "C":
                    Console.Write("Xaiw edirik birinci ededi qeyd edin:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Xaiw edirik ikinci ededi qeyd edin:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Xaiw edirik ucuncu ededi qeyd edin:");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.Write("xaiw edirik radiusu qeyd edin:");
                    r = Convert.ToDouble(Console.ReadLine());
                    double p = (a + b + c) / 2;
                    s = p * r;
                    Console.WriteLine($"Ucbucaqlinin daxiline cekilmis cevrenin sahesi --> {s}");
                    break;

            }
        }
    }

}

