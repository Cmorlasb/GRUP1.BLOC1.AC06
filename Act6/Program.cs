using Microsoft.VisualBasic;
using System;

// PRECONDITION: The user is prompted to input the width and height of a rectangle.
public class SumTwoNumbers
{
    public static void Main()
    {
        const string MSG_INPUT_WIDTH = "Enter the width of the rectangle: ";
        const string MSG_INPUT_HEIGTH = "Enter the height of the rectangle: ";
        const string MSG_RESULT = "The area of the rectangle is: ";
        float width = 0;
        float heigth = 0;
        float area = 0;
        Console.WriteLine(MSG_INPUT_WIDTH);
        width = float.Parse(Console.ReadLine());
        Console.WriteLine(MSG_INPUT_HEIGTH);
        heigth = float.Parse(Console.ReadLine());
        area = width * heigth;
        Console.WriteLine(MSG_RESULT + area);
    }
}
// POSTCONDITION: 'area' contains the product of 'width' and 'height', and it is displayed.
