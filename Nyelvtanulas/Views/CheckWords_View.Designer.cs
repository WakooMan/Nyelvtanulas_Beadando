namespace Nyelvtanulas.Views
{
    partial class CheckWords_View
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
            this.Translated_Language_ComboBox = new System.Windows.Forms.ComboBox();
            this.Translation_Language_ComboBox = new System.Windows.Forms.ComboBox();
            this.Translated_Language_ListBox = new System.Windows.Forms.ListBox();
            this.Translation_Language_ListBox = new System.Windows.Forms.ListBox();
            this.Back_To_Menu_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Translated_Language_ComboBox
            // 
            this.Translated_Language_ComboBox.FormattingEnabled = true;
            this.Translated_Language_ComboBox.Items.AddRange(new object[] {
            "None"});
            this.Translated_Language_ComboBox.Location = new System.Drawing.Point(453, 44);
            this.Translated_Language_ComboBox.Name = "Translated_Language_ComboBox";
            this.Translated_Language_ComboBox.Size = new System.Drawing.Size(182, 33);
            this.Translated_Language_ComboBox.TabIndex = 0;
            this.Translated_Language_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Translated_Language_ComboBox_SelectedIndexChanged);
            // 
            // Translation_Language_ComboBox
            // 
            this.Translation_Language_ComboBox.FormattingEnabled = true;
            this.Translation_Language_ComboBox.Location = new System.Drawing.Point(700, 44);
            this.Translation_Language_ComboBox.Name = "Translation_Language_ComboBox";
            this.Translation_Language_ComboBox.Size = new System.Drawing.Size(182, 33);
            this.Translation_Language_ComboBox.TabIndex = 1;
            this.Translation_Language_ComboBox.Visible = false;
            // 
            // Translated_Language_ListBox
            // 
            this.Translated_Language_ListBox.FormattingEnabled = true;
            this.Translated_Language_ListBox.ItemHeight = 25;
            this.Translated_Language_ListBox.Location = new System.Drawing.Point(453, 99);
            this.Translated_Language_ListBox.Name = "Translated_Language_ListBox";
            this.Translated_Language_ListBox.Size = new System.Drawing.Size(182, 304);
            this.Translated_Language_ListBox.TabIndex = 2;
            this.Translated_Language_ListBox.SelectedIndexChanged += new System.EventHandler(this.Translated_Language_ListBox_SelectedIndexChanged);
            // 
            // Translation_Language_ListBox
            // 
            this.Translation_Language_ListBox.FormattingEnabled = true;
            this.Translation_Language_ListBox.ItemHeight = 25;
            this.Translation_Language_ListBox.Location = new System.Drawing.Point(700, 99);
            this.Translation_Language_ListBox.Name = "Translation_Language_ListBox";
            this.Translation_Language_ListBox.Size = new System.Drawing.Size(182, 304);
            this.Translation_Language_ListBox.TabIndex = 3;
            this.Translation_Language_ListBox.Visible = false;
            // 
            // Back_To_Menu_Button
            // 
            this.Back_To_Menu_Button.Location = new System.Drawing.Point(34, 426);
            this.Back_To_Menu_Button.Name = "Back_To_Menu_Button";
            this.Back_To_Menu_Button.Size = new System.Drawing.Size(157, 46);
            this.Back_To_Menu_Button.TabIndex = 4;
            this.Back_To_Menu_Button.Text = "BACK TO MENU";
            this.Back_To_Menu_Button.UseVisualStyleBackColor = true;
            this.Back_To_Menu_Button.Click += new System.EventHandler(this.Back_To_Menu_Button_Click);
            // 
            // CheckWords_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Back_To_Menu_Button);
            this.Controls.Add(this.Translation_Language_ListBox);
            this.Controls.Add(this.Translated_Language_ListBox);
            this.Controls.Add(this.Translation_Language_ComboBox);
            this.Controls.Add(this.Translated_Language_ComboBox);
            this.Name = "CheckWords_View";
            this.Size = new System.Drawing.Size(1058, 498);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Translated_Language_ComboBox;
        private System.Windows.Forms.ComboBox Translation_Language_ComboBox;
        private System.Windows.Forms.ListBox Translated_Language_ListBox;
        private System.Windows.Forms.ListBox Translation_Language_ListBox;
        private System.Windows.Forms.Button Back_To_Menu_Button;
    }
}
