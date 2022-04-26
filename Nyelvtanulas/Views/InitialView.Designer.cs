using Nyelvtanulas.Languages;

namespace Nyelvtanulas.Views
{
    partial class InitialView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_Translation_Button = new System.Windows.Forms.Button();
            this.Check_Knowledge_Button = new System.Windows.Forms.Button();
            this.Check_Word_Button = new System.Windows.Forms.Button();
            this.Language1_Label = new System.Windows.Forms.Label();
            this.Language2_Label = new System.Windows.Forms.Label();
            this.Language2_ComboBox = new System.Windows.Forms.ComboBox();
            this.Language1_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Add_Translation_Button
            // 
            this.Add_Translation_Button.Location = new System.Drawing.Point(83, 347);
            this.Add_Translation_Button.Name = "Add_Translation_Button";
            this.Add_Translation_Button.Size = new System.Drawing.Size(227, 54);
            this.Add_Translation_Button.TabIndex = 0;
            this.Add_Translation_Button.Text = "ADD TRANSLATION";
            this.Add_Translation_Button.UseVisualStyleBackColor = true;
            this.Add_Translation_Button.Click += new System.EventHandler(this.Add_Translation_Button_Click);
            // 
            // Check_Knowledge_Button
            // 
            this.Check_Knowledge_Button.Location = new System.Drawing.Point(375, 347);
            this.Check_Knowledge_Button.Name = "Check_Knowledge_Button";
            this.Check_Knowledge_Button.Size = new System.Drawing.Size(247, 54);
            this.Check_Knowledge_Button.TabIndex = 1;
            this.Check_Knowledge_Button.Text = "CHECK YOUR KNOWLEDGE";
            this.Check_Knowledge_Button.UseVisualStyleBackColor = true;
            // 
            // Check_Word_Button
            // 
            this.Check_Word_Button.Location = new System.Drawing.Point(661, 347);
            this.Check_Word_Button.Name = "Check_Word_Button";
            this.Check_Word_Button.Size = new System.Drawing.Size(207, 54);
            this.Check_Word_Button.TabIndex = 2;
            this.Check_Word_Button.Text = "CHECK WORDS";
            this.Check_Word_Button.UseVisualStyleBackColor = true;
            // 
            // Language1_Label
            // 
            this.Language1_Label.AutoSize = true;
            this.Language1_Label.Location = new System.Drawing.Point(83, 145);
            this.Language1_Label.Name = "Language1_Label";
            this.Language1_Label.Size = new System.Drawing.Size(173, 25);
            this.Language1_Label.TabIndex = 4;
            this.Language1_Label.Text = "Translated Language";
            // 
            // Language2_Label
            // 
            this.Language2_Label.AutoSize = true;
            this.Language2_Label.Location = new System.Drawing.Point(83, 247);
            this.Language2_Label.Name = "Language2_Label";
            this.Language2_Label.Size = new System.Drawing.Size(178, 25);
            this.Language2_Label.TabIndex = 5;
            this.Language2_Label.Text = "Translation Language";
            // 
            // Language2_ComboBox
            // 
            this.Language2_ComboBox.FormattingEnabled = true;
            this.Language2_ComboBox.Location = new System.Drawing.Point(83, 288);
            this.Language2_ComboBox.Name = "Language2_ComboBox";
            this.Language2_ComboBox.Size = new System.Drawing.Size(182, 33);
            this.Language2_ComboBox.TabIndex = 6;
            this.Language2_ComboBox.Items.Add(Hungarian.Current().Name());
            this.Language2_ComboBox.Items.Add(English.Current().Name());
            this.Language2_ComboBox.SelectedIndex = 1;
            // 
            // Language1_ComboBox
            // 
            this.Language1_ComboBox.FormattingEnabled = true;
            this.Language1_ComboBox.Location = new System.Drawing.Point(83, 188);
            this.Language1_ComboBox.Name = "Language1_ComboBox";
            this.Language1_ComboBox.Size = new System.Drawing.Size(182, 33);
            this.Language1_ComboBox.TabIndex = 7;
            this.Language1_ComboBox.Items.Add(Hungarian.Current().Name());
            this.Language1_ComboBox.Items.Add(English.Current().Name());
            this.Language1_ComboBox.SelectedIndex = 0;
            // 
            // InitialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Language1_ComboBox);
            this.Controls.Add(this.Language2_ComboBox);
            this.Controls.Add(this.Language2_Label);
            this.Controls.Add(this.Language1_Label);
            this.Controls.Add(this.Check_Word_Button);
            this.Controls.Add(this.Check_Knowledge_Button);
            this.Controls.Add(this.Add_Translation_Button);
            this.Name = "InitialView";
            this.Size = new System.Drawing.Size(939, 457);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Translation_Button;
        private System.Windows.Forms.Button Check_Knowledge_Button;
        private System.Windows.Forms.Button Check_Word_Button;
        private System.Windows.Forms.Label Language1_Label;
        private System.Windows.Forms.Label Language2_Label;
        private System.Windows.Forms.ComboBox Language2_ComboBox;
        private System.Windows.Forms.ComboBox Language1_ComboBox;
    }
}
