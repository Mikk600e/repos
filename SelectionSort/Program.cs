using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        List<int> lst0 = new List<int>(3);
        List<int> lst1 = new List<int>(5);
        static void Main(string[] args)
        {
            Program.SelectSort();
        }
        public void SelectSort()
        {
            lst0.Add(1);
            lst0.Add(2);
            lst0.Add(3);

            lst1.Add(8);
            lst1.Add(5);
            lst1.Add(-3);
            lst1.Add(6);
            lst1.Add(2);

            int mini_index;
            int temp_variable;
            for (int i = 0; i < lst0.Count - 1; i++)
            {
                mini_index = i;
                for (int j = i + 1; j < lst0.Count - 1; j++)
                {
                    if (lst0[j] < lst0[mini_index])
                        mini_index = j;
                }
                temp_variable = lst0[mini_index];
                lst0[mini_index] = lst0[i];
                lst0[i] = temp_variable;
            }
            for (int h = 0; h < lst0.Count; h++)
            {
                Console.WriteLine(lst0[h]);
            }
            Console.ReadKey();
        }
    }
}