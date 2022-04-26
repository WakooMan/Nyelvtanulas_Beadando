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
        private List<Translation> _words;
        public abstract string Name();

        protected Language()
        {
            _words = new List<Translation>();
        }

        public bool IsThisLanguage(Language OtherLanguage)
        {
            return Name() == OtherLanguage.Name();
        }

        public List<Translation> PickRandomWords(Language OtherLanguage,List<string>? Exceptions)
        { 
            List<Translation> result = new List<Translation>();
            List<Translation> ValidWords = _words.Where(value => value.Language2 == OtherLanguage.Name() && (Exceptions is null || !Exceptions.Contains(value.Word))).ToList();
            if (ValidWords.Count < 5)
            {
                throw new NotEnoughWordException();
            }
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Translation temp = ValidWords[rnd.Next(0, ValidWords.Count - 1)];
                ValidWords.Remove(temp);
                result.Add(temp);
            }
            return result;
        }

        public void AddTranslation(Translation word)
        {
            if (_words.All(value => value != word))
            {
                _words.Add(word);
            }
        }

        public IEnumerable<Translation> Words => _words.AsEnumerable();

    }
}
