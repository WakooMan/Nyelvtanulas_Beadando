namespace Nyelvtanulas
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_Word_btn2 = new System.Windows.Forms.Button();
            this.Add_Synonym_btn = new System.Windows.Forms.Button();
            this.Add_Word_tb = new System.Windows.Forms.TextBox();
            this.Add_Synonym_tb = new System.Windows.Forms.TextBox();
            this.Synonym_lb = new System.Windows.Forms.ListBox();
            this.Add_Word_lbl = new System.Windows.Forms.Label();
            this.Add_Synonym_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add_Word_btn2
            // 
            this.Add_Word_btn2.Location = new System.Drawing.Point(276, 368);
            this.Add_Word_btn2.Name = "Add_Word_btn2";
            this.Add_Word_btn2.Size = new System.Drawing.Size(220, 34);
            this.Add_Word_btn2.TabIndex = 0;
            this.Add_Word_btn2.Text = "ADD WORD";
            this.Add_Word_btn2.UseVisualStyleBackColor = true;
            this.Add_Word_btn2.Click += new System.EventHandler(this.Add_Word_btn2_Click);
            // 
            // Add_Synonym_btn
            // 
            this.Add_Synonym_btn.Location = new System.Drawing.Point(529, 276);
            this.Add_Synonym_btn.Name = "Add_Synonym_btn";
            this.Add_Synonym_btn.Size = new System.Drawing.Size(209, 34);
            this.Add_Synonym_btn.TabIndex = 1;
            this.Add_Synonym_btn.Text = "ADD SYNONYM";
            this.Add_Synonym_btn.UseVisualStyleBackColor = true;
            this.Add_Synonym_btn.Click += new System.EventHandler(this.Add_Synonym_btn_Click);
            // 
            // Add_Word_tb
            // 
            this.Add_Word_tb.Location = new System.Drawing.Point(122, 86);
            this.Add_Word_tb.Name = "Add_Word_tb";
            this.Add_Word_tb.Size = new System.Drawing.Size(150, 31);
            this.Add_Word_tb.TabIndex = 2;
            // 
            // Add_Synonym_tb
            // 
            this.Add_Synonym_tb.Location = new System.Drawing.Point(554, 225);
            this.Add_Synonym_tb.Name = "Add_Synonym_tb";
            this.Add_Synonym_tb.Size = new System.Drawing.Size(150, 31);
            this.Add_Synonym_tb.TabIndex = 3;
            // 
            // Synonym_lb
            // 
            this.Synonym_lb.FormattingEnabled = true;
            this.Synonym_lb.ItemHeight = 25;
            this.Synonym_lb.Location = new System.Drawing.Point(544, 52);
            this.Synonym_lb.Name = "Synonym_lb";
            this.Synonym_lb.Size = new System.Drawing.Size(180, 129);
            this.Synonym_lb.TabIndex = 4;
            // 
            // Add_Word_lbl
            // 
            this.Add_Word_lbl.AutoSize = true;
            this.Add_Word_lbl.Location = new System.Drawing.Point(25, 90);
            this.Add_Word_lbl.Name = "Add_Word_lbl";
            this.Add_Word_lbl.Size = new System.Drawing.Size(56, 25);
            this.Add_Word_lbl.TabIndex = 5;
            this.Add_Word_lbl.Text = "Word";
            // 
            // Add_Synonym_lbl
            // 
            this.Add_Synonym_lbl.AutoSize = true;
            this.Add_Synonym_lbl.Location = new System.Drawing.Point(437, 231);
            this.Add_Synonym_lbl.Name = "Add_Synonym_lbl";
            this.Add_Synonym_lbl.Size = new System.Drawing.Size(86, 25);
            this.Add_Synonym_lbl.TabIndex = 6;
            this.Add_Synonym_lbl.Text = "Synonym";
            // 
            // Add_Word_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_Synonym_lbl);
            this.Controls.Add(this.Add_Word_lbl);
            this.Controls.Add(this.Synonym_lb);
            this.Controls.Add(this.Add_Synonym_tb);
            this.Controls.Add(this.Add_Word_tb);
            this.Controls.Add(this.Add_Synonym_btn);
            this.Controls.Add(this.Add_Word_btn2);
            this.Name = "Add_Word_View";
            this.Text = "Add_Word_View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Word_btn2;
        private System.Windows.Forms.Button Add_Synonym_btn;
        private System.Windows.Forms.TextBox Add_Word_tb;
        private System.Windows.Forms.TextBox Add_Synonym_tb;
        private System.Windows.Forms.ListBox Synonym_lb;
        private System.Windows.Forms.Label Add_Word_lbl;
        private System.Windows.Forms.Label Add_Synonym_lbl;
    }
}