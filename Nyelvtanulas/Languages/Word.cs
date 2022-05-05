using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvtanulas.Languages
{
    public class Word
    {
        private Language _language;
        public readonly string Text;
        private Dictionary<Language,List<Word>> _translations;

        public Word(Language language,string text)
        {
            _language = language;
            Text = text;
            _translations = new Dictionary<Language,List<Word>>();
        }

        public IEnumerable<Word> Translations(Language lang) => _translations[lang].AsEnumerable();
        public Language Language => _language;
        public bool TryAddTranslation(Word Translation)
        {
            Language lang = Translation.Language;
            if (!_translations.ContainsKey(lang))
            {
                _translations.Add(lang, new List<Word>());
            }
            if (_translations[lang].All(translation => translation != Translation))
            {
                _translations[lang].Add(Translation);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
