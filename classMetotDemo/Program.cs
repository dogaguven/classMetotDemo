using System;

namespace classMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            musteriManager musteriManager = new musteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id = 3001;
            musteri1.musteriAdi = "Doğa";
            musteri1.musteriSoyadi = "Güven";
            musteri1.tutarı = 3748;
            musteri1.meslegi = "Öğrenci";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 3002;
            musteri2.musteriAdi = "Emre";
            musteri2.musteriSoyadi = "Korkmaz";
            musteri2.tutarı = 6300;
            musteri2.meslegi = "Satış müdürü";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3003;
            musteri3.musteriAdi = "Damla";
            musteri3.musteriSoyadi = "Güven";
            musteri3.tutarı = 2900;
            musteri3.meslegi = "Kimyager";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 3004;
            musteri4.musteriAdi = "Nevzat";
            musteri4.musteriSoyadi = "Güven";
            musteri4.tutarı = 8100;
            musteri4.meslegi = "Bankacı";

            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri3);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Liste(musteri);
            }

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);



        }
    }
}
