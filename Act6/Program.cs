using Microsoft.VisualBasic;
using System;

// PRECONDITION: The user is prompted to input three real numbers.
public class Program
{
    public static void Main()
    {
        const string MSG_INPUT1 = "Enter the first number: ";
        const string MSG_INPUT2 = "Enter the second number: ";
        const string MSG_INPUT3 = "Enter the third number: ";
        const string MSG_RESULT = "Enter the third number: ";
        float num1 = 0;
        float num2 = 0;
        float num3 = 0;
        float average = 0;
        Console.WriteLine(MSG_INPUT1);
        num1 = float.Parse(Console.ReadLine());
        Console.WriteLine(MSG_INPUT2);
        num2 = float.Parse(Console.ReadLine());
        Console.WriteLine(MSG_INPUT3);
        num3 = float.Parse(Console.ReadLine());
        average = (num1 + num2 + num3) / 3;
        Console.WriteLine(MSG_RESULT + average);
    }
}
// POSTCONDITION: 'average' contains the arithmetic mean of the three numbers, and it is displayed.
