using Nyelvtanulas.Languages;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nyelvtanulas.Documents
{
    public class XmlTranslation
    {
        [XmlElement("Word")]
        public string Word { get; set; }
        [XmlElement("Translation")]
        public List<string> Translations { get; set; }
        public XmlTranslation(Translation trans)
        {
            Word = trans.Word;
            Translations = new List<string>();
            foreach (var translation in trans.Translations)
            {
                Translations.Add(translation);
            }
        }
        public XmlTranslation()
        { }
    }
}