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
        public Test_View(Test test)
        {
            Test = test;
            Language1Labels = new Dictionary<int,Label>();
            Language2Labels = new Dictionary<int, Label>();
            InitializeComponent();
            AddLabels();
            Translated_Language1_Label.Text = Test.Language1;
            Translation_Language1_Label.Text = Test.Language1;
            Translated_Language2_Label.Text = Test.Language2;
            Translation_Language2_Label.Text = Test.Language2;
            int i = 1;
            foreach (Translation tr in Test.Language1Words)
            {
                Language1Labels[i].Text = tr.Word;
                i++;
            }
            i = 1;
            foreach (Translation tr in Test.Language2Words)
            {
                Language2Labels[i].Text = tr.Word;
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
