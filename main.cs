// Cristiano
// ICS2O-Unit3-01-CSharp
// March 29 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        int sidea;
        int sideb;
        int height;
        int output;
        
        Console.WriteLine("Enter side A (cm):");
        sidea = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter side B (cm):");
        sideb = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter height (cm):");
        height = Convert.ToInt32(Console.ReadLine());
        output = (((sidea + sideb) / 2) * height);
        Console.WriteLine("\nThe area of this trapezoid is " + (output) + "cm².");
        Console.WriteLine("\nFinished.");
    }
}
