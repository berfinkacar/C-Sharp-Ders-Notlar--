using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string city = "Ankara";
              Console.WriteLine(city);

              foreach (var item in city)
              {
                  Console.WriteLine(item);
              }
              string city2 = "İzmir";
              //string result = city + city2;

              //Console.WriteLine(result);
              Console.WriteLine(String.Format("{0} {1}", city, city2));

              */

            string sentence = "My name is Maya";

            var result = sentence.Length;    //uzunluk
            Console.WriteLine(result);

            bool result2 = sentence.EndsWith("a");
            Console.WriteLine(result2);

            bool result3 = sentence.StartsWith("M");
            Console.WriteLine(result3);

            var result4 = sentence.IndexOf("name");
            Console.WriteLine(result4);

            var result5 = sentence.IndexOf(" ");
            Console.WriteLine(result5);

            var result6 = sentence.LastIndexOf(" ");
            Console.WriteLine(result6);

            var result7 = sentence.Insert(0, "Hello, "); //ekleme 
            Console.WriteLine(result7);

            var result8 = sentence.Substring(3);   //parçalama
            Console.WriteLine(result8);

            var result9 = sentence.Substring(3, 4);
            Console.WriteLine(result9);

            var result10 = sentence.ToLower();   //küçük harfe çevirme
            Console.WriteLine(result10);

            var result11 = sentence.ToUpper(); //büyük harfe çevirme
            Console.WriteLine(result11);

            var result12 = sentence.Replace(" ", "-");
            Console.WriteLine(result12);

            var result13 = sentence.Remove(3);
            Console.WriteLine(result13);

            Console.ReadLine();
        }
    }
}
