using System;
namespace scripturememorizer;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word (string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetReferencedText()
    {
        if (_isHidden)
        {
            return "________";
        }

        else
        {
            return _text;
        }
    }
    
}


