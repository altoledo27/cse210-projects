public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment () : base ()
    {
        _title = "Unknown Title";

    }
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic}\n{_title} by {_studentName}";

    }

}
