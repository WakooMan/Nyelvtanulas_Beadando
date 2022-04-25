using Nyelvtanulas.Languages;
using System.Collections.Generic;
using System.Linq;

namespace Nyelvtanulas.Documents
{
    public class WordData : Document
    {
        private Dictionary<string, Language> Languages;
        private List<Word> _allWords;
        public WordData()
        {
            Languages = new Dictionary<string, Language>();
            Languages.Add(Hungarian.Current().Name(), Hungarian.Current());
            Languages.Add(English.Current().Name(), English.Current());
            _allWords = new List<Word>();
            foreach (Language lg in Languages.Values)
            {
                foreach (Word word in lg.Words)
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

        public IEnumerable<Word> GetLanguageWords(string Name)
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

        public IEnumerable<Word> AllWords()
        {
            return _allWords.AsEnumerable();
        }
    }
}
