using System;

class GCDCalculator
{
    public int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

class Program
{
    static void Main()
    {
        GCDCalculator gcdCalculator = new GCDCalculator();
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int result = gcdCalculator.CalculateGCD(num1, num2);
        Console.WriteLine("GCD of {0} and {1}: {2}", num1, num2, result);
    }
}