using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Hesap_Uygulaması
{
    public class Musteri
    {
        public string MusteriAd {  get; set; }
        public string MusteriSoyad { get; set; }
        public int MusteriYas {  get; set; }

        public Musteri(string musteriad, string musterisoyad, int musteriyas )
        {
            MusteriAd = musteriad;
            MusteriSoyad = musterisoyad;
            MusteriYas = musteriyas;
        }
    }
}
