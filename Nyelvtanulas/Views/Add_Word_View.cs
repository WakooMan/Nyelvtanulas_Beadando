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
        private readonly string Translated_Language;
        private readonly string Translation_Language;
        public Add_Word_View(Action<UserControl> setCurrentView,string Translated_Language, string Translation_Language)
        {
            SetCurrentView = setCurrentView;
            this.Translated_Language = Translated_Language;
            this.Translation_Language = Translation_Language;
            this.Data = WordData.Current();
            InitializeComponent();
            Language1_Label.Text = Translated_Language;
            Language2_Label.Text = Translation_Language;
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
                List<string> translations = new List<string>();
                foreach (string item in Translations_ListBox.Items)
                {
                    translations.Add(item);
                }
                Data.AddTranslation(Translated_Language, Translation_Language, Add_Word_TextBox.Text, translations);   
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
