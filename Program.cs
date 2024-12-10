using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 32, 22, 55, 48, 26, 54, 98 };

        var selectedNumbers = numbers.Skip(2).Take(4).ToArray();
        Console.WriteLine("Вибрані числа:");
        Console.WriteLine(string.Join(", ", selectedNumbers));
    }
}
