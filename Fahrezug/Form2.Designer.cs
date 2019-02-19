namespace Fahrezug
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Hersteller = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Fahrzeug = new System.Windows.Forms.ComboBox();
            this.Modell = new System.Windows.Forms.TextBox();
            this.Kennzeichen = new System.Windows.Forms.TextBox();
            this.Anschaffungspreis = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.81235F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.18765F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Anschaffungspreis, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Kennzeichen, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Modell, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Hersteller, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Fahrzeug, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(134, 79);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 569);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Hersteller
            // 
            this.Hersteller.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Hersteller.AutoSize = true;
            this.Hersteller.Location = new System.Drawing.Point(153, 45);
            this.Hersteller.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Hersteller.Name = "Hersteller";
            this.Hersteller.Size = new System.Drawing.Size(103, 25);
            this.Hersteller.TabIndex = 0;
            this.Hersteller.Text = "Fahrzeug";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hersteller";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modell";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kennzeichen";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Anschaffungspreis";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(533, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 31);
            this.textBox1.TabIndex = 3;
            // 
            // Fahrzeug
            // 
            this.Fahrzeug.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fahrzeug.FormattingEnabled = true;
            this.Fahrzeug.Items.AddRange(new object[] {
            "PKW",
            "LKW",
            "Motorräder"});
            this.Fahrzeug.Location = new System.Drawing.Point(534, 41);
            this.Fahrzeug.Margin = new System.Windows.Forms.Padding(6);
            this.Fahrzeug.Name = "Fahrzeug";
            this.Fahrzeug.Size = new System.Drawing.Size(184, 33);
            this.Fahrzeug.TabIndex = 1;
            this.Fahrzeug.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Modell
            // 
            this.Modell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modell.Location = new System.Drawing.Point(533, 262);
            this.Modell.Name = "Modell";
            this.Modell.Size = new System.Drawing.Size(185, 31);
            this.Modell.TabIndex = 1;
            // 
            // Kennzeichen
            // 
            this.Kennzeichen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Kennzeichen.Location = new System.Drawing.Point(534, 359);
            this.Kennzeichen.Name = "Kennzeichen";
            this.Kennzeichen.Size = new System.Drawing.Size(183, 31);
            this.Kennzeichen.TabIndex = 1;
            // 
            // Anschaffungspreis
            // 
            this.Anschaffungspreis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Anschaffungspreis.Location = new System.Drawing.Point(535, 482);
            this.Anschaffungspreis.Name = "Anschaffungspreis";
            this.Anschaffungspreis.Size = new System.Drawing.Size(182, 31);
            this.Anschaffungspreis.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Hersteller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Anschaffungspreis;
        private System.Windows.Forms.TextBox Kennzeichen;
        private System.Windows.Forms.TextBox Modell;
        private System.Windows.Forms.ComboBox Fahrzeug;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}