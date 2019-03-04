using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
        {
        static void Main(string[] args)
        {   
            Console.WriteLine("Please enter 5 numbers: ");

            var str = new string[5];
            var num = new double[str.Length]; 

            for (var i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
                num[i] = Convert.ToDouble(str[i]) * 10;    
            }

            Console.WriteLine("Waaaaaaait...");


            foreach (var i in num)
            {

                Console.Write(i + " ");

            }
            Console.ReadLine();
        }
    }
}
