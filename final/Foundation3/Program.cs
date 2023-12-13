using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new("6 oriente","Talca", "Maule", "Chile");
        Address address2 = new("Riquelme 253","Victoria", "Araucanía", "Chile");
        Address address3 = new("Rudecindo Ortega 923","Temuco", "Araucanía", "Chile");

        Lecture lectureEvent = new("Marketing conference", "An important talk about marketing and finances", DateTime.Parse("2024-06-25"), TimeSpan.Parse("19:30"), address1, "Robert Smith", 300);
        Reception receptionEvent = new("IAB reunion", "A social reunion for ex IAB students", DateTime.Parse("2024-02-7"), TimeSpan.Parse("17:30"), address2, "iandresb@gmsil.com");
        Outdoor outdoorEvent = new("Basket hour", "Basket practice with friends", DateTime.Parse("2023-12-19"), TimeSpan.Parse("15:00"), address3, "21°C");

        // Standart Details
        Console.WriteLine("Standart Details:");
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetStandardDetails());

        // Full Details
        Console.WriteLine("Full Details:");
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetFullDetails());
        
        // Short Description
        Console.WriteLine("Short Description:");
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}