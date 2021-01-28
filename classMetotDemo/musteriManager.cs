using System;
using System.Collections.Generic;
using System.Text;

namespace classMetotDemo
{
    class musteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Id + musteri.musteriAdi + musteri.musteriSoyadi + musteri.tutarı + musteri.meslegi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.Id + musteri.musteriAdi + musteri.musteriSoyadi + musteri.tutarı  + musteri.meslegi);
        }

        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi : " + musteri.Id + musteri.musteriAdi + musteri.musteriSoyadi + musteri.tutarı + musteri.meslegi);
        }
    }
}
