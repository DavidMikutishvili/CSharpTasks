using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal class ArrayTasks
    {
        // Task 1
        // Write Fibonacci numbers to an array

        public void FibonacciNumbers()
        {
            Console.Write("Enter the number of array lenght ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];
            int a = 0; 
            int b = 1;
            int c = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count++;
                if (count == 1)
                {
                    array[i] = a;
                }
                if (count == 2)
                {
                    array[i] = b;
                }
                if (count > 2)
                {
                    a = b;
                    b = c + b;
                    c = a;
                    array[i] = b;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }

        // Task 2
        // Find in the array numbers whose value is less than the arithmetic average of all elements of the array

        public void NumbersLessThanTheArithmeticMean()
        {
            int[] array = { 2, 5, 2, 1, 8, -5, 6, 3, -3, 1, 4 };

            int sum = 0;
            int count = 0;
            int average = 0;

            for (int i = 0; i < array.Length; i++)
            {
                count++;
                sum += array[i];
            }
            average = sum / array.Length;

            Console.WriteLine($"Sum {sum}");
            Console.WriteLine($"The number of array elements {count}");
            Console.WriteLine($"Average {average}");
            Console.WriteLine("Numbers less than the arithmetic mean: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (average > array[i])
                {
                    Console.Write("{0}, ", array[i]);
                }
            }
        }

        // Task 3

        public void Palindrome()
        {
            Console.WriteLine("Enter an even number of characters, for example: 125521 or anna");
            string palindrome = Console.ReadLine(); 
            char[] array = palindrome.ToCharArray(); 

            char[] firstHalfLine = new char[array.Length / 2]; 
            char[] secondHalfLine = new char[array.Length / 2];
            int buf = array.Length / 2 - 1;

            for (int i = buf; i >= 0; i--)
            {
                secondHalfLine[buf - i] = array[i]; 
                firstHalfLine[i] = array[i];  
            }
            string rirstHalfPalindrome = new string(firstHalfLine); 
            string secondHalfPalindromeReverse = new string(secondHalfLine); 

            if ($"{rirstHalfPalindrome}{ secondHalfPalindromeReverse}" == palindrome)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }
    }
}
