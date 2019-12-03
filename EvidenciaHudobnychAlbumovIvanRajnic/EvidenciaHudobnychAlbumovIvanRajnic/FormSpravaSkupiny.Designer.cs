namespace EvidenciaHudobnychAlbumovIvanRajnic
{
    partial class FormSpravaSkupiny
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
            this.buttonUloz = new System.Windows.Forms.Button();
            this.labelNazov = new System.Windows.Forms.Label();
            this.textBoxNazov = new System.Windows.Forms.TextBox();
            this.textBoxAgent = new System.Windows.Forms.TextBox();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelDatumZalozenia = new System.Windows.Forms.Label();
            this.dateTimePickerDatumZalozenia = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUloz
            // 
            this.buttonUloz.Location = new System.Drawing.Point(141, 215);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Size = new System.Drawing.Size(75, 23);
            this.buttonUloz.TabIndex = 0;
            this.buttonUloz.Text = "Ulož";
            this.buttonUloz.UseVisualStyleBackColor = true;
            this.buttonUloz.Click += new System.EventHandler(this.btnUloz_Click);
            // 
            // labelNazov
            // 
            this.labelNazov.AutoSize = true;
            this.labelNazov.Location = new System.Drawing.Point(12, 15);
            this.labelNazov.Name = "labelNazov";
            this.labelNazov.Size = new System.Drawing.Size(37, 13);
            this.labelNazov.TabIndex = 1;
            this.labelNazov.Text = "Nazov:";
            // 
            // textBoxNazov
            // 
            this.textBoxNazov.Location = new System.Drawing.Point(112, 12);
            this.textBoxNazov.Name = "textBoxNazov";
            this.textBoxNazov.Size = new System.Drawing.Size(200, 20);
            this.textBoxNazov.TabIndex = 2;
            // 
            // textBoxAgent
            // 
            this.textBoxAgent.Location = new System.Drawing.Point(112, 38);
            this.textBoxAgent.Name = "textBoxAgent";
            this.textBoxAgent.Size = new System.Drawing.Size(200, 20);
            this.textBoxAgent.TabIndex = 4;
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(12, 41);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(58, 13);
            this.labelAgent.TabIndex = 3;
            this.labelAgent.Text = "Agent:";
            // 
            // labelDatumZalozenia
            // 
            this.labelDatumZalozenia.AutoSize = true;
            this.labelDatumZalozenia.Location = new System.Drawing.Point(12, 67);
            this.labelDatumZalozenia.Name = "labelDatumZalozenia";
            this.labelDatumZalozenia.Size = new System.Drawing.Size(91, 13);
            this.labelDatumZalozenia.TabIndex = 5;
            this.labelDatumZalozenia.Text = "Dátum zalozenia:";
            // 
            // dateTimePickerNarodenie
            // 
            this.dateTimePickerDatumZalozenia.Location = new System.Drawing.Point(112, 64);
            this.dateTimePickerDatumZalozenia.Name = "dateTimePickerNarodenie";
            this.dateTimePickerDatumZalozenia.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatumZalozenia.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(112, 90);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmail.TabIndex = 8;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 93);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(112, 116);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(200, 20);
            this.textBoxAdresa.TabIndex = 10;
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(12, 119);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(43, 13);
            this.labelAdresa.TabIndex = 9;
            this.labelAdresa.Text = "Adresa:";
            // 
            // textBoxInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(112, 142);
            this.textInfo.Multiline = true;
            this.textInfo.Name = "textBoxInfo";
            this.textInfo.Size = new System.Drawing.Size(200, 67);
            this.textInfo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Info:";
            // 
            // FormSpravaKapely
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 247);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.dateTimePickerDatumZalozenia);
            this.Controls.Add(this.labelDatumZalozenia);
            this.Controls.Add(this.textBoxAgent);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.textBoxNazov);
            this.Controls.Add(this.labelNazov);
            this.Controls.Add(this.buttonUloz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSpravaSkupiny";
            this.Text = "Správa Skupiny";
            this.Load += new System.EventHandler(this.FormPridanieSkupiny_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUloz;
        private System.Windows.Forms.Label labelNazov;
        private System.Windows.Forms.TextBox textBoxNazov;
        private System.Windows.Forms.TextBox textBoxAgent;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelDatumZalozenia;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumZalozenia;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.Label label1;
    }
}