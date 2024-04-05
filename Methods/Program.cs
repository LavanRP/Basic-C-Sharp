using System;
namespace Method;
class Program 
{
    public static void Main(string[] args)
    {
        string res=string.Empty;
        do
        {
            Console.WriteLine("Enter first number: ");
            int number1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int number2=int.Parse(Console.ReadLine());
            Console.WriteLine("choose an option");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    Console.WriteLine(Addition(number1,number2));
                    break;
                }
                case 2:
                {
                    Console.WriteLine(Subraction(number1,number2));
                    break;
                }
                case 3:
                {
                    Console.WriteLine(Multiplication(number1,number2));
                    break;
                }
                case 4:
                {
                    Console.WriteLine(Division(number1,number2));
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid option");
                    break;
                }
            }
            Console.WriteLine("Do you want to continue? -> Yes");
            res=Console.ReadLine();
        }while(res=="Yes");
    }
    static int Addition(int x,int y)
    {
        int c=x+y;
        return(c);
    }
    static int Subraction(int i,int j)
    {
        int c=i-j;
        return(c);
    }
    static int Multiplication(int k,int l)
    {
        int c=k*l;
        return(c);
    }
    static double Division(double m,double n)
    {
        double c=m/n;
        return(c);
    }
}
