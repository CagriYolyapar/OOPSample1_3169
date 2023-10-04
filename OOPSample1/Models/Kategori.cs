using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample1.Models
{
    public class Kategori
    {
        public Kategori(string isim)
        {
            Isim = isim;
            Urunleri = new List<Urun>();
        }
        public string Isim { get; set; }
        public List<Urun> Urunleri { get; set; }

    }
}
