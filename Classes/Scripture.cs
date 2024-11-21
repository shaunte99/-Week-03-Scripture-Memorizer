using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer.Classes
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public string GetScriptureText()
        {
            string referenceText = _reference.ToString();
            string scriptureText = string.Join(" ", _words.Select(word => word.Display()));
            return $"{referenceText} - {scriptureText}";
        }

        public void HideWords(int count)
        {
            Random random = new Random();
            var visibleWords = _words.Where(word => !word.IsHidden).ToList();

            for (int i = 0; i < count && visibleWords.Count > 0; i++)
            {
                Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
                wordToHide.Hide();
                visibleWords.Remove(wordToHide);
            }
        }

        public bool AllWordsHidden()
        {
            return _words.All(word => word.IsHidden);
        }
    }
}
