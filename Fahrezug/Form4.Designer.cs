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
            this.AdresseTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Ortlabel = new System.Windows.Forms.Label();
            this.OrttxtBox = new System.Windows.Forms.TextBox();
            this.PlzLabel = new System.Windows.Forms.Label();
            this.PlzTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresse";
            // 
            // AdresseTextBox
            // 
            this.AdresseTextBox.Location = new System.Drawing.Point(404, 119);
            this.AdresseTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AdresseTextBox.Name = "AdresseTextBox";
            this.AdresseTextBox.Size = new System.Drawing.Size(200, 31);
            this.AdresseTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 574);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HinzufügeButton);
            // 
            // Ortlabel
            // 
            this.Ortlabel.AutoSize = true;
            this.Ortlabel.Location = new System.Drawing.Point(164, 248);
            this.Ortlabel.Name = "Ortlabel";
            this.Ortlabel.Size = new System.Drawing.Size(41, 25);
            this.Ortlabel.TabIndex = 3;
            this.Ortlabel.Text = "Ort";
            // 
            // OrttxtBox
            // 
            this.OrttxtBox.Location = new System.Drawing.Point(404, 231);
            this.OrttxtBox.Name = "OrttxtBox";
            this.OrttxtBox.Size = new System.Drawing.Size(200, 31);
            this.OrttxtBox.TabIndex = 4;
            // 
            // PlzLabel
            // 
            this.PlzLabel.AutoSize = true;
            this.PlzLabel.Location = new System.Drawing.Point(164, 358);
            this.PlzLabel.Name = "PlzLabel";
            this.PlzLabel.Size = new System.Drawing.Size(123, 25);
            this.PlzLabel.TabIndex = 5;
            this.PlzLabel.Text = "Postleitzahl";
            // 
            // PlzTextBox
            // 
            this.PlzTextBox.Location = new System.Drawing.Point(404, 355);
            this.PlzTextBox.Name = "PlzTextBox";
            this.PlzTextBox.Size = new System.Drawing.Size(200, 31);
            this.PlzTextBox.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.PlzTextBox);
            this.Controls.Add(this.PlzLabel);
            this.Controls.Add(this.OrttxtBox);
            this.Controls.Add(this.Ortlabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdresseTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdresseTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Ortlabel;
        private System.Windows.Forms.TextBox OrttxtBox;
        private System.Windows.Forms.Label PlzLabel;
        private System.Windows.Forms.TextBox PlzTextBox;
    }
}