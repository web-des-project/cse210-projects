using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)

    
    {
        List<int> numbers = new List<int>();

        int ansNumber = -1;

        while (ansNumber != 0)
        {
            Console.Write("Introduce a number (You can quit by press 0): ");
            string response = Console.ReadLine();
            ansNumber = int.Parse(response);

            if (ansNumber != 0) 
            {
                numbers.Add(ansNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers) 
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers[0];

        foreach (int number in numbers) 
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine($"The max is: {maxNumber}");
         



    }
}