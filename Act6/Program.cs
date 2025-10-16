using Microsoft.VisualBasic;
using System;

public class Program
{
    public static void Main()
    {
        const string MSG_INPUT = "Enter termperature in Celsius: ";
        const string MSG_RESULT = "Temperature in Kelvin: ";
        float celsius = 0;
        float kelvin = 0;
        Console.WriteLine(MSG_INPUT);
        celsius = float.Parse(Console.ReadLine());
        kelvin = celsius + 273.15f;
        Console.WriteLine(MSG_RESULT + kelvin);
    }
}
