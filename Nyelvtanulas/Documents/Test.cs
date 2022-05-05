using Nyelvtanulas.Languages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nyelvtanulas.Documents
{
    public class Test
    {
        private Language _first_Language;
        private Language _second_Language;
        public string First_Language => _first_Language.Name();
        public string Second_Language => _second_Language.Name();
        private List<Word> _firstLanguageWords;
        private List<Word> _secondLanguageWords;
        public Test(Language First_Language,Language Second_Language,List<Word> FirstLanguageWords,List<Word> SecondLanguageWords)
        {
            this._first_Language = First_Language;
            this._second_Language = Second_Language;
            this._firstLanguageWords = FirstLanguageWords;
            this._secondLanguageWords = SecondLanguageWords;
        }

        public bool IsGood(int i,string Translated_Word,string Translation_Word)
        {
            Word? trans = (i==1) ? _firstLanguageWords.Find(v => v.Text == Translated_Word) : _secondLanguageWords.Find(v => v.Text == Translated_Word);
            if (trans is not null)
            {
                return trans.Translations((i==1)?_second_Language:_first_Language).Any(translation => translation.Text.ToLower().Ekezettelenit() == Translation_Word.ToLower().Ekezettelenit());
            }
            throw new Exception();
        }
        public IEnumerable<string> FirstLanguageWords => _firstLanguageWords.Select(v => v.Text);
        public IEnumerable<string> SecondLanguageWords => _secondLanguageWords.Select(v => v.Text);
    }
}
