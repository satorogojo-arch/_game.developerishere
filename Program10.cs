using System;
using System.Collections.Generic;
using System.Linq;

public class EmployeesList
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee(1, "Arnav", 13000),
            new Employee(2, "Dhruv", 11200),
            new Employee(3, "Atharva", 12300),
            new Employee(4, "Krishna", 13000),
            new Employee(5, "Manik", 12200),
            new Employee(6, "Vansh", 13000),
            new Employee(7, "Hirday", 11200),
            new Employee(8, "Abhinav", 12200),
        };

        // Sort by Salary (High to Low)
        var sortedEmployees = employees.OrderByDescending(e => e.Salary);

        Console.WriteLine("Number\tName\t\tSalary\t\tCommission (3%)");
        Console.WriteLine("-------------------------------------------------------");
        foreach (var el in sortedEmployees)
        {
            // Display results including the calculated 3% Commission
            Console.WriteLine($"{el.Number}\t{el.Name}\t\t{el.Salary}\t\t{el.Commission}");
        }
    }
}

class Employee
{
    public int Number { get; }
    public string Name { get; }
    public int Salary { get; }

    // Calculated Property: Uses the formula (Salary * 3) / 100
    public double Commission => (double)Salary * 3 / 100;

    public Employee(int number, string name, int salary)
    {
        Number = number;
        Name = name;
        Salary = salary;
    }
}



