using System;
namespace Rotate
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int position = 0, k = 0;
            Console.Write("Original Array :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Enter position of rotation : ");
            position = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            while (k < position)
            {
                obj.LeftRotate(arr);
                k++;
            }
            Console.WriteLine("Rotation of array by position " + position);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
        void LeftRotate(int[] arr)
        {
            int x = arr[0];
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[(arr.Length - 1)] = x;
        }
    }
}