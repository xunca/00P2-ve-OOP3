using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Samet";
            musteri1.Soyadi = "Bayram";
            musteri1.TcNo = "16781104288";

            //Kodlama io müşterimiz olsun.

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";



            // Gerçek - Tüzel
            //SOLID

            Client musteri3 = new GercekMusteri();
            Client musteri4 = new TuzelMusteri();

            // Müşteri class'ı hem gerçek hem de tüzel müşterinin referansını tutabiliyor.

            CustomerManager costumerManager = new CustomerManager();
            costumerManager.Ekle(musteri1);
            costumerManager.Ekle(musteri2);



        }
    }
}
