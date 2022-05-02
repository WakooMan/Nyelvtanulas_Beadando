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
            this.Export_To_Xml_Button = new System.Windows.Forms.Button();
            this.Export_Translated_Language_Label = new System.Windows.Forms.Label();
            this.Export_Translation_Language_Label = new System.Windows.Forms.Label();
            this.Export_FileName_Label = new System.Windows.Forms.Label();
            this.Export_FileName_TextBox = new System.Windows.Forms.TextBox();
            this.Export_Translation_Language_ComboBox = new System.Windows.Forms.ComboBox();
            this.Export_Translated_Language_ComboBox = new System.Windows.Forms.ComboBox();
            this.Test_Results_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Translation_Button
            // 
            this.Add_Translation_Button.Location = new System.Drawing.Point(83, 347);
            this.Add_Translation_Button.Name = "Add_Translation_Button";
            this.Add_Translation_Button.Size = new System.Drawing.Size(227, 53);
            this.Add_Translation_Button.TabIndex = 0;
            this.Add_Translation_Button.Text = "ADD TRANSLATION";
            this.Add_Translation_Button.UseVisualStyleBackColor = true;
            this.Add_Translation_Button.Click += new System.EventHandler(this.Add_Translation_Button_Click);
            // 
            // Check_Knowledge_Button
            // 
            this.Check_Knowledge_Button.Location = new System.Drawing.Point(374, 347);
            this.Check_Knowledge_Button.Name = "Check_Knowledge_Button";
            this.Check_Knowledge_Button.Size = new System.Drawing.Size(214, 53);
            this.Check_Knowledge_Button.TabIndex = 1;
            this.Check_Knowledge_Button.Text = "TEST YOUR KNOWLEDGE";
            this.Check_Knowledge_Button.UseVisualStyleBackColor = true;
            this.Check_Knowledge_Button.Click += new System.EventHandler(this.Check_Knowledge_Button_Click);
            // 
            // Check_Word_Button
            // 
            this.Check_Word_Button.Location = new System.Drawing.Point(616, 347);
            this.Check_Word_Button.Name = "Check_Word_Button";
            this.Check_Word_Button.Size = new System.Drawing.Size(227, 53);
            this.Check_Word_Button.TabIndex = 2;
            this.Check_Word_Button.Text = "CHECK WORDS";
            this.Check_Word_Button.UseVisualStyleBackColor = true;
            // 
            // Add_Language1_Label
            // 
            this.Add_Language1_Label.AutoSize = true;
            this.Add_Language1_Label.Location = new System.Drawing.Point(83, 145);
            this.Add_Language1_Label.Name = "Add_Language1_Label";
            this.Add_Language1_Label.Size = new System.Drawing.Size(173, 25);
            this.Add_Language1_Label.TabIndex = 4;
            this.Add_Language1_Label.Text = "Translated Language";
            // 
            // Add_Language2_Label
            // 
            this.Add_Language2_Label.AutoSize = true;
            this.Add_Language2_Label.Location = new System.Drawing.Point(83, 247);
            this.Add_Language2_Label.Name = "Add_Language2_Label";
            this.Add_Language2_Label.Size = new System.Drawing.Size(178, 25);
            this.Add_Language2_Label.TabIndex = 5;
            this.Add_Language2_Label.Text = "Translation Language";
            // 
            // Add_Language2_ComboBox
            // 
            this.Add_Language2_ComboBox.FormattingEnabled = true;
            this.Add_Language2_ComboBox.Items.AddRange(new object[] {
            "None"});
            this.Add_Language2_ComboBox.Location = new System.Drawing.Point(83, 288);
            this.Add_Language2_ComboBox.Name = "Add_Language2_ComboBox";
            this.Add_Language2_ComboBox.Size = new System.Drawing.Size(183, 33);
            this.Add_Language2_ComboBox.TabIndex = 6;
            this.Add_Language2_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Add_Language2_ComboBox_SelectedIndexChanged);
            // 
            // Add_Language1_ComboBox
            // 
            this.Add_Language1_ComboBox.FormattingEnabled = true;
            this.Add_Language1_ComboBox.Items.AddRange(new object[] {
            "None"});
            this.Add_Language1_ComboBox.Location = new System.Drawing.Point(83, 188);
            this.Add_Language1_ComboBox.Name = "Add_Language1_ComboBox";
            this.Add_Language1_ComboBox.Size = new System.Drawing.Size(183, 33);
            this.Add_Language1_ComboBox.TabIndex = 7;
            this.Add_Language1_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Add_Language1_ComboBox_SelectedIndexChanged);
            // 
            // Check_Language1_Label
            // 
            this.Check_Language1_Label.AutoSize = true;
            this.Check_Language1_Label.Location = new System.Drawing.Point(374, 145);
            this.Check_Language1_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Check_Language1_Label.Name = "Check_Language1_Label";
            this.Check_Language1_Label.Size = new System.Drawing.Size(127, 25);
            this.Check_Language1_Label.TabIndex = 8;
            this.Check_Language1_Label.Text = "First Language";
            // 
            // Check_Language2_Label
            // 
            this.Check_Language2_Label.AutoSize = true;
            this.Check_Language2_Label.Location = new System.Drawing.Point(374, 247);
            this.Check_Language2_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Check_Language2_Label.Name = "Check_Language2_Label";
            this.Check_Language2_Label.Size = new System.Drawing.Size(153, 25);
            this.Check_Language2_Label.TabIndex = 9;
            this.Check_Language2_Label.Text = "Second Language";
            // 
            // Check_Language2_ComboBox
            // 
            this.Check_Language2_ComboBox.FormattingEnabled = true;
            this.Check_Language2_ComboBox.Items.AddRange(new object[] {
            "None"});
            this.Check_Language2_ComboBox.Location = new System.Drawing.Point(374, 288);
            this.Check_Language2_ComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Check_Language2_ComboBox.Name = "Check_Language2_ComboBox";
            this.Check_Language2_ComboBox.Size = new System.Drawing.Size(171, 33);
            this.Check_Language2_ComboBox.TabIndex = 10;
            this.Check_Language2_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Check_Language2_ComboBox_SelectedIndexChanged);
            // 
            // Check_Language1_ComboBox
            // 
            this.Check_Language1_ComboBox.FormattingEnabled = true;
            this.Check_Language1_ComboBox.Items.AddRange(new object[] {
            "None"});
            this.Check_Language1_ComboBox.Location = new System.Drawing.Point(374, 188);
            this.Check_Language1_ComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Check_Language1_ComboBox.Name = "Check_Language1_ComboBox";
            this.Check_Language1_ComboBox.Size = new System.Drawing.Size(171, 33);
            this.Check_Language1_ComboBox.TabIndex = 11;
            this.Check_Language1_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Check_Language1_ComboBox_SelectedIndexChanged);
            // 
            // Export_To_Xml_Button
            // 
            this.Export_To_Xml_Button.Location = new System.Drawing.Point(909, 347);
            this.Export_To_Xml_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Export_To_Xml_Button.Name = "Export_To_Xml_Button";
            this.Export_To_Xml_Button.Size = new System.Drawing.Size(194, 53);
            this.Export_To_Xml_Button.TabIndex = 12;
            this.Export_To_Xml_Button.Text = "EXPORT TO XML";
            this.Export_To_Xml_Button.UseVisualStyleBackColor = true;
            this.Export_To_Xml_Button.Click += new System.EventHandler(this.Export_To_Xml_Button_Click);
            // 
            // Export_Translated_Language_Label
            // 
            this.Export_Translated_Language_Label.AutoSize = true;
            this.Export_Translated_Language_Label.Location = new System.Drawing.Point(909, 125);
            this.Export_Translated_Language_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Export_Translated_Language_Label.Name = "Export_Translated_Language_Label";
            this.Export_Translated_Language_Label.Size = new System.Drawing.Size(173, 25);
            this.Export_Translated_Language_Label.TabIndex = 13;
            this.Export_Translated_Language_Label.Text = "Translated Language";
            // 
            // Export_Translation_Language_Label
            // 
            this.Export_Translation_Language_Label.AutoSize = true;
            this.Export_Translation_Language_Label.Location = new System.Drawing.Point(909, 197);
            this.Export_Translation_Language_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Export_Translation_Language_Label.Name = "Export_Translation_Language_Label";
            this.Export_Translation_Language_Label.Size = new System.Drawing.Size(178, 25);
            this.Export_Translation_Language_Label.TabIndex = 14;
            this.Export_Translation_Language_Label.Text = "Translation Language";
            // 
            // Export_FileName_Label
            // 
            this.Export_FileName_Label.AutoSize = true;
            this.Export_FileName_Label.Location = new System.Drawing.Point(909, 268);
            this.Export_FileName_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Export_FileName_Label.Name = "Export_FileName_Label";
            this.Export_FileName_Label.Size = new System.Drawing.Size(85, 25);
            this.Export_FileName_Label.TabIndex = 15;
            this.Export_FileName_Label.Text = "FileName";
            // 
            // Export_FileName_TextBox
            // 
            this.Export_FileName_TextBox.Location = new System.Drawing.Point(909, 298);
            this.Export_FileName_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Export_FileName_TextBox.Name = "Export_FileName_TextBox";
            this.Export_FileName_TextBox.Size = new System.Drawing.Size(193, 31);
            this.Export_FileName_TextBox.TabIndex = 16;
            // 
            // Export_Translation_Language_ComboBox
            // 
            this.Export_Translation_Language_ComboBox.FormattingEnabled = true;
            this.Export_Translation_Language_ComboBox.Items.AddRange(new object[] {
            "None"});
            this.Export_Translation_Language_ComboBox.Location = new System.Drawing.Point(909, 225);
            this.Export_Translation_Language_ComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Export_Translation_Language_ComboBox.Name = "Export_Translation_Language_ComboBox";
            this.Export_Translation_Language_ComboBox.Size = new System.Drawing.Size(193, 33);
            this.Export_Translation_Language_ComboBox.TabIndex = 17;
            this.Export_Translation_Language_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Export_Translation_Language_ComboBox_SelectedIndexChanged);
            // 
            // Export_Translated_Language_ComboBox
            // 
            this.Export_Translated_Language_ComboBox.FormattingEnabled = true;
            this.Export_Translated_Language_ComboBox.Items.AddRange(new object[] {
            "None"});
            this.Export_Translated_Language_ComboBox.Location = new System.Drawing.Point(909, 155);
            this.Export_Translated_Language_ComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Export_Translated_Language_ComboBox.Name = "Export_Translated_Language_ComboBox";
            this.Export_Translated_Language_ComboBox.Size = new System.Drawing.Size(193, 33);
            this.Export_Translated_Language_ComboBox.TabIndex = 18;
            this.Export_Translated_Language_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Export_Translated_Language_ComboBox_SelectedIndexChanged);
            // 
            // Test_Results_Button
            // 
            this.Test_Results_Button.Location = new System.Drawing.Point(1181, 347);
            this.Test_Results_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Test_Results_Button.Name = "Test_Results_Button";
            this.Test_Results_Button.Size = new System.Drawing.Size(164, 53);
            this.Test_Results_Button.TabIndex = 19;
            this.Test_Results_Button.Text = "TEST RESULTS";
            this.Test_Results_Button.UseVisualStyleBackColor = true;
            // 
            // InitialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Test_Results_Button);
            this.Controls.Add(this.Export_Translated_Language_ComboBox);
            this.Controls.Add(this.Export_Translation_Language_ComboBox);
            this.Controls.Add(this.Export_FileName_TextBox);
            this.Controls.Add(this.Export_FileName_Label);
            this.Controls.Add(this.Export_Translation_Language_Label);
            this.Controls.Add(this.Export_Translated_Language_Label);
            this.Controls.Add(this.Export_To_Xml_Button);
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
            this.Name = "InitialView";
            this.Size = new System.Drawing.Size(1430, 542);
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
        private System.Windows.Forms.Button Export_To_Xml_Button;
        private System.Windows.Forms.Label Export_Translated_Language_Label;
        private System.Windows.Forms.Label Export_Translation_Language_Label;
        private System.Windows.Forms.Label Export_FileName_Label;
        private System.Windows.Forms.TextBox Export_FileName_TextBox;
        private System.Windows.Forms.ComboBox Export_Translation_Language_ComboBox;
        private System.Windows.Forms.ComboBox Export_Translated_Language_ComboBox;
        private System.Windows.Forms.Button Test_Results_Button;
    }
}
