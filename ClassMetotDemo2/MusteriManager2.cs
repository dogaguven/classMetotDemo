using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine( musteri.Id + musteri.Adi + musteri.Soyadi + "Eklendi.");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + musteri.Adi + musteri.Soyadi + "Silindi.");
        }
        public void Liste(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + musteri.Adi + musteri.Soyadi + musteri.Tutari);
        }
    }
}
