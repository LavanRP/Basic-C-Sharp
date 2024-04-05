using System;
namespace DateTimeAssignment;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine("Day: "+date.ToString("dd"));
        Console.WriteLine("Month: "+date.ToString("MM"));
        Console.WriteLine("Year: "+date.ToString("yyyy"));
        Console.WriteLine("Hours: "+date.ToString("hh"));
        Console.WriteLine("Minutes: "+date.ToString("mm"));
        Console.WriteLine("Second: "+date.ToString("dd"));


        string str=date.ToString("yyyy/MM/dd/hh mm:ss:tt");
        string[] arr=str.Split('/',' ',':');
        int temp=arr.Length;
        for (int i=temp-1;i>=0;i--)
        {
            Console.Write(arr[i]+" ");
        }


        DateTime date2=new DateTime();
        Console.WriteLine(" ");
        Console.WriteLine("Enter a date: yyyy/MM/dd hh:mm:ss tt");
        bool result=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date2);
        while(!result)
        {
            Console.WriteLine("Enter the date in the following formate: yyyy/MM/dd hh:mm:ss tt");
            result=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date2);
        }
        Console.WriteLine("Year: "+date2.ToString("yyyy"));
        Console.WriteLine("Month: "+date2.ToString("MM"));
        Console.WriteLine("Day: "+date2.ToString("dd"));
    }
}
