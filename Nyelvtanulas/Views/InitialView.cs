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
    public partial class InitialView : UserControl,IView
    {
        private WordData Data;
        private string[] PreviousValues;
        public InitialView(Action<UserControl> setCurrentView)
        {
            SetCurrentView = setCurrentView;
            Data = WordData.Current();
            InitializeComponent();
            PreviousValues = new string[4];
            foreach (string lg in Data.LanguageNames)
            {
                Add_Language1_ComboBox.Items.Add(lg);
                Add_Language2_ComboBox.Items.Add(lg);
                Check_Language1_ComboBox.Items.Add(lg);
                Check_Language2_ComboBox.Items.Add(lg);
            }
            Add_Language1_ComboBox.SelectedIndex = 0;
            Add_Language2_ComboBox.SelectedIndex = 0;
            Check_Language1_ComboBox.SelectedIndex = 0;
            Check_Language2_ComboBox.SelectedIndex = 0;
        }

        public Action<UserControl> SetCurrentView { get; private set; }

        public void OnUpdate()
        {
            throw new NotImplementedException();
        }

        private void Add_Translation_Button_Click(object sender, EventArgs e)
        {

            Add_Word_View View = new Add_Word_View(this.SetCurrentView,this.Add_Language1_ComboBox.Text,this.Add_Language2_ComboBox.Text);
            SetCurrentView(View);
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
    }
}
