using System;
using System.Drawing;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        Console.WriteLine("Type the number of integers you want to generate:");
        int Min = 0;
        int Max = 20;
        //Wasn't sure about the max value of random integers
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];

        
        for (int i = 0; i < size; i++)
        {
            numbers[i] = r.Next(Min, Max);
        }

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"{numbers [i].ToString()}");
        }
        Console.WriteLine($"Total of the number of added integers={Add(numbers)}");
        Console.WriteLine($"Total of the number of multiplied integers={Multiply(numbers)}");


    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }


}
