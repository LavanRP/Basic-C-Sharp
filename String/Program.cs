using System;
namespace String;
 class Program 
 {
    public static void Main(string[] args)
    {
        Console.Write("Main string: ");
        string str1=Console.ReadLine();
        Console.Write("String to be searched: ");
        string str2=Console.ReadLine();
        string[] arry=str1.Split(str2);
        Console.WriteLine(arry.Length-1);
    }
 }