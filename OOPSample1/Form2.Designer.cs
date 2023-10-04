namespace OOPSample1
{
    partial class Form2
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
            this.txtUrunIsmi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUrunIsmi
            // 
            this.txtUrunIsmi.Location = new System.Drawing.Point(31, 31);
            this.txtUrunIsmi.Name = "txtUrunIsmi";
            this.txtUrunIsmi.Size = new System.Drawing.Size(121, 22);
            this.txtUrunIsmi.TabIndex = 0;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(31, 81);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(121, 22);
            this.txtFiyat.TabIndex = 0;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(31, 135);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(121, 24);
            this.cmbKategoriler.TabIndex = 1;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // lblKategori
            // 
            this.lblKategori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKategori.Location = new System.Drawing.Point(28, 198);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(141, 27);
            this.lblKategori.TabIndex = 2;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(21, 251);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(174, 38);
            this.btnUrunEkle.TabIndex = 3;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 16;
            this.lstUrunler.Location = new System.Drawing.Point(284, 31);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(420, 276);
            this.lstUrunler.TabIndex = 4;
            this.lstUrunler.Click += new System.EventHandler(this.lstUrunler_Click);
            // 
            // lblUrun
            // 
            this.lblUrun.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUrun.Location = new System.Drawing.Point(281, 350);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(423, 67);
            this.lblUrun.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtUrunIsmi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrunIsmi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Label lblUrun;
    }
}