class Comment
{
    private string _userName;
    private string _comment;

    public Comment(string commenter, string text)
    {
        _userName = commenter;
        _comment= text;
    }

    public string GetComment()
    {
        return $"{_userName}: {_comment}";
    }
}

