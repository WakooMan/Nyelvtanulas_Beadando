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
        private List<Translation> _words;
        public abstract string Name();

        protected Language()
        {
            _words = new List<Translation>();
        }

        public bool IsThisLanguage(Language OtherLanguage)
        {
            return Name() == OtherLanguage.Name();
        }

        public bool IsThisLanguage(string OtherLanguage)
        {
            return Name() == OtherLanguage;
        }

        public List<Translation> PickRandomWords(Language OtherLanguage)
        { 
            List<Translation> result = new List<Translation>();
            List<Translation> ValidWords = _words.Where(value => value.Translation_Language == OtherLanguage.Name()).ToList();
            if (ValidWords.Count < 10)
            {
                throw new NotEnoughWordException($"{Name()} Language does not have at least 10 translations on {OtherLanguage.Name()} Language.");
            }
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Translation temp = ValidWords[rnd.Next(0, ValidWords.Count - 1)];
                ValidWords.Remove(temp);
                result.Add(temp);
            }
            return result;
        }

        public void AddTranslation(Translation word)
        {
            if (_words.All(value => value != word))
            {
                _words.Add(word);
            }
        }

        public IEnumerable<string> Words => _words.AsEnumerable().Select(value=> value.Word);

        public Translation? GetTranslation(string translation_Language, string word)
        {
            return _words.Find(value => value.Word == word && value.Translation_Language == translation_Language);
        }

        public List<Translation> GetTranslations(string translation_Language)
        {
            return _words.FindAll(value => value.Translation_Language == translation_Language);
        }
    }
}
