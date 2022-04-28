using Nyelvtanulas.Languages;
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

        public IEnumerable<string> FirstLanguageWords => _firstLanguageWords.Select(v => v.Word);
        public IEnumerable<string> SecondLanguageWords => _secondLanguageWords.Select(v => v.Word);
    }
}
