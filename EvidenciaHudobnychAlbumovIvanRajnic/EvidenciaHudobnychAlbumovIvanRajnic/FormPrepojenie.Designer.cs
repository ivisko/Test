namespace EvidenciaHudobnychAlbumovIvanRajnic
{
    partial class FormPrepojenie
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
            this.comboBoxSkupina = new System.Windows.Forms.ComboBox();
            this.labelSkupina = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.comboBoxAlbum = new System.Windows.Forms.ComboBox();
            this.buttonPrirad = new System.Windows.Forms.Button();
            this.groupBoxPridelenie = new System.Windows.Forms.GroupBox();
            this.buttonZmazPridelenyAlbum = new System.Windows.Forms.Button();
            this.groupBoxPriradenie = new System.Windows.Forms.GroupBox();
            this.listBoxSkupinyPreAlbumy = new System.Windows.Forms.ListBox();
            this.comBoZobrazSkupinyPreAlbum = new System.Windows.Forms.ComboBox();
            this.listBoxAlbumyPreSkupinu = new System.Windows.Forms.ListBox();
            this.comBoZobrazAlbumyPreSkupinu = new System.Windows.Forms.ComboBox();
            this.groupBoxPridelenie.SuspendLayout();
            this.groupBoxPriradenie.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSkupina
            // 
            this.comboBoxSkupina.FormattingEnabled = true;
            this.comboBoxSkupina.Location = new System.Drawing.Point(50, 24);
            this.comboBoxSkupina.Name = "comboBoxSkupina";
            this.comboBoxSkupina.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSkupina.TabIndex = 0;
            this.comboBoxSkupina.SelectedIndexChanged += new System.EventHandler(this.comboBoxSkupina_SelectedIndexChanged);
            // 
            // labelSkupina
            // 
            this.labelSkupina.AutoSize = true;
            this.labelSkupina.Location = new System.Drawing.Point(6, 27);
            this.labelSkupina.Name = "labelSkupina";
            this.labelSkupina.Size = new System.Drawing.Size(38, 13);
            this.labelSkupina.TabIndex = 1;
            this.labelSkupina.Text = "Skupina";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(4, 57);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(40, 13);
            this.labelAlbum.TabIndex = 2;
            this.labelAlbum.Text = "Album";
            // 
            // comboBoxAlbum
            // 
            this.comboBoxAlbum.FormattingEnabled = true;
            this.comboBoxAlbum.Location = new System.Drawing.Point(50, 54);
            this.comboBoxAlbum.Name = "comboBoxAlbum";
            this.comboBoxAlbum.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlbum.TabIndex = 3;
            this.comboBoxAlbum.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbum_SelectedIndexChanged);
            // 
            // buttonPrirad
            // 
            this.buttonPrirad.Location = new System.Drawing.Point(191, 22);
            this.buttonPrirad.Name = "buttonPrirad";
            this.buttonPrirad.Size = new System.Drawing.Size(99, 23);
            this.buttonPrirad.TabIndex = 4;
            this.buttonPrirad.Text = "Priraď album";
            this.buttonPrirad.UseVisualStyleBackColor = true;
            this.buttonPrirad.Click += new System.EventHandler(this.buttonPrirad_Click);
            // 
            // groupBoxPridelenie
            // 
            this.groupBoxPridelenie.Controls.Add(this.buttonZmazPridelenyAlbum);
            this.groupBoxPridelenie.Controls.Add(this.labelSkupina);
            this.groupBoxPridelenie.Controls.Add(this.buttonPrirad);
            this.groupBoxPridelenie.Controls.Add(this.comboBoxSkupina);
            this.groupBoxPridelenie.Controls.Add(this.comboBoxAlbum);
            this.groupBoxPridelenie.Controls.Add(this.labelAlbum);
            this.groupBoxPridelenie.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPridelenie.Name = "groupBoxPridelenie";
            this.groupBoxPridelenie.Size = new System.Drawing.Size(330, 96);
            this.groupBoxPridelenie.TabIndex = 5;
            this.groupBoxPridelenie.TabStop = false;
            this.groupBoxPridelenie.Text = "Priradenie Albumu";
            // 
            // buttonZmazPridelenyAlbum
            // 
            this.buttonZmazPridelenyAlbum.Location = new System.Drawing.Point(191, 52);
            this.buttonZmazPridelenyAlbum.Name = "buttonZmazPridelenyAlbum";
            this.buttonZmazPridelenyAlbum.Size = new System.Drawing.Size(99, 23);
            this.buttonZmazPridelenyAlbum.TabIndex = 5;
            this.buttonZmazPridelenyAlbum.Text = "Zmaž Pridelený album";
            this.buttonZmazPridelenyAlbum.UseVisualStyleBackColor = true;
            this.buttonZmazPridelenyAlbum.Click += new System.EventHandler(this.buttonZmazPridelenyAlbum_Click);
            // 
            // groupBoxPriradenie
            // 
            this.groupBoxPriradenie.Controls.Add(this.listBoxSkupinyPreAlbumy);
            this.groupBoxPriradenie.Controls.Add(this.comBoZobrazSkupinyPreAlbum);
            this.groupBoxPriradenie.Controls.Add(this.listBoxAlbumyPreSkupinu);
            this.groupBoxPriradenie.Controls.Add(this.comBoZobrazAlbumyPreSkupinu);
            this.groupBoxPriradenie.Location = new System.Drawing.Point(12, 130);
            this.groupBoxPriradenie.Name = "groupBoxPriradenie";
            this.groupBoxPriradenie.Size = new System.Drawing.Size(330, 237);
            this.groupBoxPriradenie.TabIndex = 6;
            this.groupBoxPriradenie.TabStop = false;
            this.groupBoxPriradenie.Text = "Zobrazenie priradených albumov";
            // 
            // listBoxSkupinyPreAlbum
            // 
            this.listBoxSkupinyPreAlbumy.FormattingEnabled = true;
            this.listBoxSkupinyPreAlbumy.Location = new System.Drawing.Point(191, 67);
            this.listBoxSkupinyPreAlbumy.Name = "listBoxSkupinyPreAlbum";
            this.listBoxSkupinyPreAlbumy.Size = new System.Drawing.Size(120, 147);
            this.listBoxSkupinyPreAlbumy.TabIndex = 4;
            // 
            // comBoZobrazSkupinyPreAlbum
            // 
            this.comBoZobrazSkupinyPreAlbum.FormattingEnabled = true;
            this.comBoZobrazSkupinyPreAlbum.Location = new System.Drawing.Point(191, 29);
            this.comBoZobrazSkupinyPreAlbum.Name = "comBoZobrazSkupinyPreAlbum";
            this.comBoZobrazSkupinyPreAlbum.Size = new System.Drawing.Size(121, 21);
            this.comBoZobrazSkupinyPreAlbum.TabIndex = 3;
            this.comBoZobrazSkupinyPreAlbum.Text = "Vyber album";
            this.comBoZobrazSkupinyPreAlbum.SelectedIndexChanged += new System.EventHandler(this.comboBoxZobrazAlbum_SelectedIndexChanged);
            // 
            // listBoxAlbumyPreSkupinu
            // 
            this.listBoxAlbumyPreSkupinu.FormattingEnabled = true;
            this.listBoxAlbumyPreSkupinu.Location = new System.Drawing.Point(10, 67);
            this.listBoxAlbumyPreSkupinu.Name = "listBoxAlbumyPreSkupinu";
            this.listBoxAlbumyPreSkupinu.Size = new System.Drawing.Size(120, 147);
            this.listBoxAlbumyPreSkupinu.TabIndex = 2;
            // 
            // comboBoxZobrazAlbumyPreOsobu
            // 
            this.comBoZobrazAlbumyPreSkupinu.FormattingEnabled = true;
            this.comBoZobrazAlbumyPreSkupinu.Location = new System.Drawing.Point(9, 29);
            this.comBoZobrazAlbumyPreSkupinu.Name = "comboBoxZobrazAlbumyPreOsobu";
            this.comBoZobrazAlbumyPreSkupinu.Size = new System.Drawing.Size(121, 21);
            this.comBoZobrazAlbumyPreSkupinu.TabIndex = 1;
            this.comBoZobrazAlbumyPreSkupinu.Text = "Vyber skupinu";
            this.comBoZobrazAlbumyPreSkupinu.SelectedIndexChanged += new System.EventHandler(this.comboBoxBoZobraz_SelectedIndexChanged);
            // 
            // FormPrepojenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 366);
            this.Controls.Add(this.groupBoxPriradenie);
            this.Controls.Add(this.groupBoxPridelenie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPrepojenie";
            this.Text = "Priradené albumy";
            this.groupBoxPridelenie.ResumeLayout(false);
            this.groupBoxPridelenie.PerformLayout();
            this.groupBoxPriradenie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSkupina;
        private System.Windows.Forms.Label labelSkupina;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.ComboBox comboBoxAlbum;
        private System.Windows.Forms.Button buttonPrirad;
        private System.Windows.Forms.GroupBox groupBoxPridelenie;
        private System.Windows.Forms.GroupBox groupBoxPriradenie;
        private System.Windows.Forms.ListBox listBoxAlbumyPreSkupinu;
        private System.Windows.Forms.ComboBox comBoZobrazAlbumyPreSkupinu;
        private System.Windows.Forms.ComboBox comBoZobrazSkupinyPreAlbum;
        private System.Windows.Forms.ListBox listBoxSkupinyPreAlbumy;
        private System.Windows.Forms.Button buttonZmazPridelenyAlbum;
    }
}