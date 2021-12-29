using System;
using System.Text;

namespace Reverse

{
    class Program
    {

        static String ReverseEachWord(String input) {
            if (string.IsNullOrEmpty(input)) {
                return input;
            }

            StringBuilder result = new StringBuilder();
            String[] arr = input.Split(" ");
            for (int i = 0; i < arr.Length; i++) {
                result.Append(Reverse(arr[i]));
                if (i != arr.Length - 1) {
                    result.Append(" ");
                }
            }

            return result.ToString();
        }

        static String Reverse(String input) {
            if (string.IsNullOrEmpty(input)) {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        static void Main(string[] args) {
            Console.WriteLine(ReverseEachWord("Hey! Ekta. Welcome To Bangalore"));
            Console.WriteLine(ReverseEachWord("Dreams don't work unless you do"));
            Console.WriteLine(ReverseEachWord("I got placed in Publicis Sapient. Happy Coding!"));
            Console.WriteLine(ReverseEachWord("what can I do today"));
            Console.WriteLine(ReverseEachWord(" "));
        }
    }
}