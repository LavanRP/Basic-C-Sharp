using System;
namespace ForLoop;
 class Program 
 {
    public static void Main(string[] args)
    {
        Console.Write("Enter starting number: ");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter ending number: ");
        int number2=int.Parse(Console.ReadLine());
        int sum=0;
        for (int i=number1+1;i<number2;i++)
        {
            sum=sum+i*i;
        }
        Console.WriteLine(sum);
    }
 }
