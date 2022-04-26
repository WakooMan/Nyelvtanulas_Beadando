using Nyelvtanulas.Languages;
using System.Collections.Generic;
using System.Linq;

namespace Nyelvtanulas.Documents
{
    public class WordData : Document
    {
        private Dictionary<string, Language> languages;
        private List<Translation> _allWords;

        private static WordData? current= null;

        public IEnumerable<Language> Languages => languages.Values;
        public static WordData Current()
        {
            if (current is null)
            {
                current = new WordData();
            }
            return current;
        }
        private WordData()
        {
            languages = new Dictionary<string, Language>();
            languages.Add(Hungarian.Current().Name(), Hungarian.Current());
            languages.Add(English.Current().Name(), English.Current());
            _allWords = new List<Translation>();
            foreach (Language lg in languages.Values)
            {
                foreach (Translation word in lg.Words)
                {
                    _allWords.Add(word);
                }
            }
        }

        public Language GetLanguage(string Name)
        {
            try
            {
                return languages[Name];
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
        }

        public IEnumerable<Translation> GetLanguageWords(string Name)
        {
            try
            {
                return languages[Name].Words;
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
        }

        public IEnumerable<Translation> AllWords()
        {
            return _allWords.AsEnumerable();
        }
    }
}
