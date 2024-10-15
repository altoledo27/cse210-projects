public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";
    public MathAssignment () : base()
    {
        _textbookSection = "Unknown";
        _problems = "?";
    }

    public MathAssignment(string name, string topic, string txtsection, string problems) : base(name, topic)
    {
        _textbookSection = txtsection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}\n{_textbookSection} {_problems}";

    }

}