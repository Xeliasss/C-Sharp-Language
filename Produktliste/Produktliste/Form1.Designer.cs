namespace Produktliste
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
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxArtNr = new System.Windows.Forms.TextBox();
            this.textBoxArtBezeichnung = new System.Windows.Forms.TextBox();
            this.textBoxArtPreis = new System.Windows.Forms.TextBox();
            this.textBoxArtKategorie = new System.Windows.Forms.TextBox();
            this.textBoxArtLagerbestand = new System.Windows.Forms.TextBox();
            this.listBoxArtikel = new System.Windows.Forms.ListBox();
            this.buttonCsv = new System.Windows.Forms.Button();
            this.buttonloeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(171, 467);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 29);
            this.add.TabIndex = 0;
            this.add.Text = "Speichern";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artikel Nr.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artikel Bezeichnung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Artikel Preis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Artikel Kategorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Artikel Lagerbestand";
            // 
            // textBoxArtNr
            // 
            this.textBoxArtNr.Location = new System.Drawing.Point(171, 72);
            this.textBoxArtNr.Name = "textBoxArtNr";
            this.textBoxArtNr.Size = new System.Drawing.Size(92, 20);
            this.textBoxArtNr.TabIndex = 6;
            // 
            // textBoxArtBezeichnung
            // 
            this.textBoxArtBezeichnung.Location = new System.Drawing.Point(171, 117);
            this.textBoxArtBezeichnung.Name = "textBoxArtBezeichnung";
            this.textBoxArtBezeichnung.Size = new System.Drawing.Size(92, 20);
            this.textBoxArtBezeichnung.TabIndex = 7;
            // 
            // textBoxArtPreis
            // 
            this.textBoxArtPreis.Location = new System.Drawing.Point(171, 175);
            this.textBoxArtPreis.Name = "textBoxArtPreis";
            this.textBoxArtPreis.Size = new System.Drawing.Size(92, 20);
            this.textBoxArtPreis.TabIndex = 8;
            // 
            // textBoxArtKategorie
            // 
            this.textBoxArtKategorie.Location = new System.Drawing.Point(171, 237);
            this.textBoxArtKategorie.Name = "textBoxArtKategorie";
            this.textBoxArtKategorie.Size = new System.Drawing.Size(92, 20);
            this.textBoxArtKategorie.TabIndex = 9;
            // 
            // textBoxArtLagerbestand
            // 
            this.textBoxArtLagerbestand.Location = new System.Drawing.Point(171, 293);
            this.textBoxArtLagerbestand.Name = "textBoxArtLagerbestand";
            this.textBoxArtLagerbestand.Size = new System.Drawing.Size(92, 20);
            this.textBoxArtLagerbestand.TabIndex = 10;
            // 
            // listBoxArtikel
            // 
            this.listBoxArtikel.FormattingEnabled = true;
            this.listBoxArtikel.Location = new System.Drawing.Point(648, 72);
            this.listBoxArtikel.Name = "listBoxArtikel";
            this.listBoxArtikel.Size = new System.Drawing.Size(215, 251);
            this.listBoxArtikel.TabIndex = 11;
            this.listBoxArtikel.SelectedIndexChanged += new System.EventHandler(this.listBoxArtikel_SelectedIndexChanged);
            // 
            // buttonCsv
            // 
            this.buttonCsv.Location = new System.Drawing.Point(691, 467);
            this.buttonCsv.Name = "buttonCsv";
            this.buttonCsv.Size = new System.Drawing.Size(127, 29);
            this.buttonCsv.TabIndex = 12;
            this.buttonCsv.Text = "CSV";
            this.buttonCsv.UseVisualStyleBackColor = true;
            this.buttonCsv.Click += new System.EventHandler(this.buttonCsv_Click);
            // 
            // buttonloeschen
            // 
            this.buttonloeschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonloeschen.Location = new System.Drawing.Point(418, 469);
            this.buttonloeschen.Name = "buttonloeschen";
            this.buttonloeschen.Size = new System.Drawing.Size(102, 27);
            this.buttonloeschen.TabIndex = 13;
            this.buttonloeschen.Text = "Löschen";
            this.buttonloeschen.UseVisualStyleBackColor = true;
            this.buttonloeschen.Click += new System.EventHandler(this.buttonloeschen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1106, 566);
            this.Controls.Add(this.buttonloeschen);
            this.Controls.Add(this.buttonCsv);
            this.Controls.Add(this.listBoxArtikel);
            this.Controls.Add(this.textBoxArtLagerbestand);
            this.Controls.Add(this.textBoxArtKategorie);
            this.Controls.Add(this.textBoxArtPreis);
            this.Controls.Add(this.textBoxArtBezeichnung);
            this.Controls.Add(this.textBoxArtNr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxArtNr;
        private System.Windows.Forms.TextBox textBoxArtBezeichnung;
        private System.Windows.Forms.TextBox textBoxArtPreis;
        private System.Windows.Forms.TextBox textBoxArtKategorie;
        private System.Windows.Forms.TextBox textBoxArtLagerbestand;
        private System.Windows.Forms.ListBox listBoxArtikel;
        private System.Windows.Forms.Button buttonCsv;
        private System.Windows.Forms.Button buttonloeschen;
    }
}

