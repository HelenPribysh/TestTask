using System;

namespace Pribysh_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите Имя:");
                string name = Console.ReadLine();
                if (string.Equals(name.ToLower(), "вячеслав"))
                {
                    Console.WriteLine("Привет, Вячеслав");
                }

                else
                {
                    Console.WriteLine("Нет такого имени");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
