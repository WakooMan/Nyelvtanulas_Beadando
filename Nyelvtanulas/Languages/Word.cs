using Nyelvtanulas.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nyelvtanulas.Languages
{
    public class Word
    {
        public string Text { get; private set; }
        public Language Language { get; private set; }
        private List<Word> OnOtherLanguages;
        private List<Word> _synonyms;
        public Word(Language language, string txt)
        {
            Text = txt;
            Language = language;
            OnOtherLanguages = new List<Word>();
            _synonyms = new List<Word>();
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

        public bool IsSynonymOf(Word value)
        {
            return _synonyms.Any(Value => value == Value);
        }

        public void AddSynonymWord(Word word)
        {
            if (Language.IsThisLanguage(word.Language))
            {
                _synonyms.Add(word);
            }
            else
            {
                throw new AddingOtherLanguageSynonymException();
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