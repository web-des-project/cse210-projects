using System;
using System.ComponentModel;
using System.Linq.Expressions;

public class PromptGenerator
{   
    public string GetRandomPrompt()
    {
        List<string> _prompts = new List<string>();
        string filename = "Question.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            line.Split("?");
            _prompts.Add(line);
        }

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine(randomPrompt);

        return randomPrompt;
    }
}