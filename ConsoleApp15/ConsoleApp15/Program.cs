using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string usrInputStr;
            int usrInputInt;
            Console.WriteLine("Indtast tal: ");
            usrInputStr = Console.ReadLine();
            usrInputInt = Int32.Parse(usrInputStr);
            MakeBit(usrInputInt);
        }
        static void MakeBit(int number)
        {
            int remainder=0;
            while (number != 0)
            {
                remainder = number % 2;
                number = number / 2;
                Console.Write(remainder);
            }
            Console.ReadKey();
        }
    }
}
