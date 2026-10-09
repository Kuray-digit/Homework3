using System;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] stringNumbers = (Console.ReadLine() ?? "").Split();
            int lastNumber = int.Parse(stringNumbers[0]);
            for (int i = 1; i < stringNumbers.Length; i++) 
            {
                if (lastNumber > int.Parse(stringNumbers[i]))
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}