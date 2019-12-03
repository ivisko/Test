namespace EvidenciaHudobnychAlbumovIvanRajnic
{
    partial class FormHlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHlavna));
            this.pictureBoxKapela = new System.Windows.Forms.PictureBox();
            this.picBoxAlbum = new System.Windows.Forms.PictureBox();
            this.picBoxPriradenie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKapela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPriradenie)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxKapela
            // 
            this.pictureBoxKapela.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxKapela.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKapela.Image")));
            this.pictureBoxKapela.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxKapela.Name = "pictureBoxKapela";
            this.pictureBoxKapela.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxKapela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxKapela.TabIndex = 0;
            this.pictureBoxKapela.TabStop = false;
            this.pictureBoxKapela.Click += new System.EventHandler(this.pictureBoxSkupina_Click);
            // 
            // picBoxAlbum
            // 
            this.picBoxAlbum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBoxAlbum.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAlbum.Image")));
            this.picBoxAlbum.Location = new System.Drawing.Point(146, 12);
            this.picBoxAlbum.Name = "picBoxAlbum";
            this.picBoxAlbum.Size = new System.Drawing.Size(128, 128);
            this.picBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxAlbum.TabIndex = 1;
            this.picBoxAlbum.TabStop = false;
            this.picBoxAlbum.Click += new System.EventHandler(this.picBoxAlbum_Click);
            // 
            // picBoxPriradenie
            // 
            this.picBoxPriradenie.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picBoxPriradenie.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPriradenie.Image")));
            this.picBoxPriradenie.Location = new System.Drawing.Point(280, 12);
            this.picBoxPriradenie.Name = "picBoxPriradenie";
            this.picBoxPriradenie.Size = new System.Drawing.Size(128, 128);
            this.picBoxPriradenie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxPriradenie.TabIndex = 2;
            this.picBoxPriradenie.TabStop = false;
            this.picBoxPriradenie.Click += new System.EventHandler(this.picBoxPriradenie_Click);
            // 
            // FormHlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 153);
            this.Controls.Add(this.picBoxPriradenie);
            this.Controls.Add(this.picBoxAlbum);
            this.Controls.Add(this.pictureBoxKapela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHlavna";
            this.Text = "Evidencia albumov : Ivan Rajnic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKapela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPriradenie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKapela;
        private System.Windows.Forms.PictureBox picBoxAlbum;
        private System.Windows.Forms.PictureBox picBoxPriradenie;
    }
}

