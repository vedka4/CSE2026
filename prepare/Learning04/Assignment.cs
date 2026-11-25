

public class Assignment
{
    protected string _studentName;
    protected string _topic;
    public Assignment(string name, string tpoic)
    {
        _studentName = name;
        _topic = tpoic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}