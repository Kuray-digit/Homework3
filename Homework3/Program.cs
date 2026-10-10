using System;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            string mainString = (Console.ReadLine() ?? "").ToLower();
            switch (mainString)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequilla");
                    break;
                case "school counselor":
                    Console.WriteLine("Anithing with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "Rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
        }
    }
}