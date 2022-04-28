namespace Nyelvtanulas.Views
{
    partial class Add_Word_View
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
            this.Add_Translations_Button = new System.Windows.Forms.Button();
            this.Add_Translation_Button = new System.Windows.Forms.Button();
            this.Translations_ListBox = new System.Windows.Forms.ListBox();
            this.Add_Translation_TextBox = new System.Windows.Forms.TextBox();
            this.Add_Translation_Label = new System.Windows.Forms.Label();
            this.Add_Word_Label = new System.Windows.Forms.Label();
            this.Add_Word_TextBox = new System.Windows.Forms.TextBox();
            this.Translations_Label = new System.Windows.Forms.Label();
            this.Language1_Label = new System.Windows.Forms.Label();
            this.Language2_Label = new System.Windows.Forms.Label();
            this.Back_To_Menu_Button = new System.Windows.Forms.Button();
            this.Delete_Translation_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Translations_Button
            // 
            this.Add_Translations_Button.Location = new System.Drawing.Point(217, 237);
            this.Add_Translations_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Translations_Button.Name = "Add_Translations_Button";
            this.Add_Translations_Button.Size = new System.Drawing.Size(195, 20);
            this.Add_Translations_Button.TabIndex = 0;
            this.Add_Translations_Button.Text = "ADD TRANSLATION";
            this.Add_Translations_Button.UseVisualStyleBackColor = true;
            this.Add_Translations_Button.Click += new System.EventHandler(this.Add_Translations_Button_Click);
            // 
            // Add_Translation_Button
            // 
            this.Add_Translation_Button.Location = new System.Drawing.Point(328, 206);
            this.Add_Translation_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Translation_Button.Name = "Add_Translation_Button";
            this.Add_Translation_Button.Size = new System.Drawing.Size(109, 20);
            this.Add_Translation_Button.TabIndex = 1;
            this.Add_Translation_Button.Text = "ADD";
            this.Add_Translation_Button.UseVisualStyleBackColor = true;
            this.Add_Translation_Button.Click += new System.EventHandler(this.Add_Translation_Button_Click);
            // 
            // Translations_ListBox
            // 
            this.Translations_ListBox.FormattingEnabled = true;
            this.Translations_ListBox.ItemHeight = 15;
            this.Translations_ListBox.Location = new System.Drawing.Point(462, 77);
            this.Translations_ListBox.Margin = new System.Windows.Forms.Padding(2);
            this.Translations_ListBox.Name = "Translations_ListBox";
            this.Translations_ListBox.Size = new System.Drawing.Size(109, 124);
            this.Translations_ListBox.TabIndex = 2;
            // 
            // Add_Translation_TextBox
            // 
            this.Add_Translation_TextBox.Location = new System.Drawing.Point(328, 169);
            this.Add_Translation_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Translation_TextBox.Name = "Add_Translation_TextBox";
            this.Add_Translation_TextBox.Size = new System.Drawing.Size(109, 23);
            this.Add_Translation_TextBox.TabIndex = 3;
            // 
            // Add_Translation_Label
            // 
            this.Add_Translation_Label.AutoSize = true;
            this.Add_Translation_Label.Location = new System.Drawing.Point(253, 169);
            this.Add_Translation_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Add_Translation_Label.Name = "Add_Translation_Label";
            this.Add_Translation_Label.Size = new System.Drawing.Size(67, 15);
            this.Add_Translation_Label.TabIndex = 4;
            this.Add_Translation_Label.Text = "Translation:";
            // 
            // Add_Word_Label
            // 
            this.Add_Word_Label.AutoSize = true;
            this.Add_Word_Label.Location = new System.Drawing.Point(13, 173);
            this.Add_Word_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Add_Word_Label.Name = "Add_Word_Label";
            this.Add_Word_Label.Size = new System.Drawing.Size(39, 15);
            this.Add_Word_Label.TabIndex = 5;
            this.Add_Word_Label.Text = "Word:";
            // 
            // Add_Word_TextBox
            // 
            this.Add_Word_TextBox.Location = new System.Drawing.Point(56, 171);
            this.Add_Word_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Word_TextBox.Name = "Add_Word_TextBox";
            this.Add_Word_TextBox.Size = new System.Drawing.Size(109, 23);
            this.Add_Word_TextBox.TabIndex = 6;
            // 
            // Translations_Label
            // 
            this.Translations_Label.AutoSize = true;
            this.Translations_Label.Location = new System.Drawing.Point(480, 60);
            this.Translations_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Translations_Label.Name = "Translations_Label";
            this.Translations_Label.Size = new System.Drawing.Size(69, 15);
            this.Translations_Label.TabIndex = 7;
            this.Translations_Label.Text = "Translations";
            // 
            // Language1_Label
            // 
            this.Language1_Label.AutoSize = true;
            this.Language1_Label.Location = new System.Drawing.Point(84, 25);
            this.Language1_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Language1_Label.Name = "Language1_Label";
            this.Language1_Label.Size = new System.Drawing.Size(115, 15);
            this.Language1_Label.TabIndex = 8;
            this.Language1_Label.Text = "Translated Language";
            // 
            // Language2_Label
            // 
            this.Language2_Label.AutoSize = true;
            this.Language2_Label.Location = new System.Drawing.Point(430, 25);
            this.Language2_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Language2_Label.Name = "Language2_Label";
            this.Language2_Label.Size = new System.Drawing.Size(119, 15);
            this.Language2_Label.TabIndex = 9;
            this.Language2_Label.Text = "Translation Language";
            // 
            // Back_To_Menu_Button
            // 
            this.Back_To_Menu_Button.Location = new System.Drawing.Point(13, 234);
            this.Back_To_Menu_Button.Name = "Back_To_Menu_Button";
            this.Back_To_Menu_Button.Size = new System.Drawing.Size(116, 23);
            this.Back_To_Menu_Button.TabIndex = 10;
            this.Back_To_Menu_Button.Text = "BACK TO MENU";
            this.Back_To_Menu_Button.UseVisualStyleBackColor = true;
            this.Back_To_Menu_Button.Click += new System.EventHandler(this.Back_To_Menu_Button_Click);
            // 
            // Delete_Translation_Button
            // 
            this.Delete_Translation_Button.Location = new System.Drawing.Point(462, 206);
            this.Delete_Translation_Button.Name = "Delete_Translation_Button";
            this.Delete_Translation_Button.Size = new System.Drawing.Size(109, 21);
            this.Delete_Translation_Button.TabIndex = 11;
            this.Delete_Translation_Button.Text = "DELETE";
            this.Delete_Translation_Button.UseVisualStyleBackColor = true;
            this.Delete_Translation_Button.Click += new System.EventHandler(this.Delete_Translation_Button_Click);
            // 
            // Add_Word_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Delete_Translation_Button);
            this.Controls.Add(this.Back_To_Menu_Button);
            this.Controls.Add(this.Language2_Label);
            this.Controls.Add(this.Language1_Label);
            this.Controls.Add(this.Translations_Label);
            this.Controls.Add(this.Add_Word_TextBox);
            this.Controls.Add(this.Add_Word_Label);
            this.Controls.Add(this.Add_Translation_Label);
            this.Controls.Add(this.Add_Translation_TextBox);
            this.Controls.Add(this.Translations_ListBox);
            this.Controls.Add(this.Add_Translation_Button);
            this.Controls.Add(this.Add_Translations_Button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_Word_View";
            this.Size = new System.Drawing.Size(657, 274);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Translations_Button;
        private System.Windows.Forms.Button Add_Translation_Button;
        private System.Windows.Forms.ListBox Translations_ListBox;
        private System.Windows.Forms.TextBox Add_Translation_TextBox;
        private System.Windows.Forms.Label Add_Translation_Label;
        private System.Windows.Forms.Label Add_Word_Label;
        private System.Windows.Forms.TextBox Add_Word_TextBox;
        private System.Windows.Forms.Label Translations_Label;
        private System.Windows.Forms.Label Language1_Label;
        private System.Windows.Forms.Label Language2_Label;
        private System.Windows.Forms.Button Back_To_Menu_Button;
        private System.Windows.Forms.Button Delete_Translation_Button;
    }
}
