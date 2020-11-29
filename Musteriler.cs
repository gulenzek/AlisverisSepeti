using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSepeti
{
    class Musteriler
    {
        public Musteri MusteriGetir(int id)
        {
            // Bir tane müşteri getirildi.

            Musteri musteri = new Musteri(id);

            if (true)
            {
                musteri._id = 1;
                musteri.MusteriAd = "Zeki";
                musteri.MusteriSoyad = "Gülen";
                musteri.ePosta = "zeki@siemens.com";
                musteri.KullaniciAd = "gulenzeki";
            }
            return musteri;
        }

        public List<Musteri> MusteriGetir()
        {
            return new List<Musteri>();
        }

        public bool Kaydet(Musteri musteri)
        {
            return true;
        }
    }
}
