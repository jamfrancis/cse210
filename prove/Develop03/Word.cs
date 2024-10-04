using System;

public class Word
{
    // private member variables
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    // returns the words of the scripture
    public string GetDisplayText(Scripture scripture)
    {
        if (_isHidden)
        {
            // if Letter Mode is on, then it returns a letter followed by underscores
            if (scripture.IsLetterMode())
            {
                return $"{_text[0]}{new string('_', _text.Length - 1)}";
            }
            else
            {
                return new string('_', _text.Length);
            }
        }
        else
        {
            return _text;
        }
    }
    

}