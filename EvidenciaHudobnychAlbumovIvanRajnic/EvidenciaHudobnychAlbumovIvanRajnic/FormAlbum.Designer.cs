namespace EvidenciaHudobnychAlbumovIvanRajnic
{
    partial class FormAlbum
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
            this.groupBoxHladaj = new System.Windows.Forms.GroupBox();
            this.textBoxHladaj = new System.Windows.Forms.TextBox();
            this.buttonHladaj = new System.Windows.Forms.Button();
            this.groupBoxTriedenie = new System.Windows.Forms.GroupBox();
            this.buttonTriedenieCislo = new System.Windows.Forms.Button();
            this.buttonTriedenieDatum = new System.Windows.Forms.Button();
            this.buttonTriedenieNazov = new System.Windows.Forms.Button();
            this.buttonZmaz = new System.Windows.Forms.Button();
            this.buttonUprav = new System.Windows.Forms.Button();
            this.listViewAlbumy = new System.Windows.Forms.ListView();
            this.colHeCislo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeNazov = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeZaner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHePopis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPridaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxHladaj.SuspendLayout();
            this.groupBoxTriedenie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHladaj
            // 
            this.groupBoxHladaj.Controls.Add(this.textBoxHladaj);
            this.groupBoxHladaj.Controls.Add(this.buttonHladaj);
            this.groupBoxHladaj.Location = new System.Drawing.Point(12, 258);
            this.groupBoxHladaj.Name = "groupBoxHladaj";
            this.groupBoxHladaj.Size = new System.Drawing.Size(701, 51);
            this.groupBoxHladaj.TabIndex = 11;
            this.groupBoxHladaj.TabStop = false;
            this.groupBoxHladaj.Text = "Vyhľadávanie podla názvu";
            // 
            // textBoxHladaj
            // 
            this.textBoxHladaj.Location = new System.Drawing.Point(6, 20);
            this.textBoxHladaj.Name = "textBoxHladaj";
            this.textBoxHladaj.Size = new System.Drawing.Size(590, 20);
            this.textBoxHladaj.TabIndex = 5;
            // 
            // buttonHladaj
            // 
            this.buttonHladaj.Location = new System.Drawing.Point(602, 17);
            this.buttonHladaj.Name = "buttonHladaj";
            this.buttonHladaj.Size = new System.Drawing.Size(88, 23);
            this.buttonHladaj.TabIndex = 4;
            this.buttonHladaj.Text = "Hľadaj";
            this.buttonHladaj.UseVisualStyleBackColor = true;
            this.buttonHladaj.Click += new System.EventHandler(this.buttonHladaj_Click);
            // 
            // groupBoxTriedenie
            // 
            this.groupBoxTriedenie.Controls.Add(this.buttonTriedenieCislo);
            this.groupBoxTriedenie.Controls.Add(this.buttonTriedenieDatum);
            this.groupBoxTriedenie.Controls.Add(this.buttonTriedenieNazov);
            this.groupBoxTriedenie.Location = new System.Drawing.Point(621, 136);
            this.groupBoxTriedenie.Name = "groupBoxTriedenie";
            this.groupBoxTriedenie.Size = new System.Drawing.Size(92, 116);
            this.groupBoxTriedenie.TabIndex = 10;
            this.groupBoxTriedenie.TabStop = false;
            this.groupBoxTriedenie.Text = "Triediť podľa:";
            // 
            // buttonTriedenieCislo
            // 
            this.buttonTriedenieCislo.Location = new System.Drawing.Point(6, 19);
            this.buttonTriedenieCislo.Name = "buttonTriedenieCislo";
            this.buttonTriedenieCislo.Size = new System.Drawing.Size(75, 23);
            this.buttonTriedenieCislo.TabIndex = 3;
            this.buttonTriedenieCislo.Text = "Čísla";
            this.buttonTriedenieCislo.UseVisualStyleBackColor = true;
            this.buttonTriedenieCislo.Click += new System.EventHandler(this.buttonTriedenieCislo_Click);
            // 
            // buttonTriedenieDatum
            // 
            this.buttonTriedenieDatum.Location = new System.Drawing.Point(6, 77);
            this.buttonTriedenieDatum.Name = "buttonTriedenieDatum";
            this.buttonTriedenieDatum.Size = new System.Drawing.Size(75, 23);
            this.buttonTriedenieDatum.TabIndex = 2;
            this.buttonTriedenieDatum.Text = "Dátumu";
            this.buttonTriedenieDatum.UseVisualStyleBackColor = true;
            this.buttonTriedenieDatum.Click += new System.EventHandler(this.buttonTriedenieDatum_Click);
            // 
            // buttonTriedenieNazov
            // 
            this.buttonTriedenieNazov.Location = new System.Drawing.Point(6, 48);
            this.buttonTriedenieNazov.Name = "buttonTriedenieNazov";
            this.buttonTriedenieNazov.Size = new System.Drawing.Size(75, 23);
            this.buttonTriedenieNazov.TabIndex = 1;
            this.buttonTriedenieNazov.Text = "Názvu";
            this.buttonTriedenieNazov.UseVisualStyleBackColor = true;
            this.buttonTriedenieNazov.Click += new System.EventHandler(this.buttonTriedenieNazov_Click);
            // 
            // buttonZmaz
            // 
            this.buttonZmaz.Location = new System.Drawing.Point(6, 77);
            this.buttonZmaz.Name = "buttonZmaz";
            this.buttonZmaz.Size = new System.Drawing.Size(75, 23);
            this.buttonZmaz.TabIndex = 9;
            this.buttonZmaz.Text = "Zmaž";
            this.buttonZmaz.UseVisualStyleBackColor = true;
            this.buttonZmaz.Click += new System.EventHandler(this.buttonZmaz_Click);
            // 
            // buttonUprav
            // 
            this.buttonUprav.Location = new System.Drawing.Point(6, 48);
            this.buttonUprav.Name = "buttonUprav";
            this.buttonUprav.Size = new System.Drawing.Size(75, 23);
            this.buttonUprav.TabIndex = 8;
            this.buttonUprav.Text = "Uprav";
            this.buttonUprav.UseVisualStyleBackColor = true;
            this.buttonUprav.Click += new System.EventHandler(this.buttonUprav_Click);
            // 
            // listViewAlbumy
            // 
            this.listViewAlbumy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAlbumy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeCislo,
            this.colHeNazov,
            this.colHeDatum,
            this.colHeZaner,
            this.colHePopis});
            this.listViewAlbumy.FullRowSelect = true;
            this.listViewAlbumy.GridLines = true;
            this.listViewAlbumy.Location = new System.Drawing.Point(12, 12);
            this.listViewAlbumy.Name = "listViewAlbumy";
            this.listViewAlbumy.Size = new System.Drawing.Size(603, 240);
            this.listViewAlbumy.TabIndex = 7;
            this.listViewAlbumy.UseCompatibleStateImageBehavior = false;
            this.listViewAlbumy.View = System.Windows.Forms.View.Details;
            // 
            // colHeCislo
            // 
            this.colHeCislo.Text = "Číslo";
            this.colHeCislo.Width = 53;
            // 
            // colHeNazov
            // 
            this.colHeNazov.Text = "Názov";
            this.colHeNazov.Width = 126;
            // 
            // colHeDatum
            // 
            this.colHeDatum.Text = "Dátum";
            this.colHeDatum.Width = 94;
            // 
            // colHeZaner
            // 
            this.colHeZaner.Text = "Zaner";
            this.colHeZaner.Width = 223;
            // 
            // colHePopis
            // 
            this.colHePopis.Text = "Popis";
            this.colHePopis.Width = 99;
            // 
            // buttonPridaj
            // 
            this.buttonPridaj.Location = new System.Drawing.Point(6, 19);
            this.buttonPridaj.Name = "buttonPridaj";
            this.buttonPridaj.Size = new System.Drawing.Size(75, 23);
            this.buttonPridaj.TabIndex = 6;
            this.buttonPridaj.Text = "Pridaj";
            this.buttonPridaj.UseVisualStyleBackColor = true;
            this.buttonPridaj.Click += new System.EventHandler(this.buttonPridaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPridaj);
            this.groupBox1.Controls.Add(this.buttonUprav);
            this.groupBox1.Controls.Add(this.buttonZmaz);
            this.groupBox1.Location = new System.Drawing.Point(621, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 118);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Úpravy";
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxHladaj);
            this.Controls.Add(this.groupBoxTriedenie);
            this.Controls.Add(this.listViewAlbumy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAlbum";
            this.Text = "Správa albumov";
            this.groupBoxHladaj.ResumeLayout(false);
            this.groupBoxHladaj.PerformLayout();
            this.groupBoxTriedenie.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHladaj;
        private System.Windows.Forms.TextBox textBoxHladaj;
        private System.Windows.Forms.Button buttonHladaj;
        private System.Windows.Forms.GroupBox groupBoxTriedenie;
        private System.Windows.Forms.Button buttonTriedenieCislo;
        private System.Windows.Forms.Button buttonTriedenieDatum;
        private System.Windows.Forms.Button buttonTriedenieNazov;
        private System.Windows.Forms.Button buttonZmaz;
        private System.Windows.Forms.Button buttonUprav;
        private System.Windows.Forms.ListView listViewAlbumy;
        private System.Windows.Forms.ColumnHeader colHeCislo;
        private System.Windows.Forms.ColumnHeader colHeNazov;
        private System.Windows.Forms.ColumnHeader colHeDatum;
        private System.Windows.Forms.ColumnHeader colHeZaner;
        private System.Windows.Forms.ColumnHeader colHePopis;
        private System.Windows.Forms.Button buttonPridaj;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}