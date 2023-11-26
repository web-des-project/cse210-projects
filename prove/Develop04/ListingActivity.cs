using System;

public class ListingActivity : Activity
{  
   private readonly List<string> _count = new();
   private readonly List<string> _prompt = new()
   {
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?"
   };
   

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
       _name = "Listing Activity";
       _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
       _duration = 0;
    }

    public void Run()
    {
        int count = 0;

        Console.Clear();
        DisplayStartingMessage();
        ReadySetGo();
        
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($">>> {GetRandomPrompt()} <<<");
        Console.WriteLine();
        Console.Write("You may beggin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime currentTime = DateTime.Now; 
        DateTime futureTime = currentTime.AddSeconds(_duration); 

        while (DateTime.Now < futureTime)
        { 
          Console.Write(">");
          string list = Console.ReadLine();
          _count.Add(list);
          count++;
        }

        Console.WriteLine($"You listed {count} items!");
        DisplayEndingMessage();
        return;
    }

    public string GetRandomPrompt()
    {
        Random random = new();
        int index = random.Next(_prompt.Count);
        string randomPrompt = _prompt[index];

        return randomPrompt;
    }
}