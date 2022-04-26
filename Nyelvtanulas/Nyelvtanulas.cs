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
            this.Controls.Remove(this.CurrentView);
            control.Dock = System.Windows.Forms.DockStyle.Fill;
            control.Location = new System.Drawing.Point(0, 0);
            control.Size = new System.Drawing.Size(939, 457);
            control.TabIndex = 0;
            this.CurrentView = control;
        }
    }
}
