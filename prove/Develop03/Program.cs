using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 36, 1, 2);
        string text = "My son, give ear to my words; for I swear unto you, that inasmuch as ye shall keep the commandments of God ye shall prosper in the land. I would that ye should do as I have done, in remembering the captivity of our fathers; for they were in bondage, and none could deliver them except it was the God of Abraham, and the God of Isaac, and the God of Jacob; and he surely did deliver them in their afflictions.";
    

                Scripture scripture = new Scripture (reference, text);
                
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetReferencedText());
                    Console.WriteLine("Press ENTER to hide words or type 'quit' to exit.");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
            
                        break;

                    scripture.HideRandomWords(4);    

                    if (scripture.IsCompletelyHidden())
                    {
                        Console.Clear();
                        Console.WriteLine(scripture.GetReferencedText());
                        Console.WriteLine("All words are hidden. Program will Exit");
                        break;
                    }
            
                }   

    }
}










class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int chapter, int verse)

    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
    }

    public Reference (string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetReferencedText()
    {
        if (_verseStart == _verseEnd)
        {
            return $"{_book} {_chapter}: {_verseStart}";
        }

        else
        {
            return $"{_book} {_chapter} : {_verseStart} - {_verseEnd}";
        }
    }
}






















































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
