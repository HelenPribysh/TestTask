using System;

namespace Pribysh_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 6, 9, 0, 7 };
            GetMultipleThreeNumbers(array);
        }

        static void GetMultipleThreeNumbers(int[] array)
        {
            try
            {
                string numbers = "";
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 3 == 0 && array[i] != 0)
                    {
                        numbers += array[i] + "\n" ;
                    }
                }

                if (string.IsNullOrEmpty(numbers))
                {
                    Console.WriteLine("Массив не содержит числа кратные трём");
                    return;
                }

                Console.WriteLine(numbers.Remove(numbers.Length - 1, 1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
           
    }
}
