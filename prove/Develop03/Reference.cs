using System;

public class Reference
{
    private readonly string _book;
    private readonly int _chapter;
    private readonly int _startVerse;
    private readonly int _endVerse;

    public Reference(string book, int chapter, int startverse)
    {
       _book = book;
       _chapter = chapter;
       _startVerse = startverse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
       _book = book;
       _chapter = chapter;
       _startVerse = startVerse;
       _endVerse = endVerse;
    }

    public string GetDisplayScripture()
    {
       if (_endVerse != 0)
       {
        return $">> {_book} {_chapter}: {_startVerse} - {_endVerse} <<";
       }
       else
       {
        return $">> {_book} {_chapter}: {_startVerse} <<";
       }
    }
}

