using System;

public class Scripture
{
    // private member variables
    private Reference _reference;
    private List<Word> _words;
    private bool _letterMode;
    private static Random _random = new Random();

    // constructor for Scripture class
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // splits the text of the scripture into the list
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }

    // hides a random amount of words from the _words list 
    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int randomIndex = _random.Next(_words.Count);

            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }

    // toggles the Letter Mode on or off
    public void SetLetterMode(bool mode)
    {
        _letterMode = mode;
    }

    // returns the words of the scripture, joins them together, and replaces the hidden words with underscores. 
    public string GetDisplayText()
    {   
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.Select(word => word.GetDisplayText(this)))}";
    }   

    // checks if all the words are hidden or not
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    // getter for _lettermode
    public bool IsLetterMode()
    {
        return _letterMode;
    }


}