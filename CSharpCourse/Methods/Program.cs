using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result= Add2(20,30);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            //Console.WriteLine(result);
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Multiply(2, 3,4));

            Console.WriteLine(Add4(2,3,4,5));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Add!!!");  // Metotlar bir işlemi birden defa kullanabiliyoruz.
        }
        static int Add2(int number1,int number2)
        {
            var result =number1 + number2; // int number2=30 default dğer ikinci değer verilmesze kullanılıyor ve en sona atanıyor.
            return result;
        }
        static int Add3(ref int number1,int number2) // out ref gibi kullanılıyor ama ilk değerini set etmemize gerek yok.
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3) //metotların overloadingi denilir: aşırı yüklenme
        {
            return number1 * number2*number3;
        }

        static int Add4(params int[] numbers) //paramsla aynı tipte istediğimiz kadar değer gönderebiliyoruz.Params son paramtereler olmak zorunda .
        {
            return numbers.Sum();
        }
       


    }
}
