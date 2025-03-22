using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    private int _coveredCount = 0;
    private int _toHide = 0;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> unhiddenWords = new List<Word>();
        if (_toHide <= numberToHide)
        {
            _toHide = 0;
        }
        while (_toHide < numberToHide)
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden()) // Check if the word is not hidden
                {
                    unhiddenWords.Add(word); // Add it to the new list
                }
            }
            if (unhiddenWords.Count > 0)
            {
                int Index = random.Next(0, unhiddenWords.Count);
                unhiddenWords[Index].Hide();
                _toHide ++;
                _coveredCount ++;
            }  
        }
    }

    public string GetDisplayText()
    {   
        List<string> visibleWords = _words.ConvertAll(word => word.ToString());
        string renderedText = string.Join(" ", visibleWords);

        return $"{_reference.GetDisplayText()} {renderedText}";
    }

    public bool IsCompletelyHidden()
    {
        return _coveredCount >= _words.Count;
    }
}