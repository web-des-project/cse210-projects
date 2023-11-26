using System;

public class ReflectingActivity : Activity
{
   private readonly List<string> _prompt = new()
   {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
   };
   private readonly List<string> _question = new()
   {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
   };

   public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
       _name = "Reflecting Activity";
       _description = "Reflect on times in your life when you have shown strength and resilence. This will help you recognize the power you have and how you can use it in other aspects of your life";
       _duration = 0;
    }


    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        ReadySetGo();
        DisplayPrompt();
        Console.Clear();
        
        DateTime currentTime = DateTime.Now; 
        DateTime futureTime = currentTime.AddSeconds(_duration); 

        while (DateTime.Now < futureTime)
        {
            DisplayQuestion();
        }
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

    public void DisplayPrompt()
    {
       Console.WriteLine("Consider the following prompt: ");
       Console.WriteLine();
       Console.WriteLine($" --- {GetRandomPrompt()} --- ");
       Console.WriteLine();
       Console.WriteLine("When you have something in mind, press 'Enter' to continue.");
       Console.ReadLine();
       Console.WriteLine();
       Console.WriteLine("Now ponder in each of the following questions as they related to this experience.");
       Console.Write("You may begin: ");
       ShowCountDown(5);
       return;
    }

    public string GetRandomQuestion()
    {
       Random random = new();
       int index = random.Next(_question.Count);
       string randomQuestion = _question[index];

       return randomQuestion;
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($">> {GetRandomQuestion()}");
        ShowSpinner(15);
    }
}