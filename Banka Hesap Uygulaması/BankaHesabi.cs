using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Hesap_Uygulaması
{
    public class BankaHesabi
    {
        public long HesapNumarasi {  get; set; }
        public string MusteriAdi { get; set; }
        public decimal Bakiye { get; private set; }

        public BankaHesabi(long hesapnumarasi, string musteriadi, decimal bakiye)
        {
            HesapNumarasi = hesapnumarasi;
            MusteriAdi = musteriadi;
            Bakiye = bakiye;
        }

        public void ParaEkleme(decimal para)
        {
            if (para > 0 && para <= Bakiye)
            {
                Bakiye += para;
                Console.WriteLine("{0} TL bakiyenize eklenmiştir." ,para);
            }
            else
            {
                Console.WriteLine("Hatalı işlem yaptınız lütfen tekrar deneyiniz.");
            }
        }

        public void ParaCekme(decimal para)
        {
            if (para > 0)
            {
                Bakiye -= para;
                Console.WriteLine("{0} TL bakiyenizden çekilmiştir.",para);
            }
            else
            {
                Console.WriteLine("Hatalı işlem yaptınız lütfen tekrar deneyiniz.");
            }
        }

        public void HesapOzeti()
        {
            Console.WriteLine("Hesap Numarası: {0}",HesapNumarasi);
            Console.WriteLine("Müşteri Adı: {0}",MusteriAdi);
            Console.WriteLine("Bakiye: {0}",Bakiye);
        }
    }
}
