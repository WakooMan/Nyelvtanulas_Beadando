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
        private readonly Chart chart;
        private readonly Dictionary<Control, Rectangle> ControlPercentages;

        private Action<UserControl> SetCurrentView { get; set; }
        public CheckWords_View(InitialView view,WordData data, Action<UserControl> setCurrentView)
        {
            this.Data = data;
            this.View = view;
            this.SetCurrentView = setCurrentView;
            InitializeComponent();
            chart = new Chart();
            chart.Location = new Point(100,50);
            chart.Size = new Size(900,350);
            chart.BackColor = Color.Yellow;
            chart.Titles.Add("Word Counts of Languages");
            Series series = chart.Series.Add("WordCounts");
            ChartArea area = chart.ChartAreas.Add("WordCountArea");
            Legend legend = chart.Legends.Add("WordCountLegend");
            series.IsValueShownAsLabel = true;
            series.ChartArea = area.Name;
            series.Legend = legend.Name;
            series.ChartType = SeriesChartType.Pie;
            double AllWordsCount = Data.AllWords().Count();
            foreach (string language in Data.LanguageNames)
            {
                series.Points.AddXY(language,Math.Round(Data.GetLanguageWords(language).Count()/AllWordsCount * 100));
            }
            this.Controls.Add(chart);
            ControlPercentages = new Dictionary<Control, Rectangle>();
            foreach (Control control in Controls)
            {
                ControlPercentages.Add(control, new Rectangle(new Point((int)((double)control.Location.X / Size.Width * 100), (int)((double)control.Location.Y / Size.Height * 100)), new Size((int)((double)control.Size.Width / Size.Width * 100), (int)((double)control.Size.Height / Size.Height * 100))));
            }
            Translated_Language_ComboBox.Items.AddRange(Data.LanguageNames.ToArray());
            Translated_Language_ComboBox.SelectedIndex = 0;
            Translation_Language_ComboBox.SelectedIndex = 0;
        }

        private void Translated_Language_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTranslationStuff();
            Translation_Language_ComboBox.Visible = false;
            Choose_Translation_Label.Visible = false;
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
            ClearTranslationStuff();
            Translation_Language_ComboBox.Items.Clear();
            Translation_Language_ComboBox.Items.Add("None");
            Translation_Language_ComboBox.Visible = false;
            Choose_Translation_Label.Visible = false;
            if (Translated_Language_ListBox.SelectedItem != null)
            {
                Translation_Language_ComboBox.Items.AddRange(Data.GetTranslationLanguages((string)Translated_Language_ComboBox.SelectedItem, (string)Translated_Language_ListBox.SelectedItem));
                Translation_Language_ComboBox.Visible = true;
                Choose_Translation_Label.Visible = true;
            }
        }

        private void Translation_Language_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)Translation_Language_ComboBox.SelectedItem == "None")
            {
                Translation_Language_ListBox.Items.Clear();
                Translation_Language_ListBox.Visible = false;
            }
            else
            {
                Translation_Language_ListBox.Items.AddRange(Data.GetWords((string)Translated_Language_ComboBox.SelectedItem, (string)Translated_Language_ListBox.SelectedItem,(string)Translation_Language_ComboBox.SelectedItem));
                Translation_Language_ListBox.Visible = true;
            }
        }
        private void ClearTranslationStuff()
        {
            Translation_Language_ComboBox.Items.Clear();
            Translation_Language_ComboBox.Items.Add("None");
            Translation_Language_ComboBox.SelectedIndex = 0;
            Translation_Language_ListBox.Items.Clear();
        }

        private void CheckWords_View_Resize(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Location = new Point(Size.Width * ControlPercentages[control].X / 100, Size.Height * ControlPercentages[control].Y / 100);
                control.Size = new Size(Size.Width * ControlPercentages[control].Width / 100, Size.Height * ControlPercentages[control].Height / 100);
            }
        }
    }
}
