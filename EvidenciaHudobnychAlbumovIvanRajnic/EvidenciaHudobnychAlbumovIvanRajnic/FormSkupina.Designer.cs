namespace EvidenciaHudobnychAlbumovIvanRajnic
{
    partial class FormSkupina
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
            this.buttonPridaj = new System.Windows.Forms.Button();
            this.listViewSkupiny = new System.Windows.Forms.ListView();
            this.colHeNazov = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeAgent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeDatumZalozenia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonUprav = new System.Windows.Forms.Button();
            this.buttonZmaz = new System.Windows.Forms.Button();
            this.groupBoxTriedenie = new System.Windows.Forms.GroupBox();
            this.buttonTriedenieEmail = new System.Windows.Forms.Button();
            this.buttonTriedenieNarodenie = new System.Windows.Forms.Button();
            this.buttonTriedeniePriezvisko = new System.Windows.Forms.Button();
            this.groupBoxHladaj = new System.Windows.Forms.GroupBox();
            this.textBoxHladaj = new System.Windows.Forms.TextBox();
            this.buttonHladaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTriedenie.SuspendLayout();
            this.groupBoxHladaj.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPridaj
            // 
            this.buttonPridaj.Location = new System.Drawing.Point(6, 19);
            this.buttonPridaj.Name = "buttonPridaj";
            this.buttonPridaj.Size = new System.Drawing.Size(75, 23);
            this.buttonPridaj.TabIndex = 0;
            this.buttonPridaj.Text = "Pridaj";
            this.buttonPridaj.UseVisualStyleBackColor = true;
            this.buttonPridaj.Click += new System.EventHandler(this.buttonPridaj_Click);
            // 
            // listViewSkupiny
            // 
            this.listViewSkupiny.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSkupiny.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeNazov,
            this.colHeAgent,
            this.colHeDatumZalozenia,
            this.colHeEmail,
            this.colHeAdresa,
            this.colHeInfo});
            this.listViewSkupiny.FullRowSelect = true;
            this.listViewSkupiny.GridLines = true;
            this.listViewSkupiny.Location = new System.Drawing.Point(12, 12);
            this.listViewSkupiny.Name = "listViewSkupiny";
            this.listViewSkupiny.Size = new System.Drawing.Size(635, 240);
            this.listViewSkupiny.TabIndex = 1;
            this.listViewSkupiny.UseCompatibleStateImageBehavior = false;
            this.listViewSkupiny.View = System.Windows.Forms.View.Details;
            // 
            // colHeNazov
            // 
            this.colHeNazov.Text = "Nazov";
            this.colHeNazov.Width = 77;
            // 
            // colHeAgent
            // 
            this.colHeAgent.Text = "Agent";
            this.colHeAgent.Width = 87;
            // 
            // colHeDatumZalozenia
            // 
            this.colHeDatumZalozenia.Text = "Datum Zalozenia";
            this.colHeDatumZalozenia.Width = 95;
            // 
            // colHeEmail
            // 
            this.colHeEmail.Text = "Email";
            this.colHeEmail.Width = 166;
            // 
            // colHeAdresa
            // 
            this.colHeAdresa.Text = "Adresa";
            this.colHeAdresa.Width = 82;
            // 
            // colHeInfo
            // 
            this.colHeInfo.Text = "Info";
            this.colHeInfo.Width = 120;
            // 
            // buttonUprav
            // 
            this.buttonUprav.Location = new System.Drawing.Point(6, 48);
            this.buttonUprav.Name = "buttonUprav";
            this.buttonUprav.Size = new System.Drawing.Size(75, 23);
            this.buttonUprav.TabIndex = 1;
            this.buttonUprav.Text = "Uprav";
            this.buttonUprav.UseVisualStyleBackColor = true;
            this.buttonUprav.Click += new System.EventHandler(this.buttonUprav_Click);
            // 
            // buttonZmaz
            // 
            this.buttonZmaz.Location = new System.Drawing.Point(6, 77);
            this.buttonZmaz.Name = "buttonZmaz";
            this.buttonZmaz.Size = new System.Drawing.Size(75, 23);
            this.buttonZmaz.TabIndex = 2;
            this.buttonZmaz.Text = "Zmaž";
            this.buttonZmaz.UseVisualStyleBackColor = true;
            this.buttonZmaz.Click += new System.EventHandler(this.buttonZmaz_Click);
            // 
            // groupBoxTriedenie
            // 
            this.groupBoxTriedenie.Controls.Add(this.buttonTriedenieEmail);
            this.groupBoxTriedenie.Controls.Add(this.buttonTriedenieNarodenie);
            this.groupBoxTriedenie.Controls.Add(this.buttonTriedeniePriezvisko);
            this.groupBoxTriedenie.Location = new System.Drawing.Point(653, 128);
            this.groupBoxTriedenie.Name = "groupBoxTriedenie";
            this.groupBoxTriedenie.Size = new System.Drawing.Size(85, 124);
            this.groupBoxTriedenie.TabIndex = 4;
            this.groupBoxTriedenie.TabStop = false;
            this.groupBoxTriedenie.Text = "Triediť podľa:";
            // 
            // buttonTriedenieEmail
            // 
            this.buttonTriedenieEmail.Location = new System.Drawing.Point(6, 77);
            this.buttonTriedenieEmail.Name = "buttonTriedenieEmail";
            this.buttonTriedenieEmail.Size = new System.Drawing.Size(75, 23);
            this.buttonTriedenieEmail.TabIndex = 7;
            this.buttonTriedenieEmail.Text = "Emailu";
            this.buttonTriedenieEmail.UseVisualStyleBackColor = true;
            this.buttonTriedenieEmail.Click += new System.EventHandler(this.btnTriedenieEmail_Click);
            // 
            // buttonTriedenieNarodenie
            // 
            this.buttonTriedenieNarodenie.Location = new System.Drawing.Point(6, 48);
            this.buttonTriedenieNarodenie.Name = "buttonTriedenieNarodenie";
            this.buttonTriedenieNarodenie.Size = new System.Drawing.Size(75, 23);
            this.buttonTriedenieNarodenie.TabIndex = 6;
            this.buttonTriedenieNarodenie.Text = "Datum Zalozenia";
            this.buttonTriedenieNarodenie.UseVisualStyleBackColor = true;
            this.buttonTriedenieNarodenie.Click += new System.EventHandler(this.buttonTriedenieNarodenie_Click);
            // 
            // buttonTriedeniePriezvisko
            // 
            this.buttonTriedeniePriezvisko.Location = new System.Drawing.Point(6, 19);
            this.buttonTriedeniePriezvisko.Name = "buttonTriedeniePriezvisko";
            this.buttonTriedeniePriezvisko.Size = new System.Drawing.Size(75, 23);
            this.buttonTriedeniePriezvisko.TabIndex = 5;
            this.buttonTriedeniePriezvisko.Text = "Nazvu";
            this.buttonTriedeniePriezvisko.UseVisualStyleBackColor = true;
            this.buttonTriedeniePriezvisko.Click += new System.EventHandler(this.buttonTriedenieNazov_Click);
            // 
            // groupBoxHladaj
            // 
            this.groupBoxHladaj.Controls.Add(this.textBoxHladaj);
            this.groupBoxHladaj.Controls.Add(this.buttonHladaj);
            this.groupBoxHladaj.Location = new System.Drawing.Point(12, 258);
            this.groupBoxHladaj.Name = "groupBoxHladaj";
            this.groupBoxHladaj.Size = new System.Drawing.Size(732, 51);
            this.groupBoxHladaj.TabIndex = 5;
            this.groupBoxHladaj.TabStop = false;
            this.groupBoxHladaj.Text = "Vyhľadávanie podľa nazvu";
            // 
            // textBoxHladaj
            // 
            this.textBoxHladaj.Location = new System.Drawing.Point(6, 20);
            this.textBoxHladaj.Name = "textBoxHladaj";
            this.textBoxHladaj.Size = new System.Drawing.Size(629, 20);
            this.textBoxHladaj.TabIndex = 3;
            // 
            // buttonHladaj
            // 
            this.buttonHladaj.Location = new System.Drawing.Point(651, 17);
            this.buttonHladaj.Name = "buttonHladaj";
            this.buttonHladaj.Size = new System.Drawing.Size(75, 23);
            this.buttonHladaj.TabIndex = 4;
            this.buttonHladaj.Text = "Hľadaj";
            this.buttonHladaj.UseVisualStyleBackColor = true;
            this.buttonHladaj.Click += new System.EventHandler(this.buttonHladaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPridaj);
            this.groupBox1.Controls.Add(this.buttonUprav);
            this.groupBox1.Controls.Add(this.buttonZmaz);
            this.groupBox1.Location = new System.Drawing.Point(653, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Úpravy";
            // 
            // FormSkupina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxHladaj);
            this.Controls.Add(this.groupBoxTriedenie);
            this.Controls.Add(this.listViewSkupiny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSkupina";
            this.Text = "Sprváva skupin";
            this.groupBoxTriedenie.ResumeLayout(false);
            this.groupBoxHladaj.ResumeLayout(false);
            this.groupBoxHladaj.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPridaj;
        private System.Windows.Forms.ListView listViewSkupiny;
        private System.Windows.Forms.ColumnHeader colHeNazov;
        private System.Windows.Forms.ColumnHeader colHeAgent;
        private System.Windows.Forms.ColumnHeader colHeDatumZalozenia;
        private System.Windows.Forms.ColumnHeader colHeEmail;
        private System.Windows.Forms.ColumnHeader colHeAdresa;
        private System.Windows.Forms.ColumnHeader colHeInfo;
        private System.Windows.Forms.Button buttonUprav;
        private System.Windows.Forms.Button buttonZmaz;
        private System.Windows.Forms.GroupBox groupBoxTriedenie;
        private System.Windows.Forms.Button buttonTriedeniePriezvisko;
        private System.Windows.Forms.Button buttonTriedenieNarodenie;
        private System.Windows.Forms.Button buttonTriedenieEmail;
        private System.Windows.Forms.GroupBox groupBoxHladaj;
        private System.Windows.Forms.TextBox textBoxHladaj;
        private System.Windows.Forms.Button buttonHladaj;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}