using System;

public class BreathingActivity : Activity
{
   
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    
    {
        _name = "Breathing Activity";
        _description = "Relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
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
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }
        DisplayEndingMessage();
        return;
    }


}