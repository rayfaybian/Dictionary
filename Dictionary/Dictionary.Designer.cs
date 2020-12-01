namespace Dictionary
{
    partial class Dictionary
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
            this.tbGermanWord = new System.Windows.Forms.TextBox();
            this.tbTranslatedWord = new System.Windows.Forms.TextBox();
            this.lBoxGermanWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.btnExportToCsv = new System.Windows.Forms.Button();
            this.btnDeToEn = new System.Windows.Forms.Button();
            this.btnDeToDialekt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImportFromCSV = new System.Windows.Forms.Button();
            this.lBoxLetters = new System.Windows.Forms.ListBox();
            this.resetLetterSelection = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(119, 106);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(266, 22);
            this.tbGermanWord.TabIndex = 1;
            // 
            // tbTranslatedWord
            // 
            this.tbTranslatedWord.Location = new System.Drawing.Point(500, 106);
            this.tbTranslatedWord.Name = "tbTranslatedWord";
            this.tbTranslatedWord.Size = new System.Drawing.Size(266, 22);
            this.tbTranslatedWord.TabIndex = 2;
            // 
            // lBoxGermanWords
            // 
            this.lBoxGermanWords.FormattingEnabled = true;
            this.lBoxGermanWords.ItemHeight = 16;
            this.lBoxGermanWords.Location = new System.Drawing.Point(119, 266);
            this.lBoxGermanWords.Name = "lBoxGermanWords";
            this.lBoxGermanWords.Size = new System.Drawing.Size(266, 116);
            this.lBoxGermanWords.TabIndex = 8;
            this.lBoxGermanWords.SelectedIndexChanged += new System.EventHandler(this.lBoxGermanWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(500, 266);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(266, 22);
            this.tbTranslation.TabIndex = 9;
            // 
            // btnExportToCsv
            // 
            this.btnExportToCsv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportToCsv.Location = new System.Drawing.Point(500, 342);
            this.btnExportToCsv.Name = "btnExportToCsv";
            this.btnExportToCsv.Size = new System.Drawing.Size(266, 38);
            this.btnExportToCsv.TabIndex = 11;
            this.btnExportToCsv.Text = "Export CSV";
            this.btnExportToCsv.UseVisualStyleBackColor = true;
            this.btnExportToCsv.Click += new System.EventHandler(this.btnExportToCsv_Click);
            // 
            // btnDeToEn
            // 
            this.btnDeToEn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeToEn.Location = new System.Drawing.Point(390, 139);
            this.btnDeToEn.Name = "btnDeToEn";
            this.btnDeToEn.Size = new System.Drawing.Size(106, 24);
            this.btnDeToEn.TabIndex = 3;
            this.btnDeToEn.Text = "Englisch";
            this.btnDeToEn.UseVisualStyleBackColor = true;
            this.btnDeToEn.Click += new System.EventHandler(this.btnDeToEn_Click);
            // 
            // btnDeToDialekt
            // 
            this.btnDeToDialekt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeToDialekt.Location = new System.Drawing.Point(391, 175);
            this.btnDeToDialekt.Name = "btnDeToDialekt";
            this.btnDeToDialekt.Size = new System.Drawing.Size(106, 23);
            this.btnDeToDialekt.TabIndex = 4;
            this.btnDeToDialekt.Text = "Dialekt";
            this.btnDeToDialekt.UseVisualStyleBackColor = true;
            this.btnDeToDialekt.Click += new System.EventHandler(this.btnDeToDialekt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Deutsch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Übersetzung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Deutsch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Übersetzung";
            // 
            // btnImportFromCSV
            // 
            this.btnImportFromCSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportFromCSV.Location = new System.Drawing.Point(500, 294);
            this.btnImportFromCSV.Name = "btnImportFromCSV";
            this.btnImportFromCSV.Size = new System.Drawing.Size(266, 42);
            this.btnImportFromCSV.TabIndex = 10;
            this.btnImportFromCSV.Text = "Import CSV";
            this.btnImportFromCSV.UseVisualStyleBackColor = true;
            this.btnImportFromCSV.Click += new System.EventHandler(this.btnImportFromCSV_Click);
            // 
            // lBoxLetters
            // 
            this.lBoxLetters.FormattingEnabled = true;
            this.lBoxLetters.ItemHeight = 16;
            this.lBoxLetters.Location = new System.Drawing.Point(50, 266);
            this.lBoxLetters.Name = "lBoxLetters";
            this.lBoxLetters.Size = new System.Drawing.Size(63, 116);
            this.lBoxLetters.TabIndex = 7;
            this.lBoxLetters.SelectedIndexChanged += new System.EventHandler(this.lBoxLetters_SelectedIndexChanged);
            // 
            // resetLetterSelection
            // 
            this.resetLetterSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetLetterSelection.Location = new System.Drawing.Point(50, 210);
            this.resetLetterSelection.Name = "resetLetterSelection";
            this.resetLetterSelection.Size = new System.Drawing.Size(63, 23);
            this.resetLetterSelection.TabIndex = 5;
            this.resetLetterSelection.Text = "Alle";
            this.resetLetterSelection.UseVisualStyleBackColor = true;
            this.resetLetterSelection.Click += new System.EventHandler(this.resetLetterSelection_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(120, 210);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(265, 22);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Suchen";
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.resetLetterSelection);
            this.Controls.Add(this.lBoxLetters);
            this.Controls.Add(this.btnImportFromCSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeToDialekt);
            this.Controls.Add(this.btnDeToEn);
            this.Controls.Add(this.btnExportToCsv);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lBoxGermanWords);
            this.Controls.Add(this.tbTranslatedWord);
            this.Controls.Add(this.tbGermanWord);
            this.Name = "Dictionary";
            this.Text = "Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbGermanWord;
        private System.Windows.Forms.TextBox tbTranslatedWord;
        private System.Windows.Forms.ListBox lBoxGermanWords;
        private System.Windows.Forms.TextBox tbTranslation;
        private System.Windows.Forms.Button btnExportToCsv;
        private System.Windows.Forms.Button btnDeToEn;
        private System.Windows.Forms.Button btnDeToDialekt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImportFromCSV;
        private System.Windows.Forms.ListBox lBoxLetters;
        private System.Windows.Forms.Button resetLetterSelection;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label5;
    }
}

