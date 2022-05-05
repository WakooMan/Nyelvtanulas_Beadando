using Nyelvtanulas.Documents;
using Nyelvtanulas.Exceptions;
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
    public partial class InitialView : UserControl
    {
        private readonly WordData Data;
        private readonly TestResults Results;
        private string[] PreviousValues;
        public InitialView(WordData Data,TestResults Results,Action<UserControl> setCurrentView)
        {
            SetCurrentView = setCurrentView;
            this.Data = Data;
            this.Results = Results;
            InitializeComponent();
            PreviousValues = new string[6];
            foreach (string lg in Data.LanguageNames)
            {
                Add_Language1_ComboBox.Items.Add(lg);
                Add_Language2_ComboBox.Items.Add(lg);
                Check_Language1_ComboBox.Items.Add(lg);
                Check_Language2_ComboBox.Items.Add(lg);
                Export_Translated_Language_ComboBox.Items.Add(lg);
                Export_Translation_Language_ComboBox.Items.Add(lg);
            }
            Add_Language1_ComboBox.SelectedIndex = 0;
            Add_Language2_ComboBox.SelectedIndex = 0;
            Check_Language1_ComboBox.SelectedIndex = 0;
            Check_Language2_ComboBox.SelectedIndex = 0;
            Export_Translated_Language_ComboBox.SelectedIndex = 0;
            Export_Translation_Language_ComboBox.SelectedIndex = 0;
        }

        private Action<UserControl> SetCurrentView { get; set; }

        private void Add_Translation_Button_Click(object sender, EventArgs e)
        {
            if (Add_Language1_ComboBox.Text != "None" && Add_Language2_ComboBox.Text != "None")
            {
                SetCurrentView(new Add_Word_View(this,Data, this.SetCurrentView, this.Add_Language1_ComboBox.Text, this.Add_Language2_ComboBox.Text));
                return;
            }
            string message = "";
            if(Add_Language1_ComboBox.Text == "None")
            {
                message += "Translated Language can't be None!\n";
            }
            if(Add_Language2_ComboBox.Text == "None")
            {
                message += "Translation Language can't be None!";
            }
            MessageBox.Show(message);
        }

        private void Add_Language1_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PreviousValues[0] is not null && PreviousValues[0]!= "None")
            {
                Add_Language2_ComboBox.Items.Add(PreviousValues[0]);
            }
            if ((string)Add_Language1_ComboBox.SelectedItem != "None") 
            {
                Add_Language2_ComboBox.Items.Remove(Add_Language1_ComboBox.SelectedItem); 
            }
            PreviousValues[0] = (string)Add_Language1_ComboBox.SelectedItem;
        }

        private void Add_Language2_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PreviousValues[1] is not null && PreviousValues[1] != "None")
            {
                Add_Language1_ComboBox.Items.Add(PreviousValues[1]);
            }
            if ((string)Add_Language2_ComboBox.SelectedItem != "None")
            {
                Add_Language1_ComboBox.Items.Remove(Add_Language2_ComboBox.SelectedItem);
            }
            PreviousValues[1] = (string)Add_Language2_ComboBox.SelectedItem;
        }

        private void Check_Language1_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PreviousValues[2] is not null && PreviousValues[2] != "None")
            {
                Check_Language2_ComboBox.Items.Add(PreviousValues[2]);
            }
            if ((string)Check_Language1_ComboBox.SelectedItem != "None")
            {
                Check_Language2_ComboBox.Items.Remove(Check_Language1_ComboBox.SelectedItem);
            }
            PreviousValues[2] = (string)Check_Language1_ComboBox.SelectedItem;
        }

        private void Check_Language2_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PreviousValues[3] is not null && PreviousValues[3] != "None")
            {
                Check_Language1_ComboBox.Items.Add(PreviousValues[3]);
            }
            if ((string)Check_Language2_ComboBox.SelectedItem != "None")
            {
                Check_Language1_ComboBox.Items.Remove(Check_Language2_ComboBox.SelectedItem);
            }
            PreviousValues[3] = (string)Check_Language2_ComboBox.SelectedItem;
        }

        private void Check_Knowledge_Button_Click(object sender, EventArgs e)
        {
            if (Check_Language1_ComboBox.Text != "None" && Check_Language2_ComboBox.Text != "None")
            {
                try
                { 
                    SetCurrentView(new Test_View(this,Results,SetCurrentView, Data.CreateTest(Check_Language1_ComboBox.Text, Check_Language2_ComboBox.Text)));
                    return;
                }
                catch(NotEnoughWordException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            string message = "";
            if (Check_Language1_ComboBox.Text == "None")
            {
                message += "First Language can't be None!\n";
            }
            if (Check_Language2_ComboBox.Text == "None")
            {
                message += "Second Language can't be None!";
            }
            MessageBox.Show(message);
        }

        private void Export_To_Xml_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialog = new FolderBrowserDialog();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Data.ExportToXml(Export_Translated_Language_ComboBox.Text,Export_Translation_Language_ComboBox.Text,Dialog.SelectedPath+Export_FileName_TextBox.Text);
                MessageBox.Show("Words exported to XML file successfully.");
            }
        }

        private void Export_Translated_Language_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PreviousValues[4] is not null && PreviousValues[4] != "None")
            {
                Export_Translation_Language_ComboBox.Items.Add(PreviousValues[4]);
            }
            if ((string)Add_Language2_ComboBox.SelectedItem != "None")
            {
                Export_Translation_Language_ComboBox.Items.Remove(Export_Translated_Language_ComboBox.SelectedItem);
            }
            PreviousValues[4] = (string)Export_Translated_Language_ComboBox.SelectedItem;
        }

        private void Export_Translation_Language_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PreviousValues[5] is not null && PreviousValues[5] != "None")
            {
                Export_Translated_Language_ComboBox.Items.Add(PreviousValues[5]);
            }
            if ((string)Add_Language2_ComboBox.SelectedItem != "None")
            {
                Export_Translated_Language_ComboBox.Items.Remove(Export_Translation_Language_ComboBox.SelectedItem);
            }
            PreviousValues[5] = (string)Export_Translation_Language_ComboBox.SelectedItem;
        }

        private void Check_Word_Button_Click(object sender, EventArgs e)
        {
            SetCurrentView(new CheckWords_View(this,Data,SetCurrentView));
        }
    }
}
