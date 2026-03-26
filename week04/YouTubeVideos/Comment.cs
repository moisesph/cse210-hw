using System;

public class Comment
{
    private string _author;
    private string _text;

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public string DisplayComment()
    {
        string show = $"{_author}: {_text}";
        return show;
    }
}