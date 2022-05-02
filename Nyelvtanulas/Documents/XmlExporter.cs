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

        public XmlExporter(string translated_Language,string translation_Language,List<Translation> translations)
        {
            Translated_Language = translated_Language;
            Translation_Language = translation_Language;
            Translations = new List<XmlTranslation>();
            foreach (Translation trans in translations)
            {
                Translations.Add(new XmlTranslation(trans));
            }
        }

        public XmlExporter()
        { }

    }
}
