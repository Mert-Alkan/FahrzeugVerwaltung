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
            this.SuspendLayout();
            // 
            // FahrzeugListBox
            // 
            this.FahrzeugListBox.FormattingEnabled = true;
            this.FahrzeugListBox.ItemHeight = 25;
            this.FahrzeugListBox.Location = new System.Drawing.Point(-2, -2);
            this.FahrzeugListBox.Margin = new System.Windows.Forms.Padding(4);
            this.FahrzeugListBox.Name = "FahrzeugListBox";
            this.FahrzeugListBox.Size = new System.Drawing.Size(696, 654);
            this.FahrzeugListBox.TabIndex = 0;
            this.FahrzeugListBox.SelectedIndexChanged += new System.EventHandler(this.FahrzeugListe_SelectedIndexChanged);
            // 
            // FahrzeugHinzufügen_Button
            // 
            this.FahrzeugHinzufügen_Button.Location = new System.Drawing.Point(772, 712);
            this.FahrzeugHinzufügen_Button.Margin = new System.Windows.Forms.Padding(4);
            this.FahrzeugHinzufügen_Button.Name = "FahrzeugHinzufügen_Button";
            this.FahrzeugHinzufügen_Button.Size = new System.Drawing.Size(344, 40);
            this.FahrzeugHinzufügen_Button.TabIndex = 1;
            this.FahrzeugHinzufügen_Button.Text = "Fahrzeug Hinzufügen";
            this.FahrzeugHinzufügen_Button.UseVisualStyleBackColor = true;
            this.FahrzeugHinzufügen_Button.Click += new System.EventHandler(this.FahrzeugHinzufügen_Button_Click);
            // 
            // LöschButton
            // 
            this.LöschButton.Location = new System.Drawing.Point(580, 712);
            this.LöschButton.Margin = new System.Windows.Forms.Padding(4);
            this.LöschButton.Name = "LöschButton";
            this.LöschButton.Size = new System.Drawing.Size(148, 40);
            this.LöschButton.TabIndex = 2;
            this.LöschButton.Text = "Löschen ";
            this.LöschButton.UseVisualStyleBackColor = true;
            this.LöschButton.Click += new System.EventHandler(this.LöschButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(906, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 31);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(906, 68);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 31);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(906, 108);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 31);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(906, 151);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(196, 31);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kennzeichen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Anschaffungspreis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Erstzulassung";
            // 
            // BearbeitenButton
            // 
            this.BearbeitenButton.Location = new System.Drawing.Point(404, 712);
            this.BearbeitenButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Suchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Suchen_Klick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 708);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "berechne";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Berechne_Steuerschuld);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1196, 706);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "Parkhaus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnParkhausHinzufügen_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Achsenanzahl";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // AchsenTextBox
            // 
            this.AchsenTextBox.Location = new System.Drawing.Point(906, 191);
            this.AchsenTextBox.Name = "AchsenTextBox";
            this.AchsenTextBox.Size = new System.Drawing.Size(196, 31);
            this.AchsenTextBox.TabIndex = 17;
            // 
            // ZuladungTextBox
            // 
            this.ZuladungTextBox.Location = new System.Drawing.Point(906, 228);
            this.ZuladungTextBox.Name = "ZuladungTextBox";
            this.ZuladungTextBox.Size = new System.Drawing.Size(196, 31);
            this.ZuladungTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Zuladung";
            // 
            // Hubraumlabel
            // 
            this.Hubraumlabel.AutoSize = true;
            this.Hubraumlabel.Location = new System.Drawing.Point(704, 268);
            this.Hubraumlabel.Name = "Hubraumlabel";
            this.Hubraumlabel.Size = new System.Drawing.Size(99, 25);
            this.Hubraumlabel.TabIndex = 20;
            this.Hubraumlabel.Text = "Hubraum";
            // 
            // Leistunglabel
            // 
            this.Leistunglabel.AutoSize = true;
            this.Leistunglabel.Location = new System.Drawing.Point(704, 309);
            this.Leistunglabel.Name = "Leistunglabel";
            this.Leistunglabel.Size = new System.Drawing.Size(94, 25);
            this.Leistunglabel.TabIndex = 21;
            this.Leistunglabel.Text = "Leistung";
            this.Leistunglabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SchaddLabel
            // 
            this.SchaddLabel.AutoSize = true;
            this.SchaddLabel.Location = new System.Drawing.Point(704, 349);
            this.SchaddLabel.Name = "SchaddLabel";
            this.SchaddLabel.Size = new System.Drawing.Size(176, 25);
            this.SchaddLabel.TabIndex = 22;
            this.SchaddLabel.Text = "Schadstoffklasse";
            // 
            // HubText
            // 
            this.HubText.Location = new System.Drawing.Point(906, 268);
            this.HubText.Name = "HubText";
            this.HubText.Size = new System.Drawing.Size(196, 31);
            this.HubText.TabIndex = 23;
            // 
            // Leistungstext
            // 
            this.Leistungstext.Location = new System.Drawing.Point(906, 309);
            this.Leistungstext.Name = "Leistungstext";
            this.Leistungstext.Size = new System.Drawing.Size(196, 31);
            this.Leistungstext.TabIndex = 24;
            // 
            // SchadstoffklasseTextBox
            // 
            this.SchadstoffklasseTextBox.Location = new System.Drawing.Point(906, 349);
            this.SchadstoffklasseTextBox.Name = "SchadstoffklasseTextBox";
            this.SchadstoffklasseTextBox.Size = new System.Drawing.Size(196, 31);
            this.SchadstoffklasseTextBox.TabIndex = 25;
            // 
            // SteuerLabel
            // 
            this.SteuerLabel.AutoSize = true;
            this.SteuerLabel.Location = new System.Drawing.Point(704, 391);
            this.SteuerLabel.Name = "SteuerLabel";
            this.SteuerLabel.Size = new System.Drawing.Size(75, 25);
            this.SteuerLabel.TabIndex = 26;
            this.SteuerLabel.Text = "Steuer";
            // 
            // SteuertextBox
            // 
            this.SteuertextBox.Location = new System.Drawing.Point(906, 391);
            this.SteuertextBox.Name = "SteuertextBox";
            this.SteuertextBox.Size = new System.Drawing.Size(196, 31);
            this.SteuertextBox.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 967);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

