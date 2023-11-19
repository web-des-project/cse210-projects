using System;
using System.Text;

public class Scripture
{
    private readonly string _text;
    private readonly Reference _reference;
    private readonly List<Word> words;

    public Scripture(string text, Reference reference)
    {
        _text = text;
        _reference = reference;

        string[] wordLine = text.Split(' ');
        words = new List<Word>();

        foreach (string wordText in wordLine)
        {
            words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords()
    {
        Random random = new();
        List<Word> clearWord = words.FindAll(word => !word.IsHidden());
        
        if (clearWord.Count > 0)
        {
            int index = random.Next(0, clearWord.Count);
            clearWord[index].Hide();
        }

    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine("Tips to memorize scriptures!");
        Console.WriteLine("1. Write the scripture by hand in a notebook. Making flashcard is a good idea too!");
        Console.WriteLine("2. Practice speaking aloud. This can help improve your performance and confidence.");
        Console.WriteLine("3. Teach someone else. You can talk about the scripture and share your feelings");
        Console.WriteLine("4. Repeat. Set a time at the day when you can read the scripture, do it everyday, and you will have succesful results.");

        Console.WriteLine();
        Console.WriteLine(_reference.GetDisplayScripture());
        Console.WriteLine();

        foreach (Word word in words)
        {
            if (word.IsHidden())
            {
                Console.Write(new string('_', word.GetScripture().Length) + " ");
            }
            else
            {
                Console.Write(word.GetScripture() + " ");
            }
        }
        Console.WriteLine();
    }

    public bool IsCompletlyHidden()
    {
        return words.TrueForAll(word => word.IsHidden());
    }
}
