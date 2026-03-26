using System;
using System.Collections.Generic;
public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;

    }

    public string DisplayVideoInfo()
    {
        int totalElements = _comments.Count;
        string show = $"Tittle: {_title} \nAuthor: {_author} \nDuration: {_length} minutes \nComments: {totalElements}";
        return show;
    }

    public string DisplayVideoComments()
    {

        List<string> commentsTemporal = new List<string>();
        foreach (Comment c in _comments)
        {
            string showC = $"{c.DisplayComment()}";
            commentsTemporal.Add(showC);
        }

        string result = string.Join("\n", commentsTemporal);
        return result;

    }


}

