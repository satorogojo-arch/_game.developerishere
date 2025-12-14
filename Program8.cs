using System;
using System.Runtime.Intrinsics.X86;

class FormulaSheet
{
    static void Main()
    {
        // Set up the console look for the entire application
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();

        // --- CONE Calculations ---
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("--- CONE CALCULATIONS ---");
        Console.ForegroundColor = ConsoleColor.White;

        double coneRadius, coneHeight, slantHeight, coneCSA, coneTSA, coneVolume;

        Console.Write("Enter the Radius of the cone (r) in cm: ");
        coneRadius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Height of the cone (h) in cm: ");
        coneHeight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the slantHeight of yhe cone(l) in cm:");
        slantHeight = Convert.ToDouble(Console.ReadLine());

        // CSA: PI * r * l
        coneCSA = Math.PI * coneRadius * slantHeight;
        Console.WriteLine($"\nCurved Surface Area (CSA): {coneCSA:F2} cm²");

        // TSA: PI * r * (r + l)
        coneTSA = Math.PI * coneRadius * (coneRadius + slantHeight);
        Console.WriteLine($"Total Surface Area (TSA): {coneTSA:F2} cm²");

        // Volume: (1/3) * PI * r² * h
        coneVolume = (1.0 / 3.0) * Math.PI * Math.Pow(coneRadius, 2) * coneHeight;
        Console.WriteLine($"Volume (V): {coneVolume:F2} cm³\n\n");

        // --- SPHERE Calculations ---
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("--- SPHERE CALCULATIONS ---");
        Console.ForegroundColor = ConsoleColor.White;

        double sphereRadius, sphereTSA, sphereVolume;

        Console.Write("Enter the radius of the sphere (r) in cm: ");
        sphereRadius = Convert.ToDouble(Console.ReadLine());

        // Note: Spheres only have one surface area measurement (Total Surface Area)

        // TSA: 4 * PI * r²
        sphereTSA = 4 * Math.PI * Math.Pow(sphereRadius, 2);
        Console.WriteLine($"\nTotal Surface Area (TSA): {sphereTSA:F2} cm²");

        // Volume: (4/3) * PI * r³
        sphereVolume = (4.0 / 3.0) * Math.PI * Math.Pow(sphereRadius, 3);
        Console.WriteLine($"Volume (V): {sphereVolume:F2} cm³\n\n");

        // --- HEMISPHERE Calculations ---
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--- HEMISPHERE CALCULATIONS ---");
        Console.ForegroundColor = ConsoleColor.White;

        double hemiRadius, hemiCSA, hemiTSA, hemiVolume;

        Console.Write("Enter the radius of the hemisphere (r) in cm: ");
        hemiRadius = Convert.ToDouble(Console.ReadLine());

        // CSA: 2 * PI * r²
        hemiCSA = 2 * Math.PI * Math.Pow(hemiRadius, 2);
        Console.WriteLine($"\nCurved Surface Area (CSA): {hemiCSA:F2} cm²");

        // TSA: 3 * PI * r² (includes the flat circular base)
        hemiTSA = 3 * Math.PI * Math.Pow(hemiRadius, 2);
        Console.WriteLine($"Total Surface Area (TSA): {hemiTSA:F2} cm²");

        // Volume: (2/3) * PI * r³
        hemiVolume = (2.0 / 3.0) * Math.PI * Math.Pow(hemiRadius, 3);
        Console.WriteLine($"Volume (V): {hemiVolume:F2} cm³");

        // Keep the console window open until a key is pressed
        Console.ResetColor();
        Console.WriteLine("\nCalculations complete. Press any key to exit...");
        Console.ReadKey();
    }
}








