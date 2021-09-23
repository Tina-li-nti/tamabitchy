using System.Collections.Generic;
using System;

namespace tamabitchy
{
    public class Tama
    {
        private int hunger;
        private int boredom;
        private List<string> words = new List<string>();
        private bool isAlive = true;
        private Random generator = new Random();
        public string name;

        public void Feed()
        {
            hunger--;
        }
        public void Hi()
        {
            int i = generator.Next(words.Count);
            Console.WriteLine(words[i]);
            ReduceBoredome();
        }
        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredome();
        }
        public void Tick()
        {
            hunger++;
            boredom++;
            if (hunger > 11)
            {
                isAlive = false;
            }
            if (boredom > 11)
            {
                isAlive = false;
            }
        }
        public void PrintStats()
        {
            Tick();
            if (isAlive == true)
            {
                Console.WriteLine($"tamabithcy current stats: {hunger}hunger   {boredom}boredom");
            }
            else
            {
                Console.WriteLine("DEAD");
            }

        }
        public bool GetAlive()
        {
            return isAlive;
        }
        private void ReduceBoredome()
        {
            boredom--;
            if (boredom < 0)
            {
                boredom = 0;
            }
        }
    }


}