using System.ComponentModel.DataAnnotations;
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
            Console.WriteLine("what would you like " + name + " to do?");


            Tama tamagotchi = new Tama();
            tamagotchi.name = name;

            while (tamagotchi.GetAlive())
            {
                Console.WriteLine("Press 1 to feed " + name + ". Press 2 to teach " + name + " a word. Press 3 to let " + name + " speak. Press 4 to not do anyhting");
                ConsoleKey key = ConsoleKey.A;
                while (key != ConsoleKey.D1 && key != ConsoleKey.D2 && key != ConsoleKey.D3)
                {
                    key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1)
                    {
                        tamagotchi.Feed();
                        tamagotchi.PrintStats();
                    }
                    if (key == ConsoleKey.D2)
                    {
                        tamagotchi.Teach(Console.ReadLine());
                        tamagotchi.PrintStats();
                    }
                    if (key == ConsoleKey.D3)
                    {
                        tamagotchi.Hi();
                        tamagotchi.PrintStats();
                    }
                    if (key == ConsoleKey.D4)
                    {
                        tamagotchi.PrintStats();
                    }



                }
            }



            Console.ReadLine();

        }
    }
}

