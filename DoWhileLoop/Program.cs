using System;
namespace DoWhileLoop;

class Program 
{
    public static void Main(string[] args)
    {
        
        int num;
        string ans=string.Empty;
        do
        {
            Console.WriteLine("enter the number: ");
            num=int.Parse(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.WriteLine("do you want to check with another number? -yes/no");
            ans=Console.ReadLine();
            do
            {
                if (ans=="yes")
                {
                    break;
                }
                else if(ans=="no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter valid input-yes/no");
                    ans=Console.ReadLine();
                }
                
            }while(ans=="no");
        }while(ans=="yes");
    }
}