using System;
using System.Transactions;

class Video
{
    private string _title;
    private string _authour;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string authour, int length)
    {
        title = _title;
        authour = _authour;
        length = _length;
        _comments = new List<Comment>();
    }

    public void AddComment(string commenter, string text)
    {
        _comments.Add(new Comment(commenter, text));
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Authour: {_authour}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($" - {comment.GetCommenter}: {comment.GetText}");
        }
        Console.WriteLine();
    }
}