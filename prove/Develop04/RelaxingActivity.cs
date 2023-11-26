using System;

public class RelaxingActivity : Activity
{
    public RelaxingActivity(string name, string description, int duration) : base(name, description, duration)
    
    {
        _name = "Relaxing Activity";
        _description = "If you're feeling stressed, try this exercise to relax your neck and shoulders.";
        _duration = 0;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        ReadySetGo();
        
        DateTime currentTime = DateTime.Now; 
        DateTime futureTime = currentTime.AddSeconds(_duration); 

        while (DateTime.Now < futureTime)
        {
            
            Console.WriteLine();
            Console.Write("Carefuly turn your head to the left");
            ShowSpinner(2);
            Console.WriteLine();
            Console.Write("Hold...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now turn your head to the right");
            ShowSpinner(2);
            Console.WriteLine();
            Console.Write("Hold...");
            ShowCountDown(5);
            Console.WriteLine();
        }
        DisplayEndingMessage();
        return;
    }

}