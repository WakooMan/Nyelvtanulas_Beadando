using Nyelvtanulas.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvtanulas.Languages
{ 
    public abstract class Language
    {
        private List<Word> _words;
        public abstract string Name();

        protected Language()
        {
            _words = new List<Word>();
        }

        public bool IsThisLanguage(Language OtherLanguage)
        {
            return Name() == OtherLanguage.Name();
        }

        public bool IsThisLanguage(string OtherLanguage)
        {
            return Name() == OtherLanguage;
        }

        public List<Word> PickRandomWords(Language OtherLanguage)
        { 
            List<Word> result = new List<Word>();
            List<Word> ValidWords = _words.Where(value => value.Translations(OtherLanguage).Count()>0).ToList();
            if (ValidWords.Count < 10)
            {
                throw new NotEnoughWordException($"{Name()} Language does not have at least 10 translations on {OtherLanguage.Name()} Language.");
            }
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Word temp = ValidWords[rnd.Next(0, ValidWords.Count - 1)];
                ValidWords.Remove(temp);
                result.Add(temp);
            }
            return result;
        }

        public void AddTranslation(Word Translated_Word,Word Translation_Word)
        {
            Word? w = _words.Find(word => word.Text == Translated_Word.Text);
            if (w is not null)
            {
                if (IsThisLanguage(w.Language))
                {
                    throw new TriedToAddSameLanguageTranslationException();
                }
                w.TryAddTranslation(Translation_Word);
            }
            else
            {
                throw new TranslatedWordNotFoundException();
            }
        }

        public Word AddWord(string Word)
        {
            if (_words.All(word => word.Text != Word))
            {
                Word temp = new Word(this, Word);
                _words.Add(temp);
                return temp;
            }
            else
            {
                throw new WordAlreadyAddedException();
            }
        }

        public IEnumerable<string> Words => _words.AsEnumerable().Select(value=> value.Text);

        public Word? GetWord(string word)
        {
            return _words.Find(value => value.Text == word);
        }

        public List<Word> GetWords(Language Translation_Language)
        {
            return _words.FindAll(value => value.Translations(Translation_Language).Count()>0);
        }
    }
}
