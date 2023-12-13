using System;

public class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    private List<Comment> _comments = new();

    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }

    public void AddComment(Comment comment)
    {
       _comments.Add(comment);
    }

    public int GetQuantity()
    {
        return _comments.Count;
    }

    public void GetComment()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetText());
        }
    }

    public void GetVideoInfo()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"'{_title}' by {_author} / {_lenght} seconds");
        Console.ResetColor();
        Console.WriteLine();
        if (_comments.Count > 0)
        {
            Console.WriteLine($"Number of comments: {_comments.Count}");
            GetComment();
        }

    }
}