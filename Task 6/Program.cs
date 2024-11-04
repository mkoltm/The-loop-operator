using System;

class BinaryConverter
{
    public string ConvertToBinary(int number)
    {
        return Convert.ToString(number, 2);
    }
}

class Program
{
    static void Main()
    {
        BinaryConverter binaryConverter = new BinaryConverter();
        Console.WriteLine("Enter a number:");
        int userInput = Convert.ToInt32(Console.ReadLine());
        string binaryResult = binaryConverter.ConvertToBinary(userInput);
        Console.WriteLine("Binary representation of {0}: {1}", userInput, binaryResult);
    }
}