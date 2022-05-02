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
        private List<string> _allWords;
        private readonly string ConnectionString;
        private bool LoadingFromDatabase = false;
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
                translation = new Translation(Languages[Translated_Language], Languages[Translation_Language], Word);
                Languages[translation.Translated_Language].AddTranslation(translation);
            }
            List<Translation> translations = new List<Translation>();
            foreach (string trans in Translations)
            {
                Translation? tr = Languages[Translation_Language].GetTranslation(Translated_Language,trans);
                if (tr is null)
                {
                    tr = new Translation(Languages[Translation_Language], Languages[Translated_Language], trans);
                    Languages[tr.Translated_Language].AddTranslation(tr);
                }
                translations.Add(tr);
            }
            foreach (Translation tr in translations)
            {
                if (translation.TryAddTranslationItem(tr) && !LoadingFromDatabase)
                { 
                    AddTranslationToDatabase(Translated_Language, Translation_Language, translation.Word, tr.Word);
                }
                if (tr.TryAddTranslationItem(translation)&& !LoadingFromDatabase)
                {
                    AddTranslationToDatabase(Translation_Language, Translated_Language, tr.Word, translation.Word);
                }
                translations.ForEach(value => tr.TryAddSynonym(value));
            }
        }

        private void LoadFromDataBase()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                LoadingFromDatabase = true;
                List<Translation> AllTranslation = new List<Translation>();
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
                    AddTranslation(l[0].Translated_Language,l[0].Translation_Language,l[0].Word,Translations);
                }
                LoadingFromDatabase = false;
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
            var obj = new XmlExporter(Translated_Language, Translation_Language,Languages[Translated_Language].GetTranslations(Translation_Language));
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
            return _allWords.AsEnumerable();
        }
    }
}
