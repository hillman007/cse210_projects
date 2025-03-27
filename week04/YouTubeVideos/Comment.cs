using System;

class Comment
{
    private string _commenter;
    private string _text;

    public Comment(string commenter, string text)
    {
        commenter = _commenter;
        text = _text;
    }

    public string GetCommenter()
    {
        return _commenter;
    }

    public string GetText()
    {
        return _text;
    }

}