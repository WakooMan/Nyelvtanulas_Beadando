using Nyelvtanulas.Languages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nyelvtanulas.Documents
{
    public class Test
    {
        public readonly string First_Language;
        public readonly string Second_Language;
        private List<Translation> _firstLanguageWords;
        private List<Translation> _secondLanguageWords;
        public Test(string First_Language,string Second_Language,List<Translation> FirstLanguageWords,List<Translation> SecondLanguageWords)
        {
            this.First_Language = First_Language;
            this.Second_Language = Second_Language;
            this._firstLanguageWords = FirstLanguageWords;
            this._secondLanguageWords = SecondLanguageWords;
        }

        public bool IsGood(int i,string Translated_Word,string Translation_Word)
        {
            Translation? trans = (i==1) ? _firstLanguageWords.Find(v => v.Word == Translated_Word) : _secondLanguageWords.Find(v => v.Word == Translated_Word);
            if (trans is not null)
            {
                return trans.Translations.Any(translation => translation == Translation_Word);
            }
            throw new Exception();
        }
        public IEnumerable<string> FirstLanguageWords => _firstLanguageWords.Select(v => v.Word);
        public IEnumerable<string> SecondLanguageWords => _secondLanguageWords.Select(v => v.Word);
    }
}
