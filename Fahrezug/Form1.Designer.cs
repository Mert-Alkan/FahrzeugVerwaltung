namespace Fahrezug
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
            this.FahrzeugListe = new System.Windows.Forms.ListBox();
            this.FahrzeugHinzufügen_Button = new System.Windows.Forms.Button();
            this.LöschButton = new System.Windows.Forms.Button();
            this.SpeicherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FahrzeugListe
            // 
            this.FahrzeugListe.FormattingEnabled = true;
            this.FahrzeugListe.ItemHeight = 25;
            this.FahrzeugListe.Location = new System.Drawing.Point(-2, -2);
            this.FahrzeugListe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FahrzeugListe.Name = "FahrzeugListe";
            this.FahrzeugListe.Size = new System.Drawing.Size(696, 654);
            this.FahrzeugListe.TabIndex = 0;
            this.FahrzeugListe.SelectedIndexChanged += new System.EventHandler(this.FahrzeugListe_SelectedIndexChanged);
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
            this.FahrzeugHinzufügen_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // LöschButton
            // 
            this.LöschButton.Location = new System.Drawing.Point(564, 712);
            this.LöschButton.Name = "LöschButton";
            this.LöschButton.Size = new System.Drawing.Size(149, 40);
            this.LöschButton.TabIndex = 2;
            this.LöschButton.Text = "Löschen ";
            this.LöschButton.UseVisualStyleBackColor = true;
            this.LöschButton.Click += new System.EventHandler(this.LöschButton_Click);
            // 
            // SpeicherButton
            // 
            this.SpeicherButton.Location = new System.Drawing.Point(341, 712);
            this.SpeicherButton.Name = "SpeicherButton";
            this.SpeicherButton.Size = new System.Drawing.Size(148, 40);
            this.SpeicherButton.TabIndex = 3;
            this.SpeicherButton.Text = "Speichern ";
            this.SpeicherButton.UseVisualStyleBackColor = true;
            this.SpeicherButton.Click += new System.EventHandler(this.SpeicherButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 968);
            this.Controls.Add(this.SpeicherButton);
            this.Controls.Add(this.LöschButton);
            this.Controls.Add(this.FahrzeugHinzufügen_Button);
            this.Controls.Add(this.FahrzeugListe);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "SpeichernButton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FahrzeugListe;
        private System.Windows.Forms.Button FahrzeugHinzufügen_Button;
        private System.Windows.Forms.Button LöschButton;
        private System.Windows.Forms.Button SpeicherButton;
    }
}

