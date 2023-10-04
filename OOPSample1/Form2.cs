using OOPSample1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSample1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(ListBox.ObjectCollection kategoriler)
        {
            InitializeComponent();
            foreach (Kategori item in kategoriler)
            {
                cmbKategoriler.Items.Add(item);
            }

        }
        public Form2(List<Kategori> kategoriler)
        {
            InitializeComponent();
            foreach (Kategori item in kategoriler)
            {
                cmbKategoriler.Items.Add(item);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //cmbKategoriler.Items.Add("asdasd");
            //cmbKategoriler.SelectedItem
            //cmbKategoriler.SelectedIndex
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategoriler.SelectedIndex > -1)
            {
                lblKategori.Text = (cmbKategoriler.SelectedItem as Kategori).Isim;
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbKategoriler.SelectedIndex > -1)
                {
                    Urun u = new Urun(txtUrunIsmi.Text, Convert.ToDecimal(txtFiyat.Text), cmbKategoriler.SelectedItem as Kategori);
                    (cmbKategoriler.SelectedItem as Kategori).Urunleri.Add(u);
                }
                else
                {
                    MessageBox.Show("Lutfen önce Kategori seciniz");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void lstUrunler_Click(object sender, EventArgs e)
        {
            if(lstUrunler.SelectedIndex > -1)
            {
                lblUrun.Text = (lstUrunler.SelectedItem as Urun).BilgiGoster();
            }
        }
    }
}
