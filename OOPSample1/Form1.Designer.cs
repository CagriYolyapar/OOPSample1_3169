namespace OOPSample1
{
    partial class Form1
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
            this.txtKategoriIsmi = new System.Windows.Forms.TextBox();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.lstKategoriler = new System.Windows.Forms.ListBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKategoriIsmi
            // 
            this.txtKategoriIsmi.Location = new System.Drawing.Point(32, 54);
            this.txtKategoriIsmi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKategoriIsmi.Name = "txtKategoriIsmi";
            this.txtKategoriIsmi.Size = new System.Drawing.Size(124, 28);
            this.txtKategoriIsmi.TabIndex = 0;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(32, 131);
            this.btnKategoriEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(145, 32);
            this.btnKategoriEkle.TabIndex = 1;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.ItemHeight = 22;
            this.lstKategoriler.Location = new System.Drawing.Point(245, 54);
            this.lstKategoriler.Margin = new System.Windows.Forms.Padding(4);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(604, 488);
            this.lstKategoriler.TabIndex = 2;
            this.lstKategoriler.Click += new System.EventHandler(this.lstKategoriler_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategori.Location = new System.Drawing.Point(241, 578);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(598, 44);
            this.lblKategori.TabIndex = 3;
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(899, 54);
            this.btnForm2.Margin = new System.Windows.Forms.Padding(4);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(155, 38);
            this.btnForm2.TabIndex = 4;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 657);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lstKategoriler);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.txtKategoriIsmi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKategoriIsmi;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.ListBox lstKategoriler;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnForm2;
    }
}

