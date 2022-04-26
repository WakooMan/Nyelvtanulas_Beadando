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
            this.SuspendLayout();
            // 
            // Add_Translations_Button
            // 
            this.Add_Translations_Button.Location = new System.Drawing.Point(252, 395);
            this.Add_Translations_Button.Name = "Add_Translations_Button";
            this.Add_Translations_Button.Size = new System.Drawing.Size(278, 34);
            this.Add_Translations_Button.TabIndex = 0;
            this.Add_Translations_Button.Text = "ADD TRANSLATIONS";
            this.Add_Translations_Button.UseVisualStyleBackColor = true;
            this.Add_Translations_Button.Click += new System.EventHandler(this.Add_Translations_Button_Click);
            // 
            // Add_Translation_Button
            // 
            this.Add_Translation_Button.Location = new System.Drawing.Point(592, 331);
            this.Add_Translation_Button.Name = "Add_Translation_Button";
            this.Add_Translation_Button.Size = new System.Drawing.Size(193, 34);
            this.Add_Translation_Button.TabIndex = 1;
            this.Add_Translation_Button.Text = "ADD TRANSLATION";
            this.Add_Translation_Button.UseVisualStyleBackColor = true;
            this.Add_Translation_Button.Click += new System.EventHandler(this.Add_Translation_Button_Click);
            // 
            // Translations_ListBox
            // 
            this.Translations_ListBox.FormattingEnabled = true;
            this.Translations_ListBox.ItemHeight = 25;
            this.Translations_ListBox.Location = new System.Drawing.Point(592, 56);
            this.Translations_ListBox.Name = "Translations_ListBox";
            this.Translations_ListBox.Size = new System.Drawing.Size(193, 204);
            this.Translations_ListBox.TabIndex = 2;
            // 
            // Add_Translation_TextBox
            // 
            this.Add_Translation_TextBox.Location = new System.Drawing.Point(592, 276);
            this.Add_Translation_TextBox.Name = "Add_Translation_TextBox";
            this.Add_Translation_TextBox.Size = new System.Drawing.Size(193, 31);
            this.Add_Translation_TextBox.TabIndex = 3;
            // 
            // Add_Translation_Label
            // 
            this.Add_Translation_Label.AutoSize = true;
            this.Add_Translation_Label.Location = new System.Drawing.Point(486, 282);
            this.Add_Translation_Label.Name = "Add_Translation_Label";
            this.Add_Translation_Label.Size = new System.Drawing.Size(100, 25);
            this.Add_Translation_Label.TabIndex = 4;
            this.Add_Translation_Label.Text = "Translation:";
            // 
            // Add_Word_Label
            // 
            this.Add_Word_Label.AutoSize = true;
            this.Add_Word_Label.Location = new System.Drawing.Point(58, 101);
            this.Add_Word_Label.Name = "Add_Word_Label";
            this.Add_Word_Label.Size = new System.Drawing.Size(56, 25);
            this.Add_Word_Label.TabIndex = 5;
            this.Add_Word_Label.Text = "Word";
            // 
            // Add_Word_TextBox
            // 
            this.Add_Word_TextBox.Location = new System.Drawing.Point(150, 101);
            this.Add_Word_TextBox.Name = "Add_Word_TextBox";
            this.Add_Word_TextBox.Size = new System.Drawing.Size(171, 31);
            this.Add_Word_TextBox.TabIndex = 6;
            // 
            // Translations_Label
            // 
            this.Translations_Label.AutoSize = true;
            this.Translations_Label.Location = new System.Drawing.Point(640, 13);
            this.Translations_Label.Name = "Translations_Label";
            this.Translations_Label.Size = new System.Drawing.Size(104, 25);
            this.Translations_Label.TabIndex = 7;
            this.Translations_Label.Text = "Translations";
            // 
            // Add_Word_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Translations_Label);
            this.Controls.Add(this.Add_Word_TextBox);
            this.Controls.Add(this.Add_Word_Label);
            this.Controls.Add(this.Add_Translation_Label);
            this.Controls.Add(this.Add_Translation_TextBox);
            this.Controls.Add(this.Translations_ListBox);
            this.Controls.Add(this.Add_Translation_Button);
            this.Controls.Add(this.Add_Translations_Button);
            this.Name = "Add_Word_View";
            this.Size = new System.Drawing.Size(835, 467);
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
    }
}
