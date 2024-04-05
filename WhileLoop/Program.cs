using System;
namespace WhileLoop;
 class Program 
 {
    public static void Main(string[] args)
    {
        //first question
        int i=0;
        while(i<=25)
        {
            if (i%2==0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

        //second question
        Console.WriteLine("enter a valid number");
        while(true)
        {
            bool one=int.TryParse(Console.ReadLine(),out int a);
            if (one)
            {
                Console.WriteLine(a);
                break;
            }
            Console.WriteLine( "Invalid input format. Please enter the input in number format");
        }

    }
 }
