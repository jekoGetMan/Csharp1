using System;

namespace HomeTask1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers: ");

            var str = new string[5];
            var num = new double[str.Length];

            for (var indx = 0; indx < str.Length; indx++)
            {
                str[indx] = Console.ReadLine();
                try
                {
                    num[indx] = Convert.ToDouble(str[indx]) * 10;  // Без конвертации ругается
                }
                catch
                {
                    Console.WriteLine("We are working only with numbers");
                    indx--;
                }
            }

            foreach (var i in num)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
