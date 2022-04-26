using System.Windows.Forms;

namespace Nyelvtanulas
{
    partial class NyelvtanulasForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // InitialView
            // 
            Nyelvtanulas.Views.InitialView InitialView = new Nyelvtanulas.Views.InitialView(this.SetCurrentView);
            SetCurrentView(InitialView);
            // 
            // Nyelvtanulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 457);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Nyelvtanulas";
            this.Text = "Nyelvtanulás";
            this.ResumeLayout(false);

        }
        #endregion
        private UserControl _currentView = null;
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
    }
}
