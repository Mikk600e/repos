using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Løkker
{
    class Program
    {
        static void Main(string[] args)
        {
            //int NumberLoop;
            //string str = Console.ReadLine();
            //NumberLoop = Int32.Parse(str);
            //int counter = 0;
            //do
            ////{
            //    counter++;
            //    Console.WriteLine("Hello {0}", counter);
            //} while (counter < NumberLoop);           
            //counter = 0;
            //while (counter < NumberLoop)
            //{                
            //    counter++;
            //    Console.WriteLine("Hello {0}", counter);
            //}
            //for (int i = 0; i < NumberLoop; i++)
            //{
            //    Console.WriteLine("Hello {0}", i);
            //}
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write("{0:000} ", i*j);
                }
                Console.WriteLine();               
            }
            Console.ReadLine();
        }
    }
}
