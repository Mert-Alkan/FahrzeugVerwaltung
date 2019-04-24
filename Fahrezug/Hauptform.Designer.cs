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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.Fahrzeuge = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PKW = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.msdPKW = new System.Windows.Forms.MaskedTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.PlzLabel = new System.Windows.Forms.Label();
            this.Ortlabel = new System.Windows.Forms.Label();
            this.PlzTextBox = new System.Windows.Forms.TextBox();
            this.OrttxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AdresseTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Fahrzeug = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Fahrzeuge.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // FahrzeugListBox
            // 
            this.FahrzeugListBox.FormattingEnabled = true;
            this.FahrzeugListBox.ItemHeight = 25;
            this.FahrzeugListBox.Location = new System.Drawing.Point(0, 0);
            this.FahrzeugListBox.Margin = new System.Windows.Forms.Padding(4);
            this.FahrzeugListBox.Name = "FahrzeugListBox";
            this.FahrzeugListBox.Size = new System.Drawing.Size(801, 479);
            this.FahrzeugListBox.TabIndex = 0;
            this.FahrzeugListBox.SelectedIndexChanged += new System.EventHandler(this.FahrzeugListe_SelectedIndexChanged);
            // 
            // FahrzeugHinzufügen_Button
            // 
            this.FahrzeugHinzufügen_Button.Location = new System.Drawing.Point(579, 716);
            this.FahrzeugHinzufügen_Button.Margin = new System.Windows.Forms.Padding(4);
            this.FahrzeugHinzufügen_Button.Name = "FahrzeugHinzufügen_Button";
            this.FahrzeugHinzufügen_Button.Size = new System.Drawing.Size(246, 40);
            this.FahrzeugHinzufügen_Button.TabIndex = 1;
            this.FahrzeugHinzufügen_Button.Text = "Fahrzeug Hinzufügen";
            this.FahrzeugHinzufügen_Button.UseVisualStyleBackColor = true;
            this.FahrzeugHinzufügen_Button.Click += new System.EventHandler(this.FahrzeugHinzufügen_Button_Click);
            // 
            // LöschButton
            // 
            this.LöschButton.Location = new System.Drawing.Point(995, 716);
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
            this.textBox1.Location = new System.Drawing.Point(1108, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 31);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1108, 91);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 31);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1108, 134);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 31);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1108, 177);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(196, 31);
            this.textBox4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(943, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kennzeichen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(890, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Anschaffungspreis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(925, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Erstzulassung";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 716);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Suchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Suchen_Klick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 716);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "berechne";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Berechne_Steuerschuld);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(925, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Achsenanzahl";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // AchsenTextBox
            // 
            this.AchsenTextBox.Location = new System.Drawing.Point(1108, 218);
            this.AchsenTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AchsenTextBox.Name = "AchsenTextBox";
            this.AchsenTextBox.Size = new System.Drawing.Size(196, 31);
            this.AchsenTextBox.TabIndex = 17;
            // 
            // ZuladungTextBox
            // 
            this.ZuladungTextBox.Location = new System.Drawing.Point(1108, 257);
            this.ZuladungTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ZuladungTextBox.Name = "ZuladungTextBox";
            this.ZuladungTextBox.Size = new System.Drawing.Size(196, 31);
            this.ZuladungTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(971, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Zuladung";
            // 
            // Hubraumlabel
            // 
            this.Hubraumlabel.AutoSize = true;
            this.Hubraumlabel.Location = new System.Drawing.Point(971, 296);
            this.Hubraumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hubraumlabel.Name = "Hubraumlabel";
            this.Hubraumlabel.Size = new System.Drawing.Size(99, 25);
            this.Hubraumlabel.TabIndex = 20;
            this.Hubraumlabel.Text = "Hubraum";
            // 
            // Leistunglabel
            // 
            this.Leistunglabel.AutoSize = true;
            this.Leistunglabel.Location = new System.Drawing.Point(990, 338);
            this.Leistunglabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Leistunglabel.Name = "Leistunglabel";
            this.Leistunglabel.Size = new System.Drawing.Size(94, 25);
            this.Leistunglabel.TabIndex = 21;
            this.Leistunglabel.Text = "Leistung";
            this.Leistunglabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SchaddLabel
            // 
            this.SchaddLabel.AutoSize = true;
            this.SchaddLabel.Location = new System.Drawing.Point(920, 374);
            this.SchaddLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SchaddLabel.Name = "SchaddLabel";
            this.SchaddLabel.Size = new System.Drawing.Size(176, 25);
            this.SchaddLabel.TabIndex = 22;
            this.SchaddLabel.Text = "Schadstoffklasse";
            // 
            // HubText
            // 
            this.HubText.Location = new System.Drawing.Point(1108, 296);
            this.HubText.Margin = new System.Windows.Forms.Padding(4);
            this.HubText.Name = "HubText";
            this.HubText.Size = new System.Drawing.Size(196, 31);
            this.HubText.TabIndex = 23;
            // 
            // Leistungstext
            // 
            this.Leistungstext.Location = new System.Drawing.Point(1108, 335);
            this.Leistungstext.Margin = new System.Windows.Forms.Padding(4);
            this.Leistungstext.Name = "Leistungstext";
            this.Leistungstext.Size = new System.Drawing.Size(196, 31);
            this.Leistungstext.TabIndex = 24;
            // 
            // SchadstoffklasseTextBox
            // 
            this.SchadstoffklasseTextBox.Location = new System.Drawing.Point(1108, 374);
            this.SchadstoffklasseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SchadstoffklasseTextBox.Name = "SchadstoffklasseTextBox";
            this.SchadstoffklasseTextBox.Size = new System.Drawing.Size(196, 31);
            this.SchadstoffklasseTextBox.TabIndex = 25;
            // 
            // SteuerLabel
            // 
            this.SteuerLabel.AutoSize = true;
            this.SteuerLabel.Location = new System.Drawing.Point(1002, 408);
            this.SteuerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SteuerLabel.Name = "SteuerLabel";
            this.SteuerLabel.Size = new System.Drawing.Size(75, 25);
            this.SteuerLabel.TabIndex = 26;
            this.SteuerLabel.Text = "Steuer";
            // 
            // SteuertextBox
            // 
            this.SteuertextBox.Location = new System.Drawing.Point(1108, 408);
            this.SteuertextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SteuertextBox.Name = "SteuertextBox";
            this.SteuertextBox.Size = new System.Drawing.Size(196, 31);
            this.SteuertextBox.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(835, 716);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 44);
            this.button4.TabIndex = 28;
            this.button4.Text = "Speicher";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Speichere_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1171, 716);
            this.button5.Margin = new System.Windows.Forms.Padding(6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 44);
            this.button5.TabIndex = 29;
            this.button5.Text = "Schließen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Schließe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(983, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modell";
            // 
            // Fahrzeuge
            // 
            this.Fahrzeuge.Controls.Add(this.tabPage1);
            this.Fahrzeuge.Controls.Add(this.tabPage2);
            this.Fahrzeuge.Controls.Add(this.tabPage3);
            this.Fahrzeuge.Location = new System.Drawing.Point(3, 0);
            this.Fahrzeuge.Name = "Fahrzeuge";
            this.Fahrzeuge.SelectedIndex = 0;
            this.Fahrzeuge.Size = new System.Drawing.Size(1435, 974);
            this.Fahrzeuge.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.FahrzeugHinzufügen_Button);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SteuerLabel);
            this.tabPage1.Controls.Add(this.LöschButton);
            this.tabPage1.Controls.Add(this.SteuertextBox);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.SchaddLabel);
            this.tabPage1.Controls.Add(this.FahrzeugListBox);
            this.tabPage1.Controls.Add(this.SchadstoffklasseTextBox);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.Leistungstext);
            this.tabPage1.Controls.Add(this.Leistunglabel);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.HubText);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Hubraumlabel);
            this.tabPage1.Controls.Add(this.AchsenTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ZuladungTextBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1419, 927);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fahrzeuge";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1108, 495);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(196, 31);
            this.textBox7.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(983, 495);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 25);
            this.label14.TabIndex = 32;
            this.label14.Text = "Parkplatz";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1108, 448);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(196, 31);
            this.textBox6.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(974, 448);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "Parkhaus";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.PKW);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.maskedTextBox3);
            this.tabPage2.Controls.Add(this.maskedTextBox2);
            this.tabPage2.Controls.Add(this.msdPKW);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.PlzLabel);
            this.tabPage2.Controls.Add(this.Ortlabel);
            this.tabPage2.Controls.Add(this.PlzTextBox);
            this.tabPage2.Controls.Add(this.OrttxtBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.AdresseTextBox);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1419, 927);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parkhaus";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(537, 307);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(981, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Motorrad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(915, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "LKW";
            // 
            // PKW
            // 
            this.PKW.AutoSize = true;
            this.PKW.Location = new System.Drawing.Point(844, 368);
            this.PKW.Name = "PKW";
            this.PKW.Size = new System.Drawing.Size(60, 25);
            this.PKW.TabIndex = 16;
            this.PKW.Text = "PKW";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Stellplätze für Pkw LKW und Motorräder";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(986, 402);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(36, 31);
            this.maskedTextBox3.TabIndex = 14;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(920, 402);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(39, 31);
            this.maskedTextBox2.TabIndex = 13;
            // 
            // msdPKW
            // 
            this.msdPKW.Location = new System.Drawing.Point(849, 399);
            this.msdPKW.Name = "msdPKW";
            this.msdPKW.Size = new System.Drawing.Size(35, 31);
            this.msdPKW.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(872, 561);
            this.button6.Margin = new System.Windows.Forms.Padding(6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 44);
            this.button6.TabIndex = 10;
            this.button6.Text = "Hinzufügen";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.HinzufügeButton);
            // 
            // PlzLabel
            // 
            this.PlzLabel.AutoSize = true;
            this.PlzLabel.Location = new System.Drawing.Point(636, 312);
            this.PlzLabel.Name = "PlzLabel";
            this.PlzLabel.Size = new System.Drawing.Size(123, 25);
            this.PlzLabel.TabIndex = 9;
            this.PlzLabel.Text = "Postleitzahl";
            // 
            // Ortlabel
            // 
            this.Ortlabel.AutoSize = true;
            this.Ortlabel.Location = new System.Drawing.Point(668, 233);
            this.Ortlabel.Name = "Ortlabel";
            this.Ortlabel.Size = new System.Drawing.Size(41, 25);
            this.Ortlabel.TabIndex = 8;
            this.Ortlabel.Text = "Ort";
            // 
            // PlzTextBox
            // 
            this.PlzTextBox.Location = new System.Drawing.Point(822, 309);
            this.PlzTextBox.Name = "PlzTextBox";
            this.PlzTextBox.Size = new System.Drawing.Size(200, 31);
            this.PlzTextBox.TabIndex = 7;
            // 
            // OrttxtBox
            // 
            this.OrttxtBox.Location = new System.Drawing.Point(822, 227);
            this.OrttxtBox.Name = "OrttxtBox";
            this.OrttxtBox.Size = new System.Drawing.Size(200, 31);
            this.OrttxtBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Adresse";
            // 
            // AdresseTextBox
            // 
            this.AdresseTextBox.Location = new System.Drawing.Point(822, 138);
            this.AdresseTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.AdresseTextBox.Name = "AdresseTextBox";
            this.AdresseTextBox.Size = new System.Drawing.Size(200, 31);
            this.AdresseTextBox.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.Fahrzeug);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1419, 927);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "zuweisung ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(430, 30);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 31);
            this.textBox5.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1070, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "plätze";
            // 
            // Fahrzeug
            // 
            this.Fahrzeug.AutoSize = true;
            this.Fahrzeug.Location = new System.Drawing.Point(281, 85);
            this.Fahrzeug.Name = "Fahrzeug";
            this.Fahrzeug.Size = new System.Drawing.Size(103, 25);
            this.Fahrzeug.TabIndex = 4;
            this.Fahrzeug.Text = "Fahrzeug";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(281, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Parkhaus";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(430, 160);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(430, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(903, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(388, 329);
            this.listBox1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 716);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 40);
            this.button3.TabIndex = 34;
            this.button3.Text = "Spiel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SpielButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 967);
            this.Controls.Add(this.Fahrzeuge);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SpeichernButton";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Fahrzeuge.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FahrzeugHinzufügen_Button;
        private System.Windows.Forms.Button LöschButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox FahrzeugListBox;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Fahrzeuge;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Ortlabel;
        private System.Windows.Forms.Label PlzLabel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox AdresseTextBox;
        private System.Windows.Forms.TextBox OrttxtBox;
        private System.Windows.Forms.TextBox PlzTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label PKW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox msdPKW;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Fahrzeug;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
    }
}

