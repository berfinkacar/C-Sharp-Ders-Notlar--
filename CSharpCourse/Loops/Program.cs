using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is prime number");
            }
            else
            {
                Console.WriteLine("This is not prime number");

            }

            //for loop
            //for (int i = 1; i < 100; i+=2)
            //{
            //    Console.WriteLine(i);

            //}
            //for (int i = 100; i >0 ; i -= 2)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("Finished!");
            //Console.ReadLine();


            //while loop
            //int number = 100;
            //while (number>=0)
            //{
            //    Console.WriteLine(number);
            //    number--;

            //}

            //do while
            //int number = 10;
            //do
            //{
            //    Console.WriteLine(number);   
            //    number--;
            //} while (number > 0);
            //Console.ReadLine();


            //forach döngü:dizi temelli

            //string[] students = new string[3] { "Ali", "Veli", "Can" };
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.ReadLine();

            //Örnek

            Console.ReadLine();

        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
    
    