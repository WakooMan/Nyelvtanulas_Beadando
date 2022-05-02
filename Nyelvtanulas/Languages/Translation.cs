using Nyelvtanulas.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Nyelvtanulas.Languages
{
    public class Translation
    {
        public readonly string Word;
        private List<Translation> _translations;
        private List<Translation> _synonyms;
        private Language _translated_Language;
        private Language _translation_Language;
        public Translation(Language language1, Language language2, string word)
        {
            Word = word;
            _translated_Language = language1;
            _translation_Language = language2;
            _translations = new List<Translation>();
            _synonyms = new List<Translation>();
        }

        public bool TryAddSynonym(Translation item)
        {
            if (Word == item.Word || _synonyms.Any(value => value.Word == item.Word))
            {
                return false;
            }
            _synonyms.Add(item);
            return true;
        }

        public string Translated_Language => _translated_Language.Name();
        public string Translation_Language => _translation_Language.Name();
        public IEnumerable<string> Translations => _translations.Select(v => v.Word);
        public IEnumerable<string> Synonyms => _synonyms.Select(v => v.Word);
        public bool TryAddTranslationItem(Translation item)
        {
            if(_translations.Any(value => value.Word == item.Word)) 
            {
                return false;
            }
            _translations.Add(item);
            return true;
        }
    }
}