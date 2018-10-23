using System;
using System.Collections.Generic;

namespace anonomousDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public class BubbleSorter
        {
            public void Sort<T>(IList<T> listToSort) where T : IComparable<T>
            {
                bool swapped;
                do
                {
                    swapped = false;
                    for (int i = 0; i < listToSort.Count - 1; i++)
                    {
                        if (listToSort[i].CompareTo(listToSort[i + 1]) > 0)
                        {   
                            var temp = listToSort[i];
                            listToSort[i] = listToSort[i + 1];
                            listToSort[i + 1] = temp;
                            swapped = true;
                        }
                    }

                } while (swapped);
            }

            private int Compare(Item lhs, Item rhs)
            {
                return lhs.Name.CompareTo(rhs.Name);
            }
        }

        public class Item : IComparable<Item>
        {
            public string Name { get; set; }
            public int CompareTo(Item other)
            {
                return Name.CompareTo(other.Name);
            }
        }
    }
}
