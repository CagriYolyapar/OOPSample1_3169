using OOPSample1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSample1
{
    public partial class Form1 : Form
    {
        //Form2 frm2 = new Form2();
        //frm2.ShowDialog();
        public Form1()
        {
            InitializeComponent();
        }

        //İlk Form'da Kategori Ismini textbox'tan alıp ListBox'a Kategori Eklenmesini saglayın...Bu ListBox'tan bir eleman seciline lblKategori'ye Kategori Ismi yazsın...Form2'ye basınca Form2'ye gecilsin ve Form1'de eklenmiş olan kategoriler Form2 Combobox'inde gözüksün ve bu combobox'tan bir eleman secildiginde ilgili kategori ismi altındaki lblKategori'de gözüksün...Ürün ismi ve fiyatı girilip , combobox'tan category secilerek ürün listbox'a eklensin...lblUrun'de ListBox'ta secilen ürünün ismi fiyatı ve Kategori ismi gözüksün...

        private void Form1_Load(object sender, EventArgs e)
        {
            //lstKategoriler.Items.Add("asd");
            //kategoriler = new List<Kategori>();
        }


        //List<Kategori> kategoriler;

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (txtKategoriIsmi.Text.Trim() != "") //bizi space bosluklarıyla kandıramasınlar illa bir isim girmek zorunda kalsınlar diye bu sekilde bir karar mekanizması kullandık...
            {
                Kategori k = new Kategori(txtKategoriIsmi.Text);
                lstKategoriler.Items.Add(k);
                //kategoriler.Add(k);

              
            }
        }

        private void lstKategoriler_Click(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedIndex > -1)
            {
                lblKategori.Text = (lstKategoriler.SelectedItem as Kategori).Isim;
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            

         
          

            Form2 frm2 = new Form2(lstKategoriler.Items);
            frm2.ShowDialog();
        }
    }
}
