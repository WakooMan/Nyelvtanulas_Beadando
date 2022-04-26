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

namespace Nyelvtanulas
{
    public partial class NyelvtanulasForm : Form
    {
        public NyelvtanulasForm()
        {
            InitializeComponent();
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
