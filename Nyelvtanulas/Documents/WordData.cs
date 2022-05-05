using Nyelvtanulas.Languages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Nyelvtanulas.Documents
{
    public class WordData
    {
        private Dictionary<string, Language> Languages;
        private readonly string ConnectionString;
        public IEnumerable<string> LanguageNames => Languages.Values.Select(value=> value.Name());
        
        public WordData(string connectionString)
        {
            ConnectionString = connectionString;
            Languages = new Dictionary<string, Language>();
            AddLanguage(new Hungarian());
            AddLanguage(new English());
            LoadFromDataBase();
        }
        public void AddTranslation(string Translated_Language,string Translation_Language,string Word,List<string> Translations)
        {
            Word? word = Languages[Translated_Language].GetWord(Word);
            List<Word> translations = new List<Word>();
            if (word is null)
            {
                word = Languages[Translated_Language].AddWord(Word);
            }
            foreach (string trans in Translations)
            {
                Word? tr = Languages[Translation_Language].GetWord(trans);
                if (tr is null)
                {
                    tr = Languages[Translation_Language].AddWord(trans);
                }
                translations.Add(tr);
            }

            //Add Translations
            foreach (Word tr in translations)
            {
                if(word.TryAddTranslation(tr))
                {
                    AddTranslationToDatabase(Translated_Language, Translation_Language, word.Text, tr.Text);
                }
                if (tr.TryAddTranslation(word))
                {
                    AddTranslationToDatabase(Translation_Language, Translated_Language, tr.Text, word.Text);
                }
            }
        }

        private void LoadTranslation(string Translated_Language, string Translation_Language, string Word, string Translation)
        {
            Word? word = Languages[Translated_Language].GetWord(Word);
            Word? translation = Languages[Translation_Language].GetWord(Translation);
            if (word is null)
            {
                word = Languages[Translated_Language].AddWord(Word);
            }
            if (translation is null)
            {
                translation = Languages[Translation_Language].AddWord(Translation);
            }
            word.TryAddTranslation(translation);
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
                    l.ForEach(v => LoadTranslation(v.Translated_Language, v.Translation_Language, v.Word, v.TranslationItem));
                }
            }
        }

        public Test CreateTest(string First_Language,string Second_Language)
        {
            var _firstLanguageWords = Languages[First_Language].PickRandomWords(Languages[Second_Language]);
            var _secondLanguageWords = Languages[Second_Language].PickRandomWords(Languages[First_Language]);
            return new Test(Languages[First_Language], Languages[Second_Language], _firstLanguageWords, _secondLanguageWords);
        }

        private void AddLanguage(Language lg)
        {
            Languages.Add(lg.Name(), lg);
        }

        private void AddTranslationToDatabase(string Translated_Language, string Translation_Language, string Word,string Item)
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

        public void ExportToXml(string Translated_Language, string Translation_Language, string filepath)
        {
            var ser = new XmlSerializer(typeof(XmlExporter));
            var obj = new XmlExporter(Languages[Translated_Language], Languages[Translation_Language],Languages[Translated_Language].GetWords(Languages[Translation_Language]));
            using (XmlWriter xw = XmlWriter.Create(new StreamWriter(filepath)))
            {
                ser.Serialize(xw, obj);
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
            var list = new List<string>();
            foreach (Language lang in Languages.Values)
            {
                list.AddRange(lang.Words);
            }
            return list.AsEnumerable();
        }
    }
}
