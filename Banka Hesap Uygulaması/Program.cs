using Banka_Hesap_Uygulaması;

Musteri musteri = new Musteri("Berkan","İrez",23);
Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " " + musteri.MusteriYas);

BankaHesabi bankaHesabi = new BankaHesabi(21313123123,"Berkan İrez", 1850);
bankaHesabi.ParaEkleme(300);
bankaHesabi.ParaCekme(200);
bankaHesabi.HesapOzeti();