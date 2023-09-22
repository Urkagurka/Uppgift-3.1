using System;

namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 50)
            {
                Console.WriteLine("du får delta");
            }
            if (ålder <= 50)
            {
                Console.WriteLine("du får inte delta");
            }

        }


    }




}