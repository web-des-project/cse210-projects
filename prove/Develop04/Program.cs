using System;

class Program
{
    static void Main(string[] args)
    {
        string activity;
        int userInput;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine();
            Console.WriteLine("1.-Breathing Activity");
            Console.WriteLine("2.-Reflecting Activity");
            Console.WriteLine("3.-Listing Activity");
            Console.WriteLine("4.-Relaxing Activity");
            Console.WriteLine("5.-Quit");
            Console.WriteLine();
            Console.Write("Select an option from the menu: ");

            activity = Console.ReadLine();
            userInput = int.Parse(activity);
            
            switch(userInput)
            {
                case 1:
                    Console.Clear();
                    BreathingActivity breathingActivity = new("", "", 0);
                    breathingActivity.Run();

                break;
                case 2:
                    Console.Clear();
                    ReflectingActivity reflectingActivity = new("", "", 0);
                    reflectingActivity.Run();

                break;
                case 3:
                    Console.Clear();
                    ListingActivity listingActivity = new("", "", 0);
                    listingActivity.Run();

                break;
                case 4:
                    Console.Clear();
                    RelaxingActivity relaxingActivity = new("", "", 0);
                    relaxingActivity.Run();

                break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Thanks for using the Mindfulness Program!");
                    Console.WriteLine("See you soon.");
                    Console.WriteLine();

                break;
            }
        } while (userInput != 5);
    }
    }