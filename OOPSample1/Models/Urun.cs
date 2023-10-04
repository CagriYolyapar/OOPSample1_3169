using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSample1.Models
{
    public class Urun
    {

       
        public Urun(string isim, decimal fiyat, Kategori kategori)
        {
            Isim = isim;
            Fiyat = fiyat;
            Kategori = kategori;

        
        }

        public string Isim { get; set; }
        public decimal Fiyat { get; set; }
        public Kategori Kategori { get; set; }

        public string BilgiGoster()
        {

            return $"{Isim}, {Fiyat}..Kategorisi => {Kategori.Isim}";
        }

    }
}
