namespace Fahrzeug
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.FahrzeugListBox = new System.Windows.Forms.ListBox();
            this.FahrzeugHinzufügen_Button = new System.Windows.Forms.Button();
            this.LöschButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BearbeitenButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FahrzeugListBox
            // 
            this.FahrzeugListBox.FormattingEnabled = true;
            this.FahrzeugListBox.ItemHeight = 25;
            this.FahrzeugListBox.Location = new System.Drawing.Point(-2, -2);
            this.FahrzeugListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FahrzeugListBox.Name = "FahrzeugListBox";
            this.FahrzeugListBox.Size = new System.Drawing.Size(696, 654);
            this.FahrzeugListBox.TabIndex = 0;
            this.FahrzeugListBox.SelectedIndexChanged += new System.EventHandler(this.FahrzeugListe_SelectedIndexChanged);
            // 
            // FahrzeugHinzufügen_Button
            // 
            this.FahrzeugHinzufügen_Button.Location = new System.Drawing.Point(772, 712);
            this.FahrzeugHinzufügen_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FahrzeugHinzufügen_Button.Name = "FahrzeugHinzufügen_Button";
            this.FahrzeugHinzufügen_Button.Size = new System.Drawing.Size(344, 40);
            this.FahrzeugHinzufügen_Button.TabIndex = 1;
            this.FahrzeugHinzufügen_Button.Text = "Fahrzeug Hinzufügen";
            this.FahrzeugHinzufügen_Button.UseVisualStyleBackColor = true;
            this.FahrzeugHinzufügen_Button.Click += new System.EventHandler(this.Fahrzeug_Hinzufügen);
            // 
            // LöschButton
            // 
            this.LöschButton.Location = new System.Drawing.Point(580, 712);
            this.LöschButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LöschButton.Name = "LöschButton";
            this.LöschButton.Size = new System.Drawing.Size(148, 40);
            this.LöschButton.TabIndex = 2;
            this.LöschButton.Text = "Löschen ";
            this.LöschButton.UseVisualStyleBackColor = true;
            this.LöschButton.Click += new System.EventHandler(this.LöschButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(962, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 31);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(962, 167);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 31);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(962, 262);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 31);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(962, 356);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(196, 31);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(826, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(812, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kennzeichen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Anschaffungspreis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(784, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Erstzulassung";
            // 
            // BearbeitenButton
            // 
            this.BearbeitenButton.Location = new System.Drawing.Point(404, 712);
            this.BearbeitenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BearbeitenButton.Name = "BearbeitenButton";
            this.BearbeitenButton.Size = new System.Drawing.Size(146, 40);
            this.BearbeitenButton.TabIndex = 12;
            this.BearbeitenButton.Text = "bearbeiten";
            this.BearbeitenButton.UseVisualStyleBackColor = true;
            this.BearbeitenButton.Click += new System.EventHandler(this.Bearbeiten_Button);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 708);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Suchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Suchen_Klick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 967);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BearbeitenButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LöschButton);
            this.Controls.Add(this.FahrzeugHinzufügen_Button);
            this.Controls.Add(this.FahrzeugListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "SpeichernButton";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FahrzeugHinzufügen_Button;
        private System.Windows.Forms.Button LöschButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BearbeitenButton;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox FahrzeugListBox;
    }
}

