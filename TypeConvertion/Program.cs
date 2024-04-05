using System;
namespace TypeConvertion;

class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the name: ");
        string name=Console.ReadLine();
        Console.Write("Enter age: ");
        int age=int.Parse(Console.ReadLine());
        Console.Write("Enter marks of subject1: ");
        int sub1=int.Parse(Console.ReadLine());
        Console.Write("Enter marks of subject2: ");
        int sub2=int.Parse(Console.ReadLine());
        Console.Write("Enter marks of subject3: ");
        int sub3=int.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade=char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number: ");
        long mobile= long.Parse(Console.ReadLine());
        Console.Write("Enter Mail id: ");
        string mail=Console.ReadLine();
        int total=sub1+sub2+sub3;
        double avg=Convert.ToDouble(total)/3;

        Console.WriteLine("Trainee Details are");
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Mobile: "+ mobile);
        Console.WriteLine("Mark1: "+sub1);
        Console.WriteLine("Mark2: "+sub2);
        Console.WriteLine("Mark3: "+sub3);
        Console.WriteLine("Total: "+total);
        Console.WriteLine("Average: "+avg);
        Console.WriteLine("Grade: "+grade);
        Console.WriteLine("Mail id: "+mail);

        
    }
}
