namespace Nyelvtanulas.Views
{
    partial class TestResults_View
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
            this.Back_To_Menu_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back_To_Menu_Button
            // 
            this.Back_To_Menu_Button.BackColor = System.Drawing.Color.Yellow;
            this.Back_To_Menu_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back_To_Menu_Button.ForeColor = System.Drawing.Color.Green;
            this.Back_To_Menu_Button.Location = new System.Drawing.Point(658, 565);
            this.Back_To_Menu_Button.Name = "Back_To_Menu_Button";
            this.Back_To_Menu_Button.Size = new System.Drawing.Size(346, 69);
            this.Back_To_Menu_Button.TabIndex = 0;
            this.Back_To_Menu_Button.Text = "BACK TO MENU";
            this.Back_To_Menu_Button.UseVisualStyleBackColor = false;
            this.Back_To_Menu_Button.Click += new System.EventHandler(this.Back_To_Menu_Button_Click);
            // 
            // TestResults_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.Back_To_Menu_Button);
            this.Name = "TestResults_View";
            this.Size = new System.Drawing.Size(1721, 665);
            this.Resize += new System.EventHandler(this.TestResults_View_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_To_Menu_Button;
    }
}
