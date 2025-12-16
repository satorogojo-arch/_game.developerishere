using System;

public class ConversionProgram
{
    public static void Main()
    {
        // Convert centimeter (cm) to meter (m)
        Console.Write("Enter value in centimeters: ");
        double centimeters = Convert.ToDouble(Console.ReadLine());
        double metersResult = centimeters / 100;
        Console.WriteLine($"{centimeters} centimeters is equal to {metersResult} meters.");

        Console.WriteLine(); // Line break

        // Convert meter (m) to centimeter (cm)
        Console.Write("Enter value in meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        double centimetersResult = meters * 100;
        Console.WriteLine($"{meters} meters is equal to {centimetersResult} centimeters.");
    }
}
