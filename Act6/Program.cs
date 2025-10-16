using Microsoft.VisualBasic;
using System;

// PRECONDITION: The user is prompted to input two integers.
public class Program
{
    public static void Main()
    {
        const string MSG_INPUT1 = "Enter the first integer: ";
        const string MSG_INPUT2 = "Enter the second integer: ";
        const string MSG_RESULT = "The sum is: ";
        int num1 = 0;
        int num2 = 0;
        int sum = 0;
        Console.WriteLine(MSG_INPUT1);
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine(MSG_INPUT2);
        num2 = int.Parse(Console.ReadLine());
        sum = num1 + num2;
        Console.WriteLine(MSG_RESULT + sum);
    }
}
// POSTCONDITION: 'sum' contains the sum of 'num1' and 'num2', and it is displayed.