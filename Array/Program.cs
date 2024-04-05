using System;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the size of the array");
        int size = int.Parse(Console.ReadLine());
        string[] arr = new string[size];
        Console.WriteLine("enter the elements in the array");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Console.ReadLine();
        }
        for (int m = 0; m < size; m++)
        {
            Console.Write(arr[m]+" ");
        }
        Console.WriteLine("");
        Console.WriteLine("enter a name");
        string name = Console.ReadLine();
        int j = 0;
        int count = 0;

        for(int l=0;l<size;l++)
        {
            if (name==arr[l])
            {
                Console.WriteLine("The name is present in array");
                Console.WriteLine("The index value is: " + l);
            }
        }


        foreach (string k in arr)
        {
            if (k == name)
            {
                Console.WriteLine("The name is present in array");
                Console.WriteLine("The index value is: " + j);
                count++;
            }

            j++;
        }

        if (count < 1)
        {
            Console.WriteLine("The name is not present in array");
        }
    }
}
