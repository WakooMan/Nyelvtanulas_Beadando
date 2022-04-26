using Nyelvtanulas.Languages;
using System.Collections.Generic;
using System.Linq;

namespace Nyelvtanulas.Documents
{
    public class Test : Document
    {
        public readonly string Language1;
        public readonly string Language2;
        private List<Translation> _language1Words;
        private List<Translation> _language2Words;
        public Test(Language language1,Language language2)
        {
            Language1 = language1.Name();
            Language2 = language2.Name();
            _language1Words = language1.PickRandomWords(language2,null);
            List<string> ExceptionWords = new List<string>();
            foreach (Translation trans in _language1Words)
            {
                foreach(string translation in trans.Translations)
                {
                    ExceptionWords.Add(translation);
                }
            }
            _language2Words = language2.PickRandomWords(language1,ExceptionWords);
        }

        public IEnumerable<Translation> Language1Words => _language1Words.AsEnumerable();
        public IEnumerable<Translation> Language2Words => _language2Words.AsEnumerable();
    }
}
