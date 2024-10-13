using System;

public class Comment
{
    private string _commentAuthor;
    private string _commentText;

    public Comment(string commentAuthor, string commentText)
    {
        _commentAuthor = commentAuthor;
        _commentText = commentText;
    }

    public string GetDisplayText()
    {
        return $"{_commentAuthor}: {_commentText}";
    }
}