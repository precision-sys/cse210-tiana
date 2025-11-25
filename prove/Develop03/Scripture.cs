using System;
namespace scripturememorizer;
using System.Collections.Generic;


class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture (Reference reference, string text)
    {
        _reference =  reference;
        ParseWords(text);
    }
    
    
    private void ParseWords(string text)
    {
        string[] splitWords = text.Split(" ");

        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetReferencedText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetReferencedText());
        }

        string scriptureText = string.Join(" ", displayWords);
        return $"{_reference.GetReferencedText()} \n{scriptureText}";
    }

    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count && _words.Count > 0; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}




