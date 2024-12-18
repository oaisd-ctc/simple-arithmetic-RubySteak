using System;

public class Program
{
    public static void Main(string[] args)
    {
        Problem();
    }

    public static void Problem()
    {
        Console.WriteLine("Enter first number");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter opperator (1 = +, 2 = -, 3 = *, 4 = /, 5 = ^)");
        int z = int.Parse(Console.ReadLine());


        if (z == 1)
        {
            Console.WriteLine(x + " plus " + y + " equals " + (x + y));
        }
        else if (z == 2)
        {
            Console.WriteLine(x + " minus " + y + " equals " + (x - y));
        }
        else if (z == 3)
        {
            Console.WriteLine(x + " times " + y + " equals " + (x * y));
        }
        else if (z == 4)
        {
            Console.WriteLine(x + " divided by " + y + " equals " + (x / y));
        }
        else if (z == 5)
        {
            Console.WriteLine(x + " to the power of " + y + " equals " + (x ^ y));
        }
    }

    public static void Subtract()
    {

    }

    public static void Multiply()
    {

    }

    public static void Divide()
    {

    }
}