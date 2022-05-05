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
        public XmlTranslation(Language lang,Word trans)
        {
            Word = trans.Text;
            Translations = new List<string>();
            foreach (Word w in trans.Translations(lang))
            {
                Translations.Add(w.Text);
            }
        }
        public XmlTranslation()
        { }
    }
}