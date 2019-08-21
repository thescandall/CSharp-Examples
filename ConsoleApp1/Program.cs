using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Given an array of integers, write a method to total the odd numbers

            //int i = 0;
            ////declaring array of integers
            //int[] arr = new int[5];

            ////reading the elements
            //Console.WriteLine("Enter array elements : ");
            //for (i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Element[" + (i + 1) + "]: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            ////checking and printing all odd numbers
            //Console.WriteLine("List of odd  numbers : ");
            //for (i = 0; i < arr.Length; i++)
            //{
            //    //condition to check ODD number
            //    if (arr[i] % 2 != 0)
            //        Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers

            //int i = 0;
            ////declaring array of integers
            //int[] arr = new int[5];

            ////reading the elements
            //Console.WriteLine("Enter 5 numbers : ");
            //for (i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Number[" + (i + 1) + "]: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = arr.Sum();

            //Console.WriteLine("The total sum of the array is: {0}", sum);
            //Console.ReadLine();

            //Given a string, reverse it.

            //Console.WriteLine("Please enter your name");
            //string s = Console.ReadLine();

            //Console.WriteLine("Your name backwards is " + StringHelper.ReverseString(s));
            //Console.ReadLine();

            //Given a string, remove any repeated letters.

            string alphabet = "aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyyzz";

            Console.WriteLine(StringHelper.RemoveDuplicates(alphabet));

            //FizzBuzz
            for (int i = 0; i < 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();

        }


        public static class StringHelper
        {
            /// <summary>
            /// Receives string and returns the string with its letters reversed.
            /// </summary>
            public static string ReverseString(string s)
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }

            public static string RemoveDuplicates(string d)
            {
                char[] arr = d.ToCharArray().Distinct().ToArray();
                return new string(arr);
            }
        }

       



    }
 }
   