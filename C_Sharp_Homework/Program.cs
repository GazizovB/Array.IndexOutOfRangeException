using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Homework
{

    class Program
    {
        private static int counter = 0;

        static void Main(string[] args)
        {
            try
            {
                int[] numbers = new int[5];

                for (int i = 0; i <= numbers.Length; i++)
                {
                    numbers[i] = counter++;
                    Console.WriteLine(numbers[i]);
                }
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }


            Console.ReadLine();

        }
    }
}


