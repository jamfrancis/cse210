using System;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName, commentText);
        _comments.Add(newComment);
    }

    public int CommentCount()
    {
        return _comments.Count;
    }

    public string GetDisplayText()
    {
        int mins = _length / 60;
        int secs = _length % 60;
        string time;

        if (mins > 0)
        {
            if (secs > 0)
            {
                time = $"{mins} min {secs} sec";
            }
            else
            {
                time = $"{mins} min";
            }
        }
        else
        {
            time = $"{secs} sec";
        }
        string info = $"{_title}\n{_author}\n{time}\nNumber of Comments: {CommentCount()}\n Comments:";
        foreach (var comment in _comments)
        {
            info += $"\n- {comment.GetDisplayText()}";
        }
        
        return info;

    }

}