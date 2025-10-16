using Microsoft.VisualBasic;
using System;

// PRECONDITION: The user is prompted to input an amount in euros.
public class Program
{
    public static void Main()
    {
        const float EXCHANGE_RATE = 1.12f;
        const string MSG_INPUT = "Enter amount in euros: ";
        const string MSG_RESULT = "Amount in dollars: ";
        float euros = 0;
        float dollars = 0;
        Console.WriteLine(MSG_INPUT);
        euros = float.Parse(Console.ReadLine());
        dollars = euros * EXCHANGE_RATE;
        Console.WriteLine(MSG_RESULT + dollars);
    }
}
// POSTCONDITION: 'dollars' contains the converted amount, and it is displayed.
