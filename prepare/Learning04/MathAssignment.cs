using System;

namespace AssignmentSummary;


class MathExercise : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathExercise (string studentName, string topic, string textbooksection, string problems): base(studentName, topic)
    {
        _textbookSection = textbooksection;
        _problems = problems;
    }

    public string GetTextbookSection()
    {
        return _textbookSection;
    }

    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection}; {_problems}";
    }
} 

