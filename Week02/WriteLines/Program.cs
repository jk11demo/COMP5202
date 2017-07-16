using System;

namespace WriteLines
{
    class Program
    {
        static void Main(string[] args)
        {
            //For each question, write a Console.WriteLine message to say what question the answer is for.

            //1: Print the answer of multiplying 2 numbers
            //The content should not be the actual answer, but the calculation

            Console.WriteLine("Question 01");
            Console.WriteLine(13 * 25);

            //2: Print the answer of divding 2 numbers
            //The content should not be the actual answer, but the calculation

            Console.WriteLine("Question 02");
            Console.WriteLine(25 / 13);

            //3: Print the answer of adding 2 numbers together using 2 variables
            //The content should not be the actual answer, but the calculation

            Console.WriteLine("Question 03");
            var a = 13;
            var b = 25;

            Console.WriteLine(a + b);

            //4: Write the code for these calculations:
            // * -1 + 4 * 6
            // * ( 35+ 5 ) % 7
            // * 14 + -4 * 6 / 11
            // * 2 + 15 / 6 * 1 - 7 % 2

            Console.WriteLine("Question 04");
            Console.WriteLine(-1+4*6);
            Console.WriteLine((35+5)%7);
            Console.WriteLine(14+-4*6/11);
            Console.WriteLine(2+15/6*1-7%2);
            
            //5: Write the code to swap numbers 
            // * Create 3 variables, int a1 = 20, int b1 = 30, int c
            // * Print out variable a and b with the title "number 1 = 20 and number 2 = 30" etc.
            // * Now reassign the variables, but don't redeclare them so that a1 = 30, b1 = 20
            // * Now print them out again  "number 1 = 30 and number 2 = 20"

            Console.WriteLine("Question 05");
            int a1 = 20, b1 = 30, c;

            Console.WriteLine($"Number 1 = {a1}");
            Console.WriteLine($"Number 2 = {b1}");

            c = a1;
            a1 = b1;
            b1 = c;

            Console.WriteLine($"Number 1 = {a1}");
            Console.WriteLine($"Number 2 = {b1}");

        }
    }
}
