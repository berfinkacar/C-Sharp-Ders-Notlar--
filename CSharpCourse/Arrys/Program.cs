using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Ali";
            students[1] = "Elif";
            students[2] = "Can";

            string[] students2 = {"Ali", "Elif", "Can"};

            foreach (var student in students)
            {
                Console.WriteLine(student);

            }

            

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
