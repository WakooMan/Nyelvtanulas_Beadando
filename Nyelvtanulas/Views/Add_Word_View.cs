using Nyelvtanulas.Documents;
using Nyelvtanulas.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nyelvtanulas.Views
{
    public partial class Add_Word_View : UserControl,IView
    {
        private WordData Data;
        private string Language1;
        private string Language2;
        public Add_Word_View(Action<UserControl> setCurrentView,string Language1,string Language2)
        {
            SetCurrentView = setCurrentView;
            this.Language1 = Language1;
            this.Language2 = Language2;
            this.Data = WordData.Current();
            InitializeComponent();
        }

        public Action<UserControl> SetCurrentView { get; private set; }

        public void OnUpdate()
        {
            throw new NotImplementedException();
        }

        private void Add_Translations_Button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Add_Word_TextBox.Text) && Translations_ListBox.Items.Count != 0)
            {
                Translation? word = Data.GetLanguageWords(Language1).ToList().Find(value => value.Word == Add_Word_TextBox.Text);
                if (word is null)
                {
                    List<string> translations = new List<string>();
                    foreach (string item in Translations_ListBox.Items)
                    {
                        translations.Add(item);
                    }
                    word = new Translation(Data.GetLanguage(Language1), Data.GetLanguage(Language2), Add_Word_TextBox.Text, translations);
                    Data.GetLanguage(Language1).AddTranslation(word);
                }
                else
                {
                    foreach (string item in Translations_ListBox.Items)
                    {
                        word.AddTranslationItem(item);
                    }
                }
                InitialView View = new InitialView(this.SetCurrentView);
                SetCurrentView(View);
            }
            else
            {
                string message = "";
                if (String.IsNullOrEmpty(Add_Word_TextBox.Text))
                {
                    message += "You didn't give the word you want to translate!\n";
                }
                if (Translations_ListBox.Items.Count == 0)
                {
                    message += "You didn't give any translation to me!";
                }
                MessageBox.Show(message);
            }
        }

        private void Add_Translation_Button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Add_Translation_TextBox.Text) && !Translations_ListBox.Items.Contains(Add_Translation_TextBox.Text))
            {
                Translations_ListBox.Items.Add(Add_Translation_TextBox.Text);
            }
            else
            {
                string message = "";
                if (String.IsNullOrEmpty(Add_Translation_TextBox.Text))
                {
                    message += "You didn't write anything in the textbox!\n";
                }
                if (Translations_ListBox.Items.Contains(Add_Translation_TextBox.Text))
                {
                    message += "The list contains the same item!";
                }
                MessageBox.Show(message);
            }
        }
    }
}
