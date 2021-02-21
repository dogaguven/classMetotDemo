using System;

namespace ClassMetotDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Doğa";
            musteri1.Soyadi = "Güven";
            musteri1.Meslegi = "Öğrenci";
            musteri1.Tutari = 1289.60;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Erva";
            musteri2.Soyadi = "Turhan";
            musteri2.Meslegi = "Öğrenci";
            musteri2.Tutari = 7469;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Damla";
            musteri3.Soyadi = "Güven";
            musteri3.Meslegi = "Kimyager";
            musteri3.Tutari = 5281.90;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Nevzat";
            musteri4.Soyadi = "Güven";
            musteri4.Meslegi = "Emekli bankacı";
            musteri4.Tutari = 3421.30;

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Adi = "Nilgün";
            musteri5.Soyadi = "Güven";
            musteri5.Meslegi = "Uzman Memur";
            musteri5.Tutari = 2618;

            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Liste(musteri);
            }
        }
    }
}
