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
        private Language _translated_Language;
        private Language _translation_Language;
        public Translation(Language language1,Language language2, string word,List<string> translations)
        {
            Word = word;
            _translated_Language = language1;
            _translation_Language = language2;
            _translations = translations;
        }

        public string Translated_Language => _translated_Language.Name();
        public string Translation_Language => _translation_Language.Name();
        public IEnumerable<string> Translations => _translations.AsEnumerable();

        public bool TryAddTranslationItem(string item)
        {
            if(_translations.Contains(item)) 
            {
                return false;
            }
            _translations.Add(item);
            return true;
        }
    }
}