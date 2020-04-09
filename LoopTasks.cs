using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal class LoopTasks
    {
        // Task 1

        public void Factorial()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            do
            {
                factorial *= n--;
            }
            while (n > 0);

            Console.WriteLine(factorial);
        }

        // Task 2
        // Find the sum and number of even digits of a number 

        public void CountOfPositiveDigits()
        {
            int inputNumber = Int32.Parse(Console.ReadLine());
            int sum = 0;
            int evenNumbers = 0;
            int lastDigit = 0;

            while (inputNumber > 0)
            {
                lastDigit = inputNumber % 10;
                inputNumber /= 10;

                if (lastDigit % 2 != 0)
                {
                    evenNumbers++;
                    sum += lastDigit;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(evenNumbers);
        }

        // Task 3
        // Find the largest digit of a number

        public void BiggestDigitInNumber(int n)
        {
            int remainder = 0;
            int buf = 0;
            int big = 0;

            while (n > 0)
            {
                remainder = n % 10;
                n /= 10;

                if (buf < remainder)
                {
                    big = remainder;
                }
                buf = remainder;
            }
            Console.WriteLine(big);
        }

        // Task 4
        public void MultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }

        // Task 5
        // For each positive integer between m and n, print all the divisors, except for unity and the number itself. 
        // M and n is entered from the keyboard
        public void NumberOfDividers()
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.Write($"{i}: ");

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        Console.Write($"{j}  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
