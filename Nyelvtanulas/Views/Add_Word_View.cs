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
    public partial class Add_Word_View : UserControl
    {
        private WordData Data;
        private readonly string Translated_Language;
        private readonly string Translation_Language;
        private readonly InitialView View;
        private readonly Dictionary<Control, Rectangle> ControlPercentages;

        public Add_Word_View(InitialView View,WordData Data,Action<UserControl> setCurrentView,string Translated_Language, string Translation_Language)
        {
            this.View = View;
            SetCurrentView = setCurrentView;
            this.Translated_Language = Translated_Language;
            this.Translation_Language = Translation_Language;
            this.Data = Data;
            InitializeComponent();
            ControlPercentages = new Dictionary<Control, Rectangle>();
            foreach (Control control in Controls)
            {
                ControlPercentages.Add(control, new Rectangle(new Point((int)((double)control.Location.X / Size.Width * 100), (int)((double)control.Location.Y / Size.Height * 100)), new Size((int)((double)control.Size.Width / Size.Width * 100), (int)((double)control.Size.Height / Size.Height * 100))));
            }
            Language1_Label.Text = Translated_Language;
            Language2_Label.Text = Translation_Language;
        }

        private Action<UserControl> SetCurrentView { get; set; }

        private void Add_Translations_Button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Add_Word_TextBox.Text) && Translations_ListBox.Items.Count != 0)
            {
                List<string> translations = new List<string>();
                foreach (string item in Translations_ListBox.Items)
                {
                    translations.Add(item);
                }
                Data.AddTranslation(Translated_Language, Translation_Language, Add_Word_TextBox.Text.ToLower(), translations);
                Add_Translation_TextBox.Text = "";
                Add_Word_TextBox.Text = "";
                Translations_ListBox.Items.Clear();
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
            if (!String.IsNullOrEmpty(Add_Translation_TextBox.Text) && !Translations_ListBox.Items.Contains(Add_Translation_TextBox.Text.ToLower()))
            {
                Translations_ListBox.Items.Add(Add_Translation_TextBox.Text.ToLower());
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

        private void Back_To_Menu_Button_Click(object sender, EventArgs e)
        {
            SetCurrentView(View);
        }

        private void Delete_Translation_Button_Click(object sender, EventArgs e)
        {
            if (Translations_ListBox.SelectedItem == null)
            {
                MessageBox.Show("You didn't select any translation word to delete.");
                return;
            }
            Translations_ListBox.Items.Remove(Translations_ListBox.SelectedItem);
        }

        private void Add_Word_View_Resize(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Location = new Point(Size.Width * ControlPercentages[control].X / 100, Size.Height * ControlPercentages[control].Y / 100);
                control.Size = new Size(Size.Width * ControlPercentages[control].Width / 100, Size.Height * ControlPercentages[control].Height / 100);
            }
        }
    }
}
