using Nyelvtanulas.Exceptions;
using System;
using System.Collections.Generic;

namespace Nyelvtanulas.Languages
{
    public class Word
    {
        public string Text { get; private set; }
        public Language Language { get; private set; }
        private List<Word> OnOtherLanguages;
        public Word(Language language, string txt)
        {
            Text = txt;
            Language = language;
            OnOtherLanguages = new List<Word>();
        }

        public void AddOtherLanguageWord(Word word)
        {
            if (!Language.IsThisLanguage(word.Language))
            {
                OnOtherLanguages.Add(word);
            }
            else
            {
                throw new AddingSameLanguageWordException();
            }
        }

        public bool HasLanguage(Language otherLanguage)
        {
            foreach (var word in OnOtherLanguages)
            {
                if (word.Language.IsThisLanguage(otherLanguage))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Word> GetWords(Language OtherLanguage)
        {
            List<Word> words = OnOtherLanguages.FindAll(value => value.Language.IsThisLanguage(OtherLanguage));
            if (words.Count>0)
            {
                return words;
            }
            else
            {
                throw new WordNotFoundException();
            }
        }
    }
}