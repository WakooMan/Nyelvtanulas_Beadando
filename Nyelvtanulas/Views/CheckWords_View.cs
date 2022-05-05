using Nyelvtanulas.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Nyelvtanulas.Views
{
    public partial class CheckWords_View : UserControl
    {
        private readonly WordData Data;
        private readonly InitialView View;
        private readonly Chart chart1;
        private Action<UserControl> SetCurrentView { get; set; }
        public CheckWords_View(InitialView view,WordData data, Action<UserControl> setCurrentView)
        {
            this.Data = data;
            this.View = view;
            this.SetCurrentView = setCurrentView;
            InitializeComponent();
            chart1 = new Chart();
            chart1.Location = new Point(0,0);
            chart1.Size = new Size(400,400);
            chart1.Titles.Add("Word Counts of Languages");
            Series series = chart1.Series.Add("WordCounts");
            ChartArea area = chart1.ChartAreas.Add("WordCountArea");
            Legend legend = chart1.Legends.Add("WordCountLegend");
            series.IsValueShownAsLabel = true;
            series.ChartArea = area.Name;
            series.Legend = legend.Name;
            series.ChartType = SeriesChartType.Pie;
            double AllWordsCount = Data.AllWords().Count();
            foreach (string language in Data.LanguageNames)
            {
                series.Points.AddXY(language,Math.Round(Data.GetLanguageWords(language).Count()/AllWordsCount * 100));
            }
            this.Controls.Add(chart1);
            Translated_Language_ComboBox.Items.AddRange(Data.LanguageNames.ToArray());
            Translated_Language_ComboBox.SelectedIndex = 0;
        }

        private void Translated_Language_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Translated_Language_ListBox.Items.Clear();
            if ((string)Translated_Language_ComboBox.SelectedItem != "None")
            {
                Translated_Language_ListBox.Items.AddRange(Data.GetLanguageWords((string)Translated_Language_ComboBox.SelectedItem).ToArray());
            }
        }

        private void Back_To_Menu_Button_Click(object sender, EventArgs e)
        {
            SetCurrentView(View);
        }

        private void Translated_Language_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
