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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AchsenTextBox = new System.Windows.Forms.TextBox();
            this.ZuladungTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Hubraumlabel = new System.Windows.Forms.Label();
            this.Leistunglabel = new System.Windows.Forms.Label();
            this.SchaddLabel = new System.Windows.Forms.Label();
            this.HubText = new System.Windows.Forms.TextBox();
            this.Leistungstext = new System.Windows.Forms.TextBox();
            this.SchadstoffklasseTextBox = new System.Windows.Forms.TextBox();
            this.SteuerLabel = new System.Windows.Forms.Label();
            this.SteuertextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FahrzeugListBox
            // 
            this.FahrzeugListBox.FormattingEnabled = true;
            this.FahrzeugListBox.Location = new System.Drawing.Point(-1, -1);
            this.FahrzeugListBox.Margin = new System.Windows.Forms.Padding(2);
            this.FahrzeugListBox.Name = "FahrzeugListBox";
            this.FahrzeugListBox.Size = new System.Drawing.Size(350, 342);
            this.FahrzeugListBox.TabIndex = 0;
            this.FahrzeugListBox.SelectedIndexChanged += new System.EventHandler(this.FahrzeugListe_SelectedIndexChanged);
            // 
            // FahrzeugHinzufügen_Button
            // 
            this.FahrzeugHinzufügen_Button.Location = new System.Drawing.Point(386, 370);
            this.FahrzeugHinzufügen_Button.Margin = new System.Windows.Forms.Padding(2);
            this.FahrzeugHinzufügen_Button.Name = "FahrzeugHinzufügen_Button";
            this.FahrzeugHinzufügen_Button.Size = new System.Drawing.Size(172, 21);
            this.FahrzeugHinzufügen_Button.TabIndex = 1;
            this.FahrzeugHinzufügen_Button.Text = "Fahrzeug Hinzufügen";
            this.FahrzeugHinzufügen_Button.UseVisualStyleBackColor = true;
            this.FahrzeugHinzufügen_Button.Click += new System.EventHandler(this.FahrzeugHinzufügen_Button_Click);
            // 
            // LöschButton
            // 
            this.LöschButton.Location = new System.Drawing.Point(290, 370);
            this.LöschButton.Margin = new System.Windows.Forms.Padding(2);
            this.LöschButton.Name = "LöschButton";
            this.LöschButton.Size = new System.Drawing.Size(74, 21);
            this.LöschButton.TabIndex = 2;
            this.LöschButton.Text = "Löschen ";
            this.LöschButton.UseVisualStyleBackColor = true;
            this.LöschButton.Click += new System.EventHandler(this.LöschButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(453, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(453, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(453, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(453, 79);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kennzeichen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Anschaffungspreis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Erstzulassung";
            // 
            // BearbeitenButton
            // 
            this.BearbeitenButton.Location = new System.Drawing.Point(202, 370);
            this.BearbeitenButton.Margin = new System.Windows.Forms.Padding(2);
            this.BearbeitenButton.Name = "BearbeitenButton";
            this.BearbeitenButton.Size = new System.Drawing.Size(73, 21);
            this.BearbeitenButton.TabIndex = 12;
            this.BearbeitenButton.Text = "bearbeiten";
            this.BearbeitenButton.UseVisualStyleBackColor = true;
            this.BearbeitenButton.Click += new System.EventHandler(this.Bearbeiten_Button);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Suchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Suchen_Klick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "berechne";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Berechne_Steuerschuld);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(598, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Parkhaus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnParkhausHinzufügen_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Achsenanzahl";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // AchsenTextBox
            // 
            this.AchsenTextBox.Location = new System.Drawing.Point(453, 99);
            this.AchsenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AchsenTextBox.Name = "AchsenTextBox";
            this.AchsenTextBox.Size = new System.Drawing.Size(100, 20);
            this.AchsenTextBox.TabIndex = 17;
            // 
            // ZuladungTextBox
            // 
            this.ZuladungTextBox.Location = new System.Drawing.Point(453, 119);
            this.ZuladungTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ZuladungTextBox.Name = "ZuladungTextBox";
            this.ZuladungTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZuladungTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Zuladung";
            // 
            // Hubraumlabel
            // 
            this.Hubraumlabel.AutoSize = true;
            this.Hubraumlabel.Location = new System.Drawing.Point(352, 139);
            this.Hubraumlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hubraumlabel.Name = "Hubraumlabel";
            this.Hubraumlabel.Size = new System.Drawing.Size(50, 13);
            this.Hubraumlabel.TabIndex = 20;
            this.Hubraumlabel.Text = "Hubraum";
            // 
            // Leistunglabel
            // 
            this.Leistunglabel.AutoSize = true;
            this.Leistunglabel.Location = new System.Drawing.Point(352, 161);
            this.Leistunglabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Leistunglabel.Name = "Leistunglabel";
            this.Leistunglabel.Size = new System.Drawing.Size(47, 13);
            this.Leistunglabel.TabIndex = 21;
            this.Leistunglabel.Text = "Leistung";
            this.Leistunglabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SchaddLabel
            // 
            this.SchaddLabel.AutoSize = true;
            this.SchaddLabel.Location = new System.Drawing.Point(352, 181);
            this.SchaddLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SchaddLabel.Name = "SchaddLabel";
            this.SchaddLabel.Size = new System.Drawing.Size(88, 13);
            this.SchaddLabel.TabIndex = 22;
            this.SchaddLabel.Text = "Schadstoffklasse";
            // 
            // HubText
            // 
            this.HubText.Location = new System.Drawing.Point(453, 139);
            this.HubText.Margin = new System.Windows.Forms.Padding(2);
            this.HubText.Name = "HubText";
            this.HubText.Size = new System.Drawing.Size(100, 20);
            this.HubText.TabIndex = 23;
            // 
            // Leistungstext
            // 
            this.Leistungstext.Location = new System.Drawing.Point(453, 161);
            this.Leistungstext.Margin = new System.Windows.Forms.Padding(2);
            this.Leistungstext.Name = "Leistungstext";
            this.Leistungstext.Size = new System.Drawing.Size(100, 20);
            this.Leistungstext.TabIndex = 24;
            // 
            // SchadstoffklasseTextBox
            // 
            this.SchadstoffklasseTextBox.Location = new System.Drawing.Point(453, 181);
            this.SchadstoffklasseTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SchadstoffklasseTextBox.Name = "SchadstoffklasseTextBox";
            this.SchadstoffklasseTextBox.Size = new System.Drawing.Size(100, 20);
            this.SchadstoffklasseTextBox.TabIndex = 25;
            // 
            // SteuerLabel
            // 
            this.SteuerLabel.AutoSize = true;
            this.SteuerLabel.Location = new System.Drawing.Point(352, 203);
            this.SteuerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SteuerLabel.Name = "SteuerLabel";
            this.SteuerLabel.Size = new System.Drawing.Size(38, 13);
            this.SteuerLabel.TabIndex = 26;
            this.SteuerLabel.Text = "Steuer";
            // 
            // SteuertextBox
            // 
            this.SteuertextBox.Location = new System.Drawing.Point(453, 203);
            this.SteuertextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SteuertextBox.Name = "SteuertextBox";
            this.SteuertextBox.Size = new System.Drawing.Size(100, 20);
            this.SteuertextBox.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Speicher";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Speichere_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(99, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Schließen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Schließe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 503);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SteuertextBox);
            this.Controls.Add(this.SteuerLabel);
            this.Controls.Add(this.SchadstoffklasseTextBox);
            this.Controls.Add(this.Leistungstext);
            this.Controls.Add(this.HubText);
            this.Controls.Add(this.SchaddLabel);
            this.Controls.Add(this.Leistunglabel);
            this.Controls.Add(this.Hubraumlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ZuladungTextBox);
            this.Controls.Add(this.AchsenTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AchsenTextBox;
        private System.Windows.Forms.TextBox ZuladungTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Hubraumlabel;
        private System.Windows.Forms.Label Leistunglabel;
        private System.Windows.Forms.Label SchaddLabel;
        private System.Windows.Forms.TextBox HubText;
        private System.Windows.Forms.TextBox Leistungstext;
        private System.Windows.Forms.TextBox SchadstoffklasseTextBox;
        private System.Windows.Forms.Label SteuerLabel;
        private System.Windows.Forms.TextBox SteuertextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

