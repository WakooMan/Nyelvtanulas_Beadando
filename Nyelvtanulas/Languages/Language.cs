using Nyelvtanulas.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvtanulas.Languages
{
    public abstract class Language
    {
        private List<Word> _words;
        public abstract string Name();

        protected Language()
        {
            _words = new List<Word>();
        }

        public bool IsThisLanguage(Language OtherLanguage)
        {
            return Name() == OtherLanguage.Name();
        }

        public List<Word> PickRandomWords(Language OtherLanguage,List<Word>? Exceptions)
        { 
            List<Word> result = new List<Word>();
            List<Word> ValidWords = _words.Where(value => value.HasLanguage(OtherLanguage)&&(Exceptions is null || !Exceptions.Contains(value))).ToList();
            if (ValidWords.Count < 5)
            {
                throw new NotEnoughWordException();
            }
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Word temp = ValidWords[rnd.Next(0, ValidWords.Count - 1)];
                ValidWords.Remove(temp);
                result.Add(temp);
            }
            return result;
        }

        public void AddWord(Word word)
        {
            if (_words.Find(value => value.Text == word.Text) == null)
            {
                _words.Add(word);
            }
            else
            {
                throw new WordAlreadyAddedException();
            }
        }

        public IEnumerable<Word> Words => _words.AsEnumerable();

    }
}
