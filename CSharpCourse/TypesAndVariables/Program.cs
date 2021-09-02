using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!"); Comment line
        
            decimal number6 = 10.4m;
            double number5 = 10.4;                   //Ondalıklı sayıları tutar 64 bittir.
            char character = 'A';                   //karakter için kullanılır.
            bool condition = true;                 // true ya da false değerlerini tutar.
            byte number4 = 123;                   // 8 bitlik yer kaplar.
            short number3 = 12556;               //16 bitlik yer kaplar.
            int number1 =214785666;             //32 bit yer kaplar.
            long number2 = 255556666666666;    // 64 bit yer kaplar.
            var number7 = 10;
            number7 = 'A';
            
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is :{0}",character);
            Console.WriteLine("Character is :{0}", (int)character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
