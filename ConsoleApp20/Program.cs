using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length - 1);
            char wallah =chars[num];
            string input = "ibe";
            input = input + wallah;
            string sub = input.Substring(0, 3);
            Console.WriteLine(sub);
            Console.ReadKey();
        }
    }
}
