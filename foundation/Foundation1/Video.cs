class Video
{
    private string _title;
    private string _author;
    private int _lenghtSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lenghtSeconds = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lenghtSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetComment());
        }
        Console.WriteLine();
    }
}