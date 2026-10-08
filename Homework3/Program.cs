using System;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] monthDays = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            string[] monthsNames = { "Январь", "Февраль", "Март", "Апрель",
                "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int usersNumber = int.Parse(Console.ReadLine() ?? "");
            if (usersNumber < 1 || usersNumber > 365)
                Console.WriteLine("Невалидный вид ввода");
                return;
            int currCount = 0;
            foreach (int day in monthDays)
            {
                if (usersNumber <= day) {
                    Console.WriteLine($"{usersNumber} {monthsNames[currCount]}");
                    break;
                }
                usersNumber -= day;
                currCount += 1;
            }
        }
    }
}