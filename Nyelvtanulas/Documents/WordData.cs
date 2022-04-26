using Nyelvtanulas.Languages;
using System.Collections.Generic;
using System.Linq;

namespace Nyelvtanulas.Documents
{
    public class WordData : Document
    {
        private Dictionary<string, Language> Languages;
        private List<Translation> _allWords;

        private static WordData? current= null;
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
            Languages = new Dictionary<string, Language>();
            Languages.Add(Hungarian.Current().Name(), Hungarian.Current());
            Languages.Add(English.Current().Name(), English.Current());
            _allWords = new List<Translation>();
            foreach (Language lg in Languages.Values)
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
                return Languages[Name];
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
                return Languages[Name].Words;
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
