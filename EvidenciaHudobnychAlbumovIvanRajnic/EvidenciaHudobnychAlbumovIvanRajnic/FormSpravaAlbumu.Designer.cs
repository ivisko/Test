namespace EvidenciaHudobnychAlbumovIvanRajnic
{
    partial class FormSpravaAlbumu
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
            this.textBoxPopis = new System.Windows.Forms.TextBox();
            this.labelPopis = new System.Windows.Forms.Label();
            this.textBoxSpolocnost = new System.Windows.Forms.TextBox();
            this.labelZaner = new System.Windows.Forms.Label();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.labelDatum = new System.Windows.Forms.Label();
            this.textBoxNazov = new System.Windows.Forms.TextBox();
            this.labelNazov = new System.Windows.Forms.Label();
            this.textBoxCislo = new System.Windows.Forms.TextBox();
            this.labelCislo = new System.Windows.Forms.Label();
            this.buttonUloz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPopis
            // 
            this.textBoxPopis.Location = new System.Drawing.Point(111, 116);
            this.textBoxPopis.Multiline = true;
            this.textBoxPopis.Name = "textPopis";
            this.textBoxPopis.Size = new System.Drawing.Size(200, 66);
            this.textBoxPopis.TabIndex = 23;
            // 
            // labelPopis
            // 
            this.labelPopis.AutoSize = true;
            this.labelPopis.Location = new System.Drawing.Point(11, 119);
            this.labelPopis.Name = "labelPopis";
            this.labelPopis.Size = new System.Drawing.Size(36, 13);
            this.labelPopis.TabIndex = 22;
            this.labelPopis.Text = "Popis:";
            // 
            // textBoxSpolocnost
            // 
            this.textBoxSpolocnost.Location = new System.Drawing.Point(111, 90);
            this.textBoxSpolocnost.Name = "textBoxSpolocnost";
            this.textBoxSpolocnost.Size = new System.Drawing.Size(200, 20);
            this.textBoxSpolocnost.TabIndex = 21;
            // 
            // labelZaner
            // 
            this.labelZaner.AutoSize = true;
            this.labelZaner.Location = new System.Drawing.Point(11, 93);
            this.labelZaner.Name = "labelZaner";
            this.labelZaner.Size = new System.Drawing.Size(64, 13);
            this.labelZaner.TabIndex = 20;
            this.labelZaner.Text = "Zaner:";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(111, 64);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatum.TabIndex = 19;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(11, 67);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(81, 13);
            this.labelDatum.TabIndex = 18;
            this.labelDatum.Text = "Dátum nahrania:";
            // 
            // textNazov
            // 
            this.textBoxNazov.Location = new System.Drawing.Point(111, 38);
            this.textBoxNazov.Name = "textNazov";
            this.textBoxNazov.Size = new System.Drawing.Size(200, 20);
            this.textBoxNazov.TabIndex = 17;
            // 
            // labelNazov
            // 
            this.labelNazov.AutoSize = true;
            this.labelNazov.Location = new System.Drawing.Point(11, 41);
            this.labelNazov.Name = "labelNazov";
            this.labelNazov.Size = new System.Drawing.Size(41, 13);
            this.labelNazov.TabIndex = 16;
            this.labelNazov.Text = "Názov:";
            // 
            // textCislo
            // 
            this.textBoxCislo.Location = new System.Drawing.Point(111, 12);
            this.textBoxCislo.Name = "textCislo";
            this.textBoxCislo.Size = new System.Drawing.Size(200, 20);
            this.textBoxCislo.TabIndex = 15;
            // 
            // labelCislo
            // 
            this.labelCislo.AutoSize = true;
            this.labelCislo.Location = new System.Drawing.Point(11, 15);
            this.labelCislo.Name = "labelCislo";
            this.labelCislo.Size = new System.Drawing.Size(34, 13);
            this.labelCislo.TabIndex = 14;
            this.labelCislo.Text = "Číslo:";
            // 
            // buttonUloz
            // 
            this.buttonUloz.Location = new System.Drawing.Point(153, 188);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Size = new System.Drawing.Size(75, 23);
            this.buttonUloz.TabIndex = 13;
            this.buttonUloz.Text = "Ulož";
            this.buttonUloz.UseVisualStyleBackColor = true;
            this.buttonUloz.Click += new System.EventHandler(this.buttonUloz_Click);
            // 
            // FormSpravaAlbumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 222);
            this.Controls.Add(this.textBoxPopis);
            this.Controls.Add(this.labelPopis);
            this.Controls.Add(this.textBoxSpolocnost);
            this.Controls.Add(this.labelZaner);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.textBoxNazov);
            this.Controls.Add(this.labelNazov);
            this.Controls.Add(this.textBoxCislo);
            this.Controls.Add(this.labelCislo);
            this.Controls.Add(this.buttonUloz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSpravaAlbumu";
            this.Text = "Správa Albumu";
            this.Load += new System.EventHandler(this.FormSpravaAlbumu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPopis;
        private System.Windows.Forms.Label labelPopis;
        private System.Windows.Forms.TextBox textBoxSpolocnost;
        private System.Windows.Forms.Label labelZaner;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.TextBox textBoxNazov;
        private System.Windows.Forms.Label labelNazov;
        private System.Windows.Forms.TextBox textBoxCislo;
        private System.Windows.Forms.Label labelCislo;
        private System.Windows.Forms.Button buttonUloz;
    }
}