namespace Nyelvtanulas
{
    partial class Nyelvtanulas
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
            this.Add_Word_btn = new System.Windows.Forms.Button();
            this.Test_Knowledge_btn = new System.Windows.Forms.Button();
            this.Check_Words_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Word_btn
            // 
            this.Add_Word_btn.Location = new System.Drawing.Point(96, 486);
            this.Add_Word_btn.Name = "Add_Word_btn";
            this.Add_Word_btn.Size = new System.Drawing.Size(190, 34);
            this.Add_Word_btn.TabIndex = 0;
            this.Add_Word_btn.Text = "ADD WORD";
            this.Add_Word_btn.UseVisualStyleBackColor = true;
            this.Add_Word_btn.Click += new System.EventHandler(this.Add_Word_btn_Click);
            // 
            // Test_Knowledge_btn
            // 
            this.Test_Knowledge_btn.Location = new System.Drawing.Point(401, 486);
            this.Test_Knowledge_btn.Name = "Test_Knowledge_btn";
            this.Test_Knowledge_btn.Size = new System.Drawing.Size(295, 34);
            this.Test_Knowledge_btn.TabIndex = 1;
            this.Test_Knowledge_btn.Text = "TEST YOUR KNOWLEDGE";
            this.Test_Knowledge_btn.UseVisualStyleBackColor = true;
            // 
            // Check_Words_btn
            // 
            this.Check_Words_btn.Location = new System.Drawing.Point(814, 486);
            this.Check_Words_btn.Name = "Check_Words_btn";
            this.Check_Words_btn.Size = new System.Drawing.Size(203, 34);
            this.Check_Words_btn.TabIndex = 2;
            this.Check_Words_btn.Text = "CHECK WORDS";
            this.Check_Words_btn.UseVisualStyleBackColor = true;
            // 
            // Nyelvtanulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.Check_Words_btn);
            this.Controls.Add(this.Test_Knowledge_btn);
            this.Controls.Add(this.Add_Word_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Nyelvtanulas";
            this.Text = "Nyelvtanulás";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Word_btn;
        private System.Windows.Forms.Button Test_Knowledge_btn;
        private System.Windows.Forms.Button Check_Words_btn;
    }
}
