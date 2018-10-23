using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabble kendetegnes af navn, kan indeholde data, og den har en data type
            //med "," kan vi lave flere kan vi navngive flere variabler "str, str2"
            string str = "Dania", str2;
            int i = 123;
            // float kan indeholde decimal tal
            float tal = 123.56f;
            double sTal = 123.56;

            str = Console.ReadLine();

            i = Int32.Parse(str);
            sTal = double.Parse(str);

            Console.WriteLine("TEST");
            Console.WriteLine(str);

            i = calc(20, 80);
        }
        static int calc(int tal1, int tal2)
        {
            int sum = tal1 + tal2;
            return sum;
        }
    }
}
