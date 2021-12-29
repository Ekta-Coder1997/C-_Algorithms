using System;
namespace Binary_SearchAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program ob = new Program();
            
            int[] search_list = new int[] { 3, 1, 9, 8, 7, 12, 56, 23, 89 };

            int n, result;

            
            Console.WriteLine("Array Elements: ");
            foreach (int x in search_list) Console.Write(x + " ");
            Console.WriteLine();

           
            Array.Sort(search_list);
            Console.WriteLine("Sorted Array: ");
            foreach (int x in search_list) Console.Write(x + " ");
            Console.WriteLine();

            
            Console.WriteLine("Enter a value to search: ");
            n = Int32.Parse(Console.ReadLine());
            result = ob.search_value(search_list, n);
            if (result != -1)
                Console.WriteLine("The target value " + n + " is found at position " + (result+1));
            else
                Console.WriteLine("Target not found!");
        }
        int search_value(int[] arr, int target)
        {
            int low, high, mid;
            low = 0;
            high = arr.Length - 1;
            mid = (low + high) / 2;
            while(low<=high)
            {
                if (arr[mid] == target)
                    return mid + 1;
                else
                    if (target < arr[mid])
                        high = mid - 1;
                else
                    low = mid + 1;
                mid = (low + high) / 2;
            }
            return -1;
        }
    }
}