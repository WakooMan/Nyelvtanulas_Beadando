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
    public partial class TestResults_View : UserControl
    {
        private Action<UserControl> SetCurrentView { get; set; }
        private readonly InitialView View;
        private readonly TestResults Results;
        private readonly Chart chart;
        private readonly DateTime Date1;
        private readonly DateTime Date2;
        private readonly string FirstLanguage;
        private readonly string SecondLanguage;
        private readonly Dictionary<Control, Rectangle> ControlPercentages;

        public TestResults_View(InitialView initialView, TestResults results, Action<UserControl> setCurrentView,DateTime date1,DateTime date2,string First_Language,string Second_Language)
        {
            View = initialView;
            Results = results;
            Date1 = date1;
            Date2 = date2;
            FirstLanguage = First_Language;
            SecondLanguage = Second_Language;
            SetCurrentView = setCurrentView;
            InitializeComponent();
            chart = new Chart();
            chart.Location = new Point(100, 50);
            chart.Size = new Size(1521, 400);
            chart.Titles.Add($"Results of Tests between {Date1} and {Date2}");
            chart.BackColor = Color.Yellow;
            ChartArea area = chart.ChartAreas.Add($"ResultsArea");
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 100;
            area.AxisX.Minimum = Date1.ToOADate();
            area.AxisX.Maximum = Date2.ToOADate();
            var ValidResults = Results.Results.Where(r => r.Date >= Date1 && r.Date <= Date2 && ((r.FirstLanguage == FirstLanguage && r.SecondLanguage == SecondLanguage) || (r.SecondLanguage == FirstLanguage && r.FirstLanguage == SecondLanguage)));
            int i = 1;
            foreach (var result in ValidResults)
            {
                if (result.Percentage != 0)
                {
                    Series series = chart.Series.Add($"Result{i}");
                    series.ChartType = SeriesChartType.Column;
                    series.XValueType = ChartValueType.DateTime;
                    series.YValueType = ChartValueType.Int32;
                    series["PixelPointWidth"] = "100";
                    series.ChartArea = area.Name;
                    series.Points.AddXY(result.Date, result.Percentage);
                    i++;
                }
            }
            this.Controls.Add(chart);
            ControlPercentages = new Dictionary<Control, Rectangle>();
            foreach (Control control in Controls)
            {
                ControlPercentages.Add(control, new Rectangle(new Point((int)((double)control.Location.X / Size.Width * 100), (int)((double)control.Location.Y / Size.Height * 100)), new Size((int)((double)control.Size.Width / Size.Width * 100), (int)((double)control.Size.Height / Size.Height * 100))));
            }
        }

        private void Back_To_Menu_Button_Click(object sender, EventArgs e)
        {
            SetCurrentView(View);
        }

        private void TestResults_View_Resize(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Location = new Point(Size.Width * ControlPercentages[control].X / 100, Size.Height * ControlPercentages[control].Y / 100);
                control.Size = new Size(Size.Width * ControlPercentages[control].Width / 100, Size.Height * ControlPercentages[control].Height / 100);
            }
        }
    }
}
