using System;
namespace Random_String
{
    class Random
    {
        public static void Main()
        {
            string input = "ibe";
            string sub = input.Substring(0, 3);
            Console.WriteLine(sub);
            Console.ReadKey();
        }
    }
}