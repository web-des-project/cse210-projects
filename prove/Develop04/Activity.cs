using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");   
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_description}.");
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? "); 

        string durationSec;
        durationSec = Console.ReadLine();
        _duration = int.Parse(durationSec);   
        return;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!"); 
        Console.WriteLine();
        ShowSpinner(2);  
        Console.WriteLine($"You have successfully completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);  
        return;
    }

    public static void ShowSpinner(int seconds)
    {
        DateTime currentTime = DateTime.Now; 
        DateTime futureTime = currentTime.AddSeconds(seconds); 

        while (DateTime.Now < futureTime)
        {
            char[] spinnerChar = new char[]{'|','/','-','\\'};
            foreach (char spinner in spinnerChar)
            {
                Console.Write(spinner);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        return;
    }

    public static void ReadySetGo()
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(2000);
        Console.Write("\b \b");
        Console.WriteLine("Set...");
        ShowSpinner(3);
        Console.WriteLine("Go...");
        Console.WriteLine();
        return;
    }

    public static void ShowCountDown(int seconds)
    {
        int duration = seconds;
        DateTime currentTime = DateTime.Now; 
        DateTime futureTime = currentTime.AddSeconds(seconds); 

        while (DateTime.Now < futureTime)
        {
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            duration--;
        }
        return;
    }
}
