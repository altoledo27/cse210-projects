public class Assignment 
{
    protected string _studentName = "";
    protected string _topic = "";

    public Assignment()
    {
        _studentName = "Anonymous";
        _topic = "Unknown";
    }

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public void SetInformation(string name, string topic)
    {
        _studentName = name;
        _topic = topic;

    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";

    }

}