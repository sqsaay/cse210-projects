using System;

namespace Homework;

public class WriteAssignment : Assignment
{
    private string _title;

    public WriteAssignment(string name, string topic, string title)
    :base (name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}


