using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            String tempTxt;
            double tempTal;
            Console.Write("Indtast udendørs temperatur: ");
            tempTxt = Console.ReadLine();
            tempTal = double.Parse(tempTxt);
            if (tempTal >= 20)
            {
                Console.Clear();
                Console.WriteLine("Syd for danmark");
            }
            else if (tempTal >=1)
            {
                Console.Clear();
                Console.WriteLine("Danmark");
            }
            else if (tempTal <=0)
            {
                Console.Clear();
                Console.WriteLine("Grøndland");
            }
            Console.ReadLine();
        }
    }
}
