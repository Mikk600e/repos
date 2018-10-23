using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();
            #region List
            List<int> lst0 = new List<int>(3);
            List<int> lst1 = new List<int>(5);
            List<int> lst2 = new List<int>(4);
            List<int> lst3 = new List<int>(10);
            lst0.Add(1);
            lst0.Add(3);
            lst0.Add(2);
            lst1.Add(8);
            lst1.Add(5);
            lst1.Add(-3);
            lst1.Add(6);
            lst1.Add(2);
            lst2.Add(4);
            lst2.Add(3);
            lst2.Add(2);
            lst2.Add(1);
            lst3.Add(3);
            lst3.Add(4);
            lst3.Add(2);
            lst3.Add(1);
            lst3.Add(7);
            lst3.Add(5);
            lst3.Add(8);
            lst3.Add(9);
            lst3.Add(0);
            lst3.Add(9);
            #endregion
            #region SelectionSort
            Console.WriteLine("Selection Sort");
            prg.SelectionSort(lst0);
            prg.SelectionSort(lst1);
            prg.SelectionSort(lst2);
            prg.SelectionSort(lst3);
            Console.WriteLine("");
            #endregion
            #region BubbleSort
            Console.WriteLine("Bubble Sort");
            prg.BubbleSort(lst0);
            prg.BubbleSort(lst1);
            prg.BubbleSort(lst2);
            prg.BubbleSort(lst3);
            Console.WriteLine("");
#endregion 
        }
        public void SelectionSort(List<int> lst0)
        {
            int mini_index;
            int temp_variable;
            {
                for (int i = 0; i < lst0.Count - 1; i++)
                {
                    mini_index = i;
                    for (int j = i + 1; j < lst0.Count; j++)
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
            }
            Console.WriteLine("----------------------------");
            Console.ReadKey();
        }
        public void BubbleSort(List<int> lst0)
        {
            int temp_variable;
            for (int i = 0; i < lst0.Count - 1; i++)
            {
                for (int j = 0; j < lst0.Count - 1 - i; j++)
                {
                    if (lst0[j] > lst0[j + 1])
                    {
                        temp_variable = lst0[j + 1];
                        lst0[j + 1] = lst0[j];
                        lst0[j] = temp_variable;
                    }
                }
            }
            for (int h = 0; h < lst0.Count; h++)
            {
                Console.WriteLine(lst0[h]);
            }
        Console.WriteLine("--------------------------");
            Console.ReadKey();
        }
    }
}
