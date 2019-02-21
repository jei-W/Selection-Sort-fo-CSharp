using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class SelectionSort
    {
        public static void AscendingSort( int[] args )
        {
            for( int i = 0; i < args.Length; i++ )
            {
                int smallestIndex = i;

                for( int j = i + 1; j < args.Length; j++ )
                {
                    if( args[smallestIndex] > args[j] )
                    {
                        smallestIndex = j;
                    }
                }

                Swap(ref args[i], ref args[smallestIndex]);
            }
        }

        public static void DescendingSort( int[] args )
        {
            for( int i = 0; i < args.Length; i++ )
            {
                int biggestIndex = i;

                for( int j = i + 1; j < args.Length; j++ )
                {
                    if( args[biggestIndex] < args[j] )
                    {
                        biggestIndex = j;
                    }
                }

                Swap(ref args[i], ref args[biggestIndex]);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
