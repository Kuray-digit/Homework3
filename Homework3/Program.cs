using System;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] mainString = { "Hello Kitty", "Something global", "Barbie doll" };
            int count = 0;
            foreach (string str in mainString)
            {
                if (str == "Hello Kitty" || str == "Barbie doll") count++;
            }
            Console.WriteLine(count);
        }
    }
}