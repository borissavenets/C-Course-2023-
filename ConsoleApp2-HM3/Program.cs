internal class Program
{
    private static void Main(string[] args)
    {
        //hw3
        //- Write a C# program to check two given integers and return true if one is negative and one is positive.
        
        Console.WriteLine("Input 1st integer");
        var a = Console.ReadLine();
        int a_conv = Convert.ToInt32(a);

        Console.WriteLine("Input 2nd integer");
        var b = Console.ReadLine();
        int b_conv = Convert.ToInt32(b);

        if (a_conv < 0 && b_conv > 0 || b_conv < 0 && a_conv > 0)
        {
            Console.WriteLine($"{a_conv} {b_conv} Check if one is negative and one is positive: true ");
        }

        else
        {
            Console.WriteLine($"{a_conv} {b_conv} Check if one is negative and one is positive: false ");
        }

        //- Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.

        if (a_conv == 20 || b_conv == 20 || a_conv + b_conv == 20) 
        {
            Console.WriteLine($"{a_conv} {b_conv} If one of the integer is 20 or if their sum is 20: true ");
        }

        else
        {
            Console.WriteLine($"{a_conv} {b_conv} If one of the integer is 20 or if their sum is 20: false ");
        }

        //var res = (a_conv == 20 || b_conv == 20 || a_conv + b_conv == 20) ? "test 1" : "test 2";
        //Console.WriteLine(res);

        //- Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
        int c=1;
        while (c <= 99 )
        {
            if (c%2 != 0)
            {
                Console.WriteLine(c);
            }
                c++;
        }

        //- Write a C# program to compute the sum of the first 500 prime numbers.
        int d = 0;
        int num1 = 0;
        while (d != 500)
        {
            if (num1 == 0 || num1 == 1)
            {

            }
            else
            {
                for (int a1 = 2; a1 <= num1 / 2; a1++)
                {
                    if (num1 % a1 == 0)
                    {
                        Console.WriteLine(num1 + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(num1 + " is a prime number");

            }

        }
        //- Write a C# program and compute the sum of the digits of an integer.
        Console.WriteLine("Input integer");
        var num2 = Console.ReadLine();
        int num2_conv = Convert.ToInt32(num2);


        
    }



}