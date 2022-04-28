using Nyelvtanulas.Documents;
using Nyelvtanulas.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nyelvtanulas
{
    public partial class NyelvtanulasForm : Form
    {
        private WordData Data;
        public NyelvtanulasForm()
        {
            Data = new WordData(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Repos\C#Beadando\Nyelvtanulas\Forditasok.mdf;Integrated Security=True;Connect Timeout=30");
            InitializeComponent();
            InitialView InitialView = new InitialView(Data,this.SetCurrentView);
            SetCurrentView(InitialView);
        }

        private UserControl? _currentView = null;
        private UserControl CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                if (_currentView is not null)
                {
                    Controls.Remove(_currentView);
                }
                _currentView = value;
                Controls.Add(_currentView);
            }
        }

        private void SetCurrentView(UserControl control)
        {
            control.Dock = System.Windows.Forms.DockStyle.Fill;
            control.Location = new System.Drawing.Point(0, 0);
            control.TabIndex = 0;
            this.CurrentView = control;
        }
    }
}
