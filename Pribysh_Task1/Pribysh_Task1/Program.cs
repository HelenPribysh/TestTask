using System;

namespace Pribysh_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            if (Convert.ToInt32(number) > 7)
            {
                Console.WriteLine("Привет");
            }

            else
            {
                Console.WriteLine("Число меньше или равно 7");
            }
        }
    }
}
