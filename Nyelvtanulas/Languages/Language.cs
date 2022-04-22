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
        private List<Word> Words;
        public abstract string Name();

        protected Language()
        {
            Words = new List<Word>();
        }

        public bool IsThisLanguage(Language OtherLanguage)
        {
            return Name() == OtherLanguage.Name();
        }

        public Dictionary<Word, Word> PickRandomWords(Language OtherLanguage)
        { 
            Dictionary<Word,Word> result = new Dictionary<Word,Word>();
            List<Word> ValidWords = Words.Where(value => value.HasLanguage(OtherLanguage)).ToList();
            if (ValidWords.Count < 5)
            {
                throw new NotEnoughWordException();
            }
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Word temp = ValidWords[rnd.Next(0, ValidWords.Count - 1)];
                ValidWords.Remove(temp);
                result.Add(temp,temp.GetWord(OtherLanguage));
            }
            return result;
        }

        public void AddWord(Word word)
        {
            if (Words.Find(value => value.Text == word.Text) == null)
            {
                Words.Add(word);
            }
            else
            {
                throw new WordAlreadyAddedException();
            }
        }

    }
}
