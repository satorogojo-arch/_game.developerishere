using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the temprature in fahrenheit ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celcius = (fahrenheit * 9 / 5 - 32);
        Console.WriteLine($"{fahrenheit} is {celcius}");
        Console.Write("Enter the Kilogram (kg) : ");
        decimal kilogram = Convert.ToDecimal(Console.ReadLine());
        decimal gram = kilogram * 1000;
        Console.WriteLine($"{kilogram} Kilogram in Gram is equal to {gram}");
        Console.ReadKey();
    }


}


        
    





