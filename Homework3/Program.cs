using System;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число карьы");
                string input = Console.ReadLine() ?? "";
                int k = int.Parse(input);
                if (k < 6 ||  k > 24)
                {
                    throw new ArgumentOutOfRangeException("k", "Число должно быть между 6 и 14.");
                }
                string cardName = "";
                switch (k)
                {
                    case 6: cardName = "Шестёрка"; break;
                    case 7: cardName = "Северка"; break;
                    case 8: cardName = "Восьмёрка"; break;
                    case 9: cardName = "Девятка"; break;
                    case 10: cardName = "Десятка"; break;
                    case 11: cardName = "Валет"; break;
                    case 12: cardName = "Дама"; break;
                    case 13: cardName = "Король"; break;
                    case 14: cardName = "Туз"; break;
                }
                Console.WriteLine($"Карта: {cardName}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите валидное целочисленное число");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа закончена");
            }
        }
    }
}