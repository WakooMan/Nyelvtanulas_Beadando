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
    public partial class Test_View : UserControl
    {
        private readonly Test Test;
        private readonly Dictionary<int, Label> Language1Labels;
        private readonly Dictionary<int, Label> Language2Labels;
        private readonly WordData Data;
        private Action<UserControl> SetCurrentView { get; set; }
        public Test_View(WordData Data, Action<UserControl> SetCurrentView, Test test)
        {
            Test = test;
            this.SetCurrentView = SetCurrentView;
            this.Data = Data;
            Language1Labels = new Dictionary<int,Label>();
            Language2Labels = new Dictionary<int, Label>();
            InitializeComponent();
            AddLabels();
            Translated_Language1_Label.Text = Test.First_Language;
            Translation_Language1_Label.Text = Test.First_Language;
            Translated_Language2_Label.Text = Test.Second_Language;
            Translation_Language2_Label.Text = Test.Second_Language;
            int i = 1;
            foreach (string Word in Test.FirstLanguageWords)
            {
                Language1Labels[i].Text = Word;
                i++;
            }
            i = 1;
            foreach (string Word in Test.SecondLanguageWords)
            {
                Language2Labels[i].Text = Word;
                i++;
            }
        }

        private void AddLabels()
        {
            Language1Labels.Add(1,Language1_Word1_Label);
            Language1Labels.Add(2, Language1_Word2_Label);
            Language1Labels.Add(3, Language1_Word3_Label);
            Language1Labels.Add(4, Language1_Word4_Label);
            Language1Labels.Add(5, Language1_Word5_Label);
            Language2Labels.Add(1, Language2_Word1_Label);
            Language2Labels.Add(2, Language2_Word2_Label);
            Language2Labels.Add(3, Language2_Word3_Label);
            Language2Labels.Add(4, Language2_Word4_Label);
            Language2Labels.Add(5, Language2_Word5_Label);
        }
    }
}
