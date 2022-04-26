using Nyelvtanulas.Documents;
using Nyelvtanulas.Languages;
using Nyelvtanulas.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nyelvtanulas
{
    public partial class Add_Word_View : Form,IView
    {
        private readonly NyelvtanulasForm nyelvtanulas;
        private WordData Data => nyelvtanulas.Data;
        private readonly string Language1;
        private readonly string Language2;

        public Add_Word_View(NyelvtanulasForm nyelvtanulas,string language1,string language2)
        {
            InitializeComponent();
            this.nyelvtanulas = nyelvtanulas;
            Language1 = language1;
            Language2 = language2;
        }

        public void OnUpdate()
        {
            throw new NotImplementedException();
        }

        private void Add_Synonym_btn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Add_Synonym_tb.Text)&&!Synonym_lb.Items.Contains(Add_Synonym_tb.Text))
            {
                Synonym_lb.Items.Add(Add_Synonym_tb.Text);
            }
            else
            {
                string message = "";
                if(String.IsNullOrEmpty(Add_Synonym_tb.Text))
                {
                    message += "You didn't write anything in the textbox!\n";
                }
                if (Synonym_lb.Items.Contains(Add_Synonym_tb.Text)) 
                {
                    message += "The list contains the same item!"; 
                }
                MessageBox.Show(message);
            }
        }

        private void Add_Word_btn2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Add_Word_tb.Text) && Synonym_lb.Items.Count != 0)
            {
                Translation? word = Data.GetLanguageWords(Language1).ToList().Find(value => value.Word == Add_Word_tb.Text);
                if (word is null)
                {
                    List<string> translations = new List<string>();
                    foreach (string item in Synonym_lb.Items)
                    {
                        translations.Add(item);
                    }
                    word = new Translation(Data.GetLanguage(Language1), Data.GetLanguage(Language2), Add_Word_tb.Text, translations);
                    Data.GetLanguage(Language1).AddTranslation(word);
                }
                else
                {
                    foreach (string item in Synonym_lb.Items)
                    {
                        word.AddTranslationItem(item);
                    }
                }
                nyelvtanulas.Show();
                Hide();
            }
            else
            {
                string message = "";
                if(String.IsNullOrEmpty(Add_Word_tb.Text))
                {
                    message += "You didn't give the word you want to translate!\n";
                }
                if (Synonym_lb.Items.Count == 0)
                {
                    message += "You didn't give any translation to me!";
                }
                MessageBox.Show(message);
            }
        }
    }
}
