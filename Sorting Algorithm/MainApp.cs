using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main( string[] args )
        {
            int[] arg = { 2, 8, 5, 9, 1, 13, 7 };

            Print();

            SelectionSort.AscendingSort(arg);
            Print();

            SelectionSort.DescendingSort(arg);
            Print();


            void Print()
            {
                foreach( int i in arg )
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
