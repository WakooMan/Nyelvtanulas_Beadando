using Nyelvtanulas.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Nyelvtanulas.Documents
{
    public class XmlExporter
    {
        [XmlElement("Translated Language")]
        public string Translated_Language { get; set; }
        [XmlElement("Translation Language")]
        public string Translation_Language { get; set; }
        [XmlElement("Translation")]
        public List<XmlTranslation> Translations { get; set; }

        public XmlExporter(Language translated_Language,Language translation_Language,List<Word> translations)
        {
            Translated_Language = translated_Language.Name();
            Translation_Language = translation_Language.Name();
            Translations = new List<XmlTranslation>();
            foreach (Word trans in translations)
            {
                Translations.Add(new XmlTranslation(translation_Language,trans));
            }
        }

        public XmlExporter()
        { }

    }
}
