using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("The largest number is " + FindLargest(4, 6, 9));
        Console.WriteLine("The lowest number is " + FindLowest(4, 6, 9));
        Console.WriteLine("The nearest value of 20 is " + FindNearestOf20(16, 9));
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("The sum of array's values is " + SumOfArray(numbers));
        Console.WriteLine("The largest of array's values is " + FindLargestInArray(numbers));
    }

    //hw4
    //-Write a C# method to find the largest value from three integer values.
    public static int FindLargest (int a, int b, int c) 
    {
        int largest;
        largest = a;    
        if (b > c) 
            largest = b;
        if (c > largest) 
            largest = c;
        return largest;
    }

    //-Write a C# method to find the lowest value from three integer values.

    public static int FindLowest(int a, int b, int c)
    {
        int lowest;
        lowest = a;
        if (b < lowest)
            lowest = b;
        if (c < lowest)
            lowest = c;
        return lowest;
    }
    //- Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 
    public static int FindNearestOf20(int a, int b)
    {
        if (a == b)
        {
            return 0;
        }

        int distanceFromA = Math.Abs(a - 20);
        int distanceFromB = Math.Abs(b - 20);

        if (distanceFromA < distanceFromB)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    //-Write a C# method to compute the sum of all the elements of an array of integers
    public static int SumOfArray(int[] array)
    {
        int sum = 0;
        for(int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    //- Write a C# method to get the larger value from array
    public static int FindLargestInArray(int[] array)
    {
        int largest = 0;
        for (int i = 0;i < array.Length;i++)
        {
            if (array[i] > largest)
            {
                largest = array[i];
            }
        }
        return largest;
    }

}