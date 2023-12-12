using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new()
        {
            new Running(new DateTime(2023, 12, 06), 45, 7),
            new Cycling(new DateTime(2023, 11, 28), 10, 30),
            new Swimming(new DateTime(2023, 09, 15), 60, 25)
        };

        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }
    }
}