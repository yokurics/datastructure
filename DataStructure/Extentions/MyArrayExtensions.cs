using DataStructure.Models;

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

        public static void RecursiveBubbleSort(this int[] items, int number)
        {
            if (number > 1)
            {
                for (var i = 0; i < items.Length - 1; i++)
                {
                    if (items[i] > items[i + 1])
                    {
                        items.Swap(i, i + 1);
                    }
                }

                RecursiveBubbleSort(items, number - 1);
            }
        }

        public static void IterativeBubbleSort(this int[] items)
        {
            for (var i = 0; i < items.Length - 1; i++)
            {
                for (var j = 0; j < items.Length - 1; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                        items.Swap(j, j + 1);
                    }
                }
            }
        }

        public static void RecursiveQuickSort(this int[] items, int start, int end)
        {
            if (start < end)
            {
                var pivot = items[start]; // TODO: change to get medium value
                var left = start;
                var right = end;

                while (true)
                {
                    while (items[left] < pivot)
                    {
                        left++;
                    }

                    while (items[right] > pivot)
                    {
                        right--;
                    }

                    if (left >= right)
                    {
                        break;
                    }

                    items.Swap(left, right);
                }

                RecursiveQuickSort(items, start, left - 1);
                RecursiveQuickSort(items, right + 1, end);
            }
        }

        public static void IterativeQuickSort(this int[] items, int start, int end)
        {
            var stack = new MyStack<int>();
            stack.Push(start);
            stack.Push(end);

            while (stack.Count > 0)
            {
                end = stack.Pop();
                start = stack.Pop();

                while (true)
                {
                    if (start >= end)
                    {
                        break;
                    }

                    var pivot = items[start]; // TODO: change to get medium value
                    var left = start;
                    var right = end;

                    while (true)
                    {
                        while (items[left] < pivot)
                        {
                            left++;
                        }

                        while (items[right] > pivot)
                        {
                            right--;
                        }

                        if (left >= right)
                        {
                            break;
                        }

                        items.Swap(left, right);
                    }

                    if (left - start < end - right)
                    {
                        stack.Push(right + 1);
                        stack.Push(end);
                        end = left - 1;
                    }
                    else
                    {
                        stack.Push(start);
                        stack.Push(left - 1);
                        start = right + 1;
                    }
                }
            }
        }

        public static void Swap(this int[] items, int a, int b)
        {
            var temp = items[b];
            items[b] = items[a];
            items[a] = temp;
        }
    }
}
