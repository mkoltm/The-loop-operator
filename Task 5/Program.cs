using System;

class PrimeSumCalculator
{
    public void CalculateAndPrintPrimeSum(int start, int end)
    {
        int sum = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        Console.WriteLine("Sum of prime numbers from {0} to {1}: {2}", start, end, sum);
    }

    private bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        PrimeSumCalculator primeSumCalculator = new PrimeSumCalculator();
        primeSumCalculator.CalculateAndPrintPrimeSum(1, 50);
    }
}