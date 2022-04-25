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
    public partial class Nyelvtanulas : Form
    {
        public readonly WordData Data;
        public Nyelvtanulas()
        {
            Data = new WordData();
            InitializeComponent();
        }
    }
}
