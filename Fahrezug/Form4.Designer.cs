namespace Fahrzeug
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.ModellTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HesterllerTextBox = new System.Windows.Forms.TextBox();
            this.KennzeichenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modell";
            // 
            // ModellTextBox
            // 
            this.ModellTextBox.Location = new System.Drawing.Point(882, 145);
            this.ModellTextBox.Name = "ModellTextBox";
            this.ModellTextBox.Size = new System.Drawing.Size(100, 31);
            this.ModellTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hersteller";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kennzeichen";
            // 
            // HesterllerTextBox
            // 
            this.HesterllerTextBox.Location = new System.Drawing.Point(882, 268);
            this.HesterllerTextBox.Name = "HesterllerTextBox";
            this.HesterllerTextBox.Size = new System.Drawing.Size(100, 31);
            this.HesterllerTextBox.TabIndex = 5;
            // 
            // KennzeichenTextBox
            // 
            this.KennzeichenTextBox.Location = new System.Drawing.Point(882, 382);
            this.KennzeichenTextBox.Name = "KennzeichenTextBox";
            this.KennzeichenTextBox.Size = new System.Drawing.Size(100, 31);
            this.KennzeichenTextBox.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 865);
            this.Controls.Add(this.KennzeichenTextBox);
            this.Controls.Add(this.HesterllerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModellTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ModellTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HesterllerTextBox;
        private System.Windows.Forms.TextBox KennzeichenTextBox;
    }
}