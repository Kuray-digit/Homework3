using System;

namespace Exercise
{
    class Program
    {
        enum DaysOfWeek
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        public static void Main(string[] args)
        {
            int indexDay = int.Parse(Console.ReadLine() ?? "") - 1;
            Console.WriteLine((DaysOfWeek)indexDay);
        }
    }
}