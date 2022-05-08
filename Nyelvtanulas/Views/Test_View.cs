using Nyelvtanulas.Documents;
using Nyelvtanulas.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nyelvtanulas.Views
{
    public partial class Test_View : UserControl
    {
        private readonly Test Test;
        private readonly List<TestObject> LanguageObjects;
        private readonly InitialView View;
        private readonly TestResults Results;
        private Action<UserControl> SetCurrentView { get; set; }
        private readonly Dictionary<Control, Rectangle> ControlPercentages;

        public Test_View(InitialView View, TestResults Results,Action<UserControl> SetCurrentView, Test test)
        {
            Test = test;
            this.SetCurrentView = SetCurrentView;
            this.View = View;
            this.Results = Results;
            LanguageObjects = new();
            InitializeComponent();
            AddTestObjects();
            ControlPercentages = new Dictionary<Control, Rectangle>();
            foreach (Control control in Controls)
            {
                ControlPercentages.Add(control, new Rectangle(new Point((int)((double)control.Location.X / Size.Width * 100), (int)((double)control.Location.Y / Size.Height * 100)), new Size((int)((double)control.Size.Width / Size.Width * 100), (int)((double)control.Size.Height / Size.Height * 100))));
            }
            Translated_Language1_Label.Text = Test.First_Language;
            Translation_Language1_Label.Text = Test.First_Language;
            Translated_Language2_Label.Text = Test.Second_Language;
            Translation_Language2_Label.Text = Test.Second_Language;
        }

        private void AddTestObjects()
        {
            int j = 1;
            foreach (string Word in Test.FirstLanguageWords)
            {
                LanguageObjects.Add(CreateTestObject(1, j, Word));
                j++;
            }
            j = 1;
            foreach (string Word in Test.SecondLanguageWords)
            {
                LanguageObjects.Add(CreateTestObject(2,j,Word));
                j++;
            }
        }

        private TestObject CreateTestObject(int i, int j,string Word)
        {
            Label WordLabel = new Label();
            Label SeparatorLabel = new Label();
            TextBox TextBox = new TextBox();
            Label TickLabel = new Label();
            Label CrossLabel = new Label();

            //WordLabel Init
            WordLabel.AutoSize = true;
            WordLabel.Location = (i==1)?new System.Drawing.Point(20, 153 + (j - 1) * 55) : new System.Drawing.Point(417, 153 + (j-1)* 55);
            WordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            WordLabel.Name = $"Language{i}_Word{j}_Label";
            WordLabel.Size = new System.Drawing.Size(66, 25);
            WordLabel.TabIndex = (((i-1)*5 + j-1)*3)+1 + 3;
            WordLabel.Text = Word;
            WordLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            WordLabel.ForeColor = Color.White;
            this.Controls.Add(WordLabel);

            //SeparatorLabel Init
            SeparatorLabel.AutoSize = true;
            SeparatorLabel.Location = (i==1)?new System.Drawing.Point(164, 153 + (j - 1) * 55): new System.Drawing.Point(590, 153 + (j - 1) * 55);
            SeparatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            SeparatorLabel.Name = $"Language{i}_Word{j}_Separator_Label";
            SeparatorLabel.Size = new System.Drawing.Size(19, 25);
            SeparatorLabel.TabIndex = (((i - 1) * 5 + j - 1) * 3) + 2 +3;
            SeparatorLabel.Text = "-";
            SeparatorLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            SeparatorLabel.ForeColor = Color.White;
            this.Controls.Add(SeparatorLabel);

            //TextBox Init
            TextBox.Location = (i==1)? new System.Drawing.Point(231, 148 + (j - 1) * 55): new System.Drawing.Point(670, 148 + (j - 1) * 55);
            TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBox.Name = $"Language{i}_Word{j}_TextBox";
            TextBox.Size = new System.Drawing.Size(143, 31);
            TextBox.TabIndex = (((i - 1) * 5 + j - 1) * 3) + 3 +3;
            TextBox.BackColor = Color.Yellow;
            TextBox.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            TextBox.ForeColor = Color.Green;
            this.Controls.Add(TextBox);

            //TickLabel Init
            TickLabel.AutoSize = true;
            TickLabel.Location = new System.Drawing.Point((i == 1) ? 384 : 823, 153 + (j - 1) * 55);
            TickLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TickLabel.Name = $"Language{i}_Tick{j}_Label";
            TickLabel.Size = new System.Drawing.Size(66, 25);
            TickLabel.TabIndex = (((i - 1) * 5 + j - 1) * 3) + 4 + 3;
            TickLabel.Text = "\u221A";
            TickLabel.Visible = false;
            TickLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            TickLabel.ForeColor = Color.Green;
            this.Controls.Add(TickLabel);

            //CrossLabel Init
            CrossLabel.AutoSize = true;
            CrossLabel.Location = new System.Drawing.Point((i == 1) ? 384 : 823, 153 + (j - 1) * 55);
            CrossLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CrossLabel.Name = $"Language{i}_Cross{j}_Label";
            CrossLabel.Size = new System.Drawing.Size(66, 25);
            CrossLabel.TabIndex = (((i - 1) * 5 + j - 1) * 5) + 5 + 3;
            CrossLabel.Text = "X";
            CrossLabel.Visible = false;
            CrossLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            CrossLabel.ForeColor = Color.Red;
            this.Controls.Add(CrossLabel);

            return new TestObject(WordLabel, SeparatorLabel, TextBox,TickLabel,CrossLabel);
        }

        private void Test_Knowledge_Button_Click(object sender, EventArgs e)
        {
            int max = 10;
            int good = 0;
            for (int i = 0; i < 10; i++)
            {
                bool result  = Test.IsGood((i < 5) ? 1 : 2, LanguageObjects[i].Word, LanguageObjects[i].Translation);
                good = (result) ? good + 1 : good;
                LanguageObjects[i].SetVisible(result);
            }
            Results.Add(new TestResult(DateTime.Now, (int)(((double)good) / max * 100),Test.First_Language,Test.Second_Language));
            Test_Knowledge_Button.Visible = false;
            Exit_Button.Visible = true;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            SetCurrentView(View);
        }

        private void Test_View_Resize(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Location = new Point(Size.Width * ControlPercentages[control].X / 100, Size.Height * ControlPercentages[control].Y / 100);
                control.Size = new Size(Size.Width * ControlPercentages[control].Width / 100, Size.Height * ControlPercentages[control].Height / 100);
            }
        }
    }

    internal struct TestObject
    {
        private Label word { get; set; }
        private Label separator { get; set; }
        private TextBox translation { get; set; }
        private Label tickLabel { get; set; }
        private Label crossLabel { get; set; }
        public TestObject(Label word,Label separator,TextBox translation,Label tickLabel,Label crossLabel)
        { 
            this.word = word;
            this.separator = separator;
            this.translation = translation;
            this.tickLabel = tickLabel;
            this.crossLabel = crossLabel;
        }

        public string Word => word.Text;
        public string Translation => translation.Text.ToLower().Ekezettelenit();

        public void SetVisible(bool Result)
        {
            if (Result)
            {
                tickLabel.Visible = true;
                crossLabel.Visible = false;
            }
            else
            {
                crossLabel.Visible = true;
                tickLabel.Visible = false;
            }
            translation.Enabled = false;
        }
    }
}
