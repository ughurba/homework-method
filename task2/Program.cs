using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Repeat deyə bir method olsun və iki parametr qəbul etsin ,
            //biri "word" digəri "count" yəni bu şəkildə "Repeat(string word, int count)",
            //bu method göndərilən word-ü göndərilən count qədər yan-yana yazdırıb geri qaytarsın.
            //Məsələn: Repeat("Ha!") //Ha!
            //Repeat("Ha!", 2) //Ha!Ha!
            //Repeat("Ha!", 3) //Ha!Ha!Ha!
            Console.WriteLine("count-u qeyd edin");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("word-u qeyd edin");
            string word = Console.ReadLine();
            Repeat( word, count);

        }
        static string Repeat(string word , int count)
        {

            for (int i = 0; i < count; i++)
            {

                Console.Write(word);
            }
            
            return word;
        }
    }
}
