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

namespace Nyelvtanulas.Views
{
    public partial class InitialView : UserControl,IView
    {
        private WordData Data;
        public InitialView(Action<UserControl> setCurrentView)
        {
            SetCurrentView = setCurrentView;
            Data = WordData.Current();
            InitializeComponent();
        }

        public Action<UserControl> SetCurrentView { get; private set; }

        public void OnUpdate()
        {
            throw new NotImplementedException();
        }

        private void Add_Translation_Button_Click(object sender, EventArgs e)
        {

            Add_Word_View View = new Add_Word_View(this.SetCurrentView,this.Language1_ComboBox.Text,this.Language2_ComboBox.Text);
            View.Name = "Add_Word_View";
            SetCurrentView(View);
        }
    }
}
