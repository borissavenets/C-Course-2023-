internal class Program
{
    private static void Main(string[] args)
    {
        //Test commite 2
        Console.WriteLine("Hello, World!");
        //hw2
        //- write a c# sharp program:
        int a, b;
        a = 1; b = 2;
        Console.WriteLine("а = " + a);
        Console.WriteLine("b = " + b);
        //-- print the sum of two numbers
        Console.WriteLine("a+b = " + a + b);
        //-- print the result of dividing two numbers
        Console.WriteLine("a/b = " + b / a);

        //-- print the result of the specified operations
        var c = -1 + 4 * 6;
        Console.WriteLine("-1 + 4 * 6 = " + c);
        var c1 = (35 + 5) % 7;
        Console.WriteLine("(35 + 5) % 7 = " + c1);
        var c2 = 14 + -4 * 6 / 11;
        Console.WriteLine("14 + - 4 * 6 / 11 = " + c2);
        var c3 = 2 + 15 / 6 * 1 - 7 % 2;
        Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + c3);

        //--swap two numbers
        var d1 = 5;
        var d2 = 6;
        Console.WriteLine("first number: " + d1);
        Console.WriteLine("seconf number: " + d2);
        Console.WriteLine("after swaping");
        d1 = d1 + d2;
        d2 = d1 - d2;
        d1 = d1 - d2;
        Console.WriteLine("first number: " + d1);
        Console.WriteLine("seconf number: " + d2);

        //-- print the output of multiplication of three numbers which will be entered by the user 
        Console.WriteLine("input the first number to multiply: ");
        var n1 = Console.ReadLine(); 
        int n1_converted = Convert.ToInt32(n1);
        Console.WriteLine("input the second number to multiply: ");
        var n2 = Console.ReadLine();
        int n2_converted = Convert.ToInt32(n2);
        Console.WriteLine("input the third number to multiply: ");
        var n3 = Console.ReadLine();
        int n3_converted = Convert.ToInt32(n3);

        Console.WriteLine("output of multiplication of three numbers:");
        var n4 = n1_converted * n2_converted * n3_converted;

        Console.WriteLine(n4);

    }
}