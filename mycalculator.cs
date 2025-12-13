using System;
using System.ComponentModel.Design;
namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            Console.WriteLine("Welcome to the simple C# calculator!");
            //Get the first number to enter 
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToDouble(Console.ReadLine());
            //Get the second number to enter
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToDouble(Console.ReadLine());
            //Get the expression to enter
            Console.WriteLine("Enter the expression");
            string expression = Console.ReadLine();
            switch(expression)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result:{num1}+{num2}={result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result:{num1}-{num2}={result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result:{num1}*{num2}={result}");
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Result:{num1}/{num2}={result}");
                    break;

                }
            }
        }
    }


                
               

                
            
        
    

            
