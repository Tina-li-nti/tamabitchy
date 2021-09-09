using System.Runtime.InteropServices.ComTypes;
using System;

namespace tamabitchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "tAMAbITCHY.tm";
            Console.WriteLine("Welcome to tamabitchy.TM(independent from Tamagotchi.TM)");
            Console.WriteLine("please name you pet....");
            string name = Console.ReadLine();
            Console.WriteLine("so " + name + " it is decied then.");
            Console.ReadLine();
        }
    }
}

