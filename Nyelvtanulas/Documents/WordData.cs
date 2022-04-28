using Nyelvtanulas.Languages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Nyelvtanulas.Documents
{
    public class WordData
    {
        private Dictionary<string, Language> Languages;
        private List<string> _allWords;
        private readonly string ConnectionString;

        public IEnumerable<string> LanguageNames => Languages.Values.Select(value=> value.Name());
        
        public WordData(string connectionString)
        {
            ConnectionString = connectionString;
            Languages = new Dictionary<string, Language>();
            AddLanguage(new Hungarian());
            AddLanguage(new English());
            LoadFromDataBase();
            _allWords = new List<string>();
            foreach (Language lg in Languages.Values)
            {
                foreach (string word in lg.Words)
                {
                    _allWords.Add(word);
                }
            }
        }
        public void AddTranslation(string Translated_Language,string Translation_Language,string Word,List<string> Translations)
        {
            Translation? translation = Languages[Translated_Language].GetTranslation(Translation_Language, Word);
            if (translation is null)
            {
                translation = new Translation(Languages[Translated_Language], Languages[Translation_Language], Word, Translations);
                Languages[translation.Translated_Language].AddTranslation(translation);
                foreach (string Item in translation.Translations)
                {
                    AddToDatabase(Translated_Language, Translation_Language, Word, Item);
                }
            }
            else
            {
                foreach (string Item in Translations)
                {
                    if (translation.TryAddTranslationItem(Item))
                    {
                        AddToDatabase(Translated_Language,Translation_Language,Word,Item);
                    }
                }
            }
        }

        private void LoadFromDataBase()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Translations;", connection);
                SqlDataReader reader = command.ExecuteReader();
                var list = new List<(string Translated_Language, string Translation_Language, string Word, string TranslationItem)>();
                while (reader.Read())
                {
                    list.Add(((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]));
                }
                var GroupedLists = list.GroupBy(value => new { value.Translated_Language, value.Translation_Language, value.Word }).Select(v => v.ToList()).ToList();
                foreach (var l in GroupedLists)
                {
                    List<string> Translations = new();
                    l.ForEach(v => Translations.Add(v.TranslationItem.ToLower()));
                    Languages[l[0].Translated_Language].AddTranslation(new Translation(Languages[l[0].Translated_Language],Languages[l[0].Translation_Language],l[0].Word.ToLower(),Translations));
                }
            }
        }

        public Test CreateTest(string First_Language,string Second_Language)
        {
            var _firstLanguageWords = Languages[First_Language].PickRandomWords(Languages[Second_Language]);
            var _secondLanguageWords = Languages[Second_Language].PickRandomWords(Languages[First_Language]);
            return new Test(First_Language, Second_Language, _firstLanguageWords, _secondLanguageWords);
        }

        private void AddLanguage(Language lg)
        {
            Languages.Add(lg.Name(), lg);
        }

        private void AddToDatabase(string Translated_Language, string Translation_Language, string Word,string Item)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Translations(Translated_Language,Translation_Language,Translated_Word,Translation) VALUES (@Translated_Lang, @Translation_Lang, @Translated_Word, @Translation);", connection);
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@Translated_Lang", Translated_Language), new SqlParameter("@Translation_Lang", Translation_Language), new SqlParameter("@Translated_Word", Word), new SqlParameter("@Translation", Item) };
                foreach (SqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
                command.ExecuteNonQuery();         
            }
        }

        public IEnumerable<string> GetLanguageWords(string Name)
        {
            try
            {
                return Languages[Name].Words;
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
        }

        public IEnumerable<string> AllWords()
        {
            return _allWords.AsEnumerable();
        }
    }
}
