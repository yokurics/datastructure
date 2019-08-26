using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Extentions
{
    public static class MyArrayExtensions
    {

        public static int IterativeBinarySearch(this int[] items, int value, int start, int end)
        {
            while (start <= end)
            {
                var index = (start + end) / 2;

                if (items[index] == value)
                {
                    return index;
                }
                else if (items[index] > value)
                {
                    end = index - 1;
                }
                else if (items[index] < value)
                {
                    start = index + 1;
                }
            }

            return -1;
        }

        public static int RecursiveBinarySearch(this int[] items, int value, int start, int end)
        {
            if (start <= end)
            {
                var index = (start + end) / 2;

                if (items[index] == value)
                {
                    return index;
                }
                else if (items[index] > value)
                {
                    return RecursiveBinarySearch(items, value, start, end - 1);
                }
                else if (items[index] < value)
                {
                    return RecursiveBinarySearch(items, value, start + 1, end);
                }
            }

            return -1;
        }
    }
}
