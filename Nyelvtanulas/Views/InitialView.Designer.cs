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
            this.Add_Language1_Label = new System.Windows.Forms.Label();
            this.Add_Language2_Label = new System.Windows.Forms.Label();
            this.Add_Language2_ComboBox = new System.Windows.Forms.ComboBox();
            this.Add_Language1_ComboBox = new System.Windows.Forms.ComboBox();
            this.Check_Language1_Label = new System.Windows.Forms.Label();
            this.Check_Language2_Label = new System.Windows.Forms.Label();
            this.Check_Language2_ComboBox = new System.Windows.Forms.ComboBox();
            this.Check_Language1_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Add_Translation_Button
            // 
            this.Add_Translation_Button.Location = new System.Drawing.Point(58, 208);
            this.Add_Translation_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Translation_Button.Name = "Add_Translation_Button";
            this.Add_Translation_Button.Size = new System.Drawing.Size(159, 32);
            this.Add_Translation_Button.TabIndex = 0;
            this.Add_Translation_Button.Text = "ADD TRANSLATION";
            this.Add_Translation_Button.UseVisualStyleBackColor = true;
            this.Add_Translation_Button.Click += new System.EventHandler(this.Add_Translation_Button_Click);
            // 
            // Check_Knowledge_Button
            // 
            this.Check_Knowledge_Button.Location = new System.Drawing.Point(262, 208);
            this.Check_Knowledge_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Check_Knowledge_Button.Name = "Check_Knowledge_Button";
            this.Check_Knowledge_Button.Size = new System.Drawing.Size(173, 32);
            this.Check_Knowledge_Button.TabIndex = 1;
            this.Check_Knowledge_Button.Text = "TEST YOUR KNOWLEDGE";
            this.Check_Knowledge_Button.UseVisualStyleBackColor = true;
            // 
            // Check_Word_Button
            // 
            this.Check_Word_Button.Location = new System.Drawing.Point(463, 208);
            this.Check_Word_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Check_Word_Button.Name = "Check_Word_Button";
            this.Check_Word_Button.Size = new System.Drawing.Size(145, 32);
            this.Check_Word_Button.TabIndex = 2;
            this.Check_Word_Button.Text = "CHECK WORDS";
            this.Check_Word_Button.UseVisualStyleBackColor = true;
            // 
            // Add_Language1_Label
            // 
            this.Add_Language1_Label.AutoSize = true;
            this.Add_Language1_Label.Location = new System.Drawing.Point(58, 87);
            this.Add_Language1_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Add_Language1_Label.Name = "Add_Language1_Label";
            this.Add_Language1_Label.Size = new System.Drawing.Size(115, 15);
            this.Add_Language1_Label.TabIndex = 4;
            this.Add_Language1_Label.Text = "Translated Language";
            // 
            // Add_Language2_Label
            // 
            this.Add_Language2_Label.AutoSize = true;
            this.Add_Language2_Label.Location = new System.Drawing.Point(58, 148);
            this.Add_Language2_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Add_Language2_Label.Name = "Add_Language2_Label";
            this.Add_Language2_Label.Size = new System.Drawing.Size(119, 15);
            this.Add_Language2_Label.TabIndex = 5;
            this.Add_Language2_Label.Text = "Translation Language";
            // 
            // Add_Language2_ComboBox
            // 
            this.Add_Language2_ComboBox.FormattingEnabled = true;
            this.Add_Language2_ComboBox.Items.AddRange(new object[] {
            "None"});
            this.Add_Language2_ComboBox.Location = new System.Drawing.Point(58, 173);
            this.Add_Language2_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Language2_ComboBox.Name = "Add_Language2_ComboBox";
            this.Add_Language2_ComboBox.Size = new System.Drawing.Size(129, 23);
            this.Add_Language2_ComboBox.TabIndex = 6;
            this.Add_Language2_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Add_Language2_ComboBox_SelectedIndexChanged);
            // 
            // Add_Language1_ComboBox
            // 
            this.Add_Language1_ComboBox.FormattingEnabled = true;
            this.Add_Language1_ComboBox.Items.AddRange(new object[] {
            "None"});
            this.Add_Language1_ComboBox.Location = new System.Drawing.Point(58, 113);
            this.Add_Language1_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Language1_ComboBox.Name = "Add_Language1_ComboBox";
            this.Add_Language1_ComboBox.Size = new System.Drawing.Size(129, 23);
            this.Add_Language1_ComboBox.TabIndex = 7;
            this.Add_Language1_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Add_Language1_ComboBox_SelectedIndexChanged);
            // 
            // Check_Language1_Label
            // 
            this.Check_Language1_Label.AutoSize = true;
            this.Check_Language1_Label.Location = new System.Drawing.Point(262, 87);
            this.Check_Language1_Label.Name = "Check_Language1_Label";
            this.Check_Language1_Label.Size = new System.Drawing.Size(86, 15);
            this.Check_Language1_Label.TabIndex = 8;
            this.Check_Language1_Label.Text = "First_Language";
            // 
            // Check_Language2_Label
            // 
            this.Check_Language2_Label.AutoSize = true;
            this.Check_Language2_Label.Location = new System.Drawing.Point(262, 148);
            this.Check_Language2_Label.Name = "Check_Language2_Label";
            this.Check_Language2_Label.Size = new System.Drawing.Size(101, 15);
            this.Check_Language2_Label.TabIndex = 9;
            this.Check_Language2_Label.Text = "Second Language";
            // 
            // Check_Language2_ComboBox
            // 
            this.Check_Language2_ComboBox.FormattingEnabled = true;
            this.Check_Language2_ComboBox.Items.AddRange(new object[] {
            "None"});
            this.Check_Language2_ComboBox.Location = new System.Drawing.Point(262, 173);
            this.Check_Language2_ComboBox.Name = "Check_Language2_ComboBox";
            this.Check_Language2_ComboBox.Size = new System.Drawing.Size(121, 23);
            this.Check_Language2_ComboBox.TabIndex = 10;
            this.Check_Language2_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Check_Language2_ComboBox_SelectedIndexChanged);
            // 
            // Check_Language1_ComboBox
            // 
            this.Check_Language1_ComboBox.FormattingEnabled = true;
            this.Check_Language1_ComboBox.Items.AddRange(new object[] {
            "None"});
            this.Check_Language1_ComboBox.Location = new System.Drawing.Point(262, 113);
            this.Check_Language1_ComboBox.Name = "Check_Language1_ComboBox";
            this.Check_Language1_ComboBox.Size = new System.Drawing.Size(121, 23);
            this.Check_Language1_ComboBox.TabIndex = 11;
            this.Check_Language1_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Check_Language1_ComboBox_SelectedIndexChanged);
            // 
            // InitialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Check_Language1_ComboBox);
            this.Controls.Add(this.Check_Language2_ComboBox);
            this.Controls.Add(this.Check_Language2_Label);
            this.Controls.Add(this.Check_Language1_Label);
            this.Controls.Add(this.Add_Language1_ComboBox);
            this.Controls.Add(this.Add_Language2_ComboBox);
            this.Controls.Add(this.Add_Language2_Label);
            this.Controls.Add(this.Add_Language1_Label);
            this.Controls.Add(this.Check_Word_Button);
            this.Controls.Add(this.Check_Knowledge_Button);
            this.Controls.Add(this.Add_Translation_Button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InitialView";
            this.Size = new System.Drawing.Size(657, 274);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Translation_Button;
        private System.Windows.Forms.Button Check_Knowledge_Button;
        private System.Windows.Forms.Button Check_Word_Button;
        private System.Windows.Forms.Label Add_Language1_Label;
        private System.Windows.Forms.Label Add_Language2_Label;
        private System.Windows.Forms.ComboBox Add_Language2_ComboBox;
        private System.Windows.Forms.ComboBox Add_Language1_ComboBox;
        private System.Windows.Forms.Label Check_Language1_Label;
        private System.Windows.Forms.Label Check_Language2_Label;
        private System.Windows.Forms.ComboBox Check_Language2_ComboBox;
        private System.Windows.Forms.ComboBox Check_Language1_ComboBox;
    }
}
