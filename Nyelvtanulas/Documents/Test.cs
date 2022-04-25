using Nyelvtanulas.Languages;
using System.Collections.Generic;
using System.Linq;

namespace Nyelvtanulas.Documents
{
    public class Test : Document
    {
        public readonly string Language1;
        public readonly string Language2;
        private List<Word> _language1Words;
        private List<Word> _language2Words;
        public Test(Language language1,Language language2)
        {
            Language1 = language1.Name();
            Language2 = language2.Name();
            _language1Words = language1.PickRandomWords(language2,null);
            List<Word> ExceptionWords = new List<Word>();
            foreach (Word w in _language1Words)
            {
                foreach(Word w2 in w.GetWords(language2))
                {
                    ExceptionWords.Add(w2);
                }
            }
            _language2Words = language2.PickRandomWords(language1,ExceptionWords);
        }

        public IEnumerable<Word> Language1Words => _language1Words.AsEnumerable();
        public IEnumerable<Word> Language2Words => _language2Words.AsEnumerable();
    }
}
