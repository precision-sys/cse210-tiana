using System;
using System.Transactions;
using System.Collections.Generic;

class Comment
{
    private string _commenterName;
    private string _text;

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public void SetCommenterName(string commenterName)
    {
        _commenterName = commenterName;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }
}