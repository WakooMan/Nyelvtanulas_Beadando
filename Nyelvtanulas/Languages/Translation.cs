using Nyelvtanulas.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nyelvtanulas.Languages
{
    public class Translation
    {
        public readonly string Word;
        private List<string> _translations;
        private Language _language1;
        private Language _language2;
        public Translation(Language language1,Language language2, string word,List<string> translations)
        {
            Word = word;
            _language1 = language1;
            _language2 = language2;
            _translations = translations;
        }

        public string Language1 => _language1.Name();
        public string Language2 => _language2.Name();
        public IEnumerable<string> Translations => _translations.AsEnumerable();

        public void AddTranslationItem(string item)
        {
            if(!_translations.Contains(item)) 
            {
               _translations.Add(item); 
            }
        }
    }
}