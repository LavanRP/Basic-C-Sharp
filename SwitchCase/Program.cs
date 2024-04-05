using System;
namespace SwitchCase;
 class Program 
 {
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number1: ");
        int number1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number2: ");
        int number2=int.Parse(Console.ReadLine());
        Console.WriteLine("choose an option");
        Console.WriteLine("+ for Addition");
        Console.WriteLine("- for Subtraction");
        Console.WriteLine("* for Multiplication");
        Console.WriteLine("/ for Division");
        Console.WriteLine("% for Modulo");
        char option=char.Parse(Console.ReadLine());

        switch(option)
        {
            case '+':
            {
                Console.WriteLine(number1+number2);
                break;
            }
            case '-':
            {
                Console.WriteLine(number1-number2);
                break;
            }
            case '*':
            {
                Console.WriteLine(number1*number2);
                break;
            }
            case '/':
            {
                Console.WriteLine(number1/number2);
                break;
            }
            case '%':
            {
                Console.WriteLine(number1%number2);
                break;
            }
            default:
            {
                Console.WriteLine("Invalid ");
                break;
            }
        }
    }
 }