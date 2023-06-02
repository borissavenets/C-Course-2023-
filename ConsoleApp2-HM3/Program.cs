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
        int c = 1;
        while (c <= 99)
        {
            if (c % 2 != 0)
            {
                Console.WriteLine(c);
            }
            c++;
        }

        //- Write a C# program to compute the sum of the first 500 prime numbers.
        int n = 500;
        int sum = 0;
        int count = 0;
        int number = 2;

        while (count < n)
        {
            bool isPrime = true;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                sum += number;
                count++;
            }

            number++;
        }

        Console.WriteLine("The sum of the first {0} prime numbers is: {1}", n, sum);


        -Write a C# program and compute the sum of the digits of an integer.

        Console.WriteLine(" Input a number(integer):");
        var enteredNumber = Console.ReadLine();
        var stringLength = enteredNumber.Length;
        int digitSum = 0;


        for (var i = 0; i < stringLength;)

        {
            char digit = enteredNumber[i];

            //int digit_c = Convert.ToInt32(digit);
            int digit_c = (int)Char.GetNumericValue(digit);

            Console.WriteLine($"digit_c - {digit_c}");
            digitSum += digit_c;
            i++;

        }

        Console.WriteLine($"Sum of the digits of the said integer: {digitSum}");


    }



}