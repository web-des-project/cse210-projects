public class QuoteGenerator
{   
    public string GetRandomQuote()
    {
        List<string> _quote = new List<string>();
        string filename = "Quotes.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            line.Split(",");
            _quote.Add(line);
        }

        Random random = new Random();
        int index = random.Next(_quote.Count);
        string randomQuote = _quote[index];
        Console.WriteLine(randomQuote);

        return randomQuote;
    }
}