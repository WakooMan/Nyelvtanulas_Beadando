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
        private readonly List<string> PreviousValues;
        private readonly Dictionary<Control, Rectangle> ControlPercentages;
        private DateTime Date1;
        private DateTime Date2;
        private bool IsClearing = false;

        public InitialView(WordData Data,TestResults Results,Action<UserControl> setCurrentView)
        {
            SetCurrentView = setCurrentView;
            this.Data = Data;
            this.Results = Results;
            InitializeComponent();
            ControlPercentages = new Dictionary<Control, Rectangle>();
            foreach (Control control in Controls)
            {
                ControlPercentages.Add(control,new Rectangle(new Point((int)((double)control.Location.X/Size.Width*100), (int)((double)control.Location.Y / Size.Height*100)),new Size((int)((double)control.Size.Width / Size.Width*100), (int)((double)control.Size.Height / Size.Height*100))));
            }
            PreviousValues = new List<string>();
            foreach (string lg in Data.LanguageNames)
            {
                Add_Language1_ComboBox.Items.Add(lg);
                Add_Language2_ComboBox.Items.Add(lg);
                Check_Language1_ComboBox.Items.Add(lg);
                Check_Language2_ComboBox.Items.Add(lg);
                Export_Translated_Language_ComboBox.Items.Add(lg);
                Export_Translation_Language_ComboBox.Items.Add(lg);
                TestResults_Language1_ComboBox.Items.Add(lg);
                TestResults_Language2_ComboBox.Items.Add(lg);
            }
            Add_Language1_ComboBox.SelectedIndex = 0;
            Add_Language2_ComboBox.SelectedIndex = 0;
            Check_Language1_ComboBox.SelectedIndex = 0;
            Check_Language2_ComboBox.SelectedIndex = 0;
            Export_Translated_Language_ComboBox.SelectedIndex = 0;
            Export_Translation_Language_ComboBox.SelectedIndex = 0;
            TestResults_Language1_ComboBox.SelectedIndex = 0;
            TestResults_Language2_ComboBox.SelectedIndex = 0;
            SetComboBoxLanguageLogic(Add_Language1_ComboBox, Add_Language2_ComboBox);
            SetComboBoxLanguageLogic(Check_Language1_ComboBox, Check_Language2_ComboBox);
            SetComboBoxLanguageLogic(Export_Translated_Language_ComboBox, Export_Translation_Language_ComboBox);
            SetComboBoxLanguageLogic(TestResults_Language1_ComboBox, TestResults_Language2_ComboBox);
            Date1 = TestResults_DateTimePicker1.Value;
            Date2 = TestResults_DateTimePicker2.Value;
            Add_Language1_Label.Parent = Add_Translation_PictureBox;
            Add_Language2_Label.Parent = Add_Translation_PictureBox;
            Check_Language1_Label.Parent =Test_Knowledge_PictureBox;
            Check_Language2_Label.Parent = Test_Knowledge_PictureBox;

        }

        private Action<UserControl> SetCurrentView { get; set; }

        private void Add_Translation_Button_Click(object sender, EventArgs e)
        {
            CheckComboBoxes(Add_Language1_ComboBox, Add_Language2_ComboBox, Add_Language1_Label, Add_Language2_Label, () =>
            {
                SetCurrentView(new Add_Word_View(this, Data, this.SetCurrentView, this.Add_Language1_ComboBox.Text, this.Add_Language2_ComboBox.Text));
                ClearControls();
            });
        }

        private void CheckComboBoxes(ComboBox cb1, ComboBox cb2,Label lb1,Label lb2,Action action)
        {
            if (cb1.Text != "None" && cb2.Text != "None")
            {
                action();
                return;
            }
            string message = "";
            if (cb1.Text == "None")
            {
                message += $"{lb1.Text} can't be None!\n";
            }
            if (cb2.Text == "None")
            {
                message += $"{lb2.Text} can't be None!";
            }
            MessageBox.Show(message);
        }

        private void Check_Knowledge_Button_Click(object sender, EventArgs e)
        {
            CheckComboBoxes(Check_Language1_ComboBox, Check_Language2_ComboBox, Check_Language1_Label, Check_Language2_Label, () => 
            {
                try
                {
                    SetCurrentView(new Test_View(this, Results, SetCurrentView, Data.CreateTest(Check_Language1_ComboBox.Text, Check_Language2_ComboBox.Text)));
                    ClearControls();
                }
                catch (NotEnoughWordException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private void Export_To_Xml_Button_Click(object sender, EventArgs e)
        {
            CheckComboBoxes(Export_Translated_Language_ComboBox, Export_Translation_Language_ComboBox, Export_Translated_Language_Label, Export_Translation_Language_Label, () =>
            {
                FolderBrowserDialog Dialog = new FolderBrowserDialog();
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    Data.ExportToXml(Export_Translated_Language_ComboBox.Text, Export_Translation_Language_ComboBox.Text, Dialog.SelectedPath + Export_FileName_TextBox.Text);
                    MessageBox.Show("Words exported to XML file successfully.");
                    ClearControls();
                }
            });
        }

        private void LanguageComboBoxChangedEvent(int i,ComboBox cb1,ComboBox cb2)
        {
            if (PreviousValues[i] is not null && PreviousValues[i] != "None")
            {
                cb2.Items.Add(PreviousValues[i]);
            }
            if ((string)cb1.SelectedItem != "None")
            {
                cb2.Items.Remove(cb1.SelectedItem);
            }
            PreviousValues[i] = (string)cb1.SelectedItem;
        }

        private void SetComboBoxLanguageLogic(ComboBox cb1,ComboBox cb2)
        {
            PreviousValues.Add("None");
            int i = PreviousValues.Count - 1;
            cb1.SelectedIndexChanged += (sender, e) => 
            {
                LanguageComboBoxChangedEvent(i, cb1, cb2);
            };
            PreviousValues.Add("None");
            int j = PreviousValues.Count - 1;
            cb2.SelectedIndexChanged += (sender, e) =>
            {
                LanguageComboBoxChangedEvent(j, cb2, cb1);
            };
        }

        private void Check_Word_Button_Click(object sender, EventArgs e)
        {
            SetCurrentView(new CheckWords_View(this,Data,SetCurrentView));
            ClearControls();
        }

        private void Test_Results_Button_Click(object sender, EventArgs e)
        {
            CheckComboBoxes(TestResults_Language1_ComboBox, TestResults_Language2_ComboBox, TestResults_Language1_Label, TestResults_Language2_Label, () =>
            {
                SetCurrentView(new TestResults_View(this, Results, SetCurrentView, TestResults_DateTimePicker1.Value, TestResults_DateTimePicker2.Value, TestResults_Language1_ComboBox.Text, TestResults_Language2_ComboBox.Text));
                ClearControls();
            });
        }

        private void ClearControls()
        {
            IsClearing = true;
            DateTime temp = DateTime.Now;
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
                if (control is DateTimePicker)
                {
                    if (((DateTimePicker)control).Value == Date1)
                    {
                        ((DateTimePicker)control).Value = temp;
                    }
                    else
                    {
                        ((DateTimePicker)control).Value = temp;
                    }
                }
            }
            IsClearing = false;
        }

        private void InitialView_Resize(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Location = new Point(Size.Width * ControlPercentages[control].X/100,Size.Height * ControlPercentages[control].Y/100);
                control.Size = new Size(Size.Width * ControlPercentages[control].Width/100, Size.Height * ControlPercentages[control].Height/100);
            }
        }

        private void TestResults_DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (TestResults_DateTimePicker1.Value <= TestResults_DateTimePicker2.Value || IsClearing)
            {
                Date1 = TestResults_DateTimePicker1.Value;
            }
            else
            {
                MessageBox.Show("First date should be before the second date!");
                TestResults_DateTimePicker1.Value = Date1;
            }
        }

        private void TestResults_DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (TestResults_DateTimePicker2.Value >= TestResults_DateTimePicker1.Value || IsClearing)
            {
                Date2 = TestResults_DateTimePicker2.Value;
            }
            else
            {
                MessageBox.Show("Second date should be after the first date!");
                TestResults_DateTimePicker2.Value = Date2;
            }
        }
    }
}
