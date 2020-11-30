using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSepeti
{
    public partial class Urun : Temel, IUrun, IDisposable
    {
        //
        public Urun()
        {
            // Overload ediliyor...
        }
        public Urun(int Id, string Ad, int KategoriId, double Fiyat, double Miktar, MiktarTuru Tur)
        {
            _id = Id;
            _ad = Ad;
            _kategoriId = KategoriId;
            _fiyat = Fiyat;
            _miktar = Miktar;
            _miktarTuru = Tur;
        }

        public void UrunEkle(int id, string ad, int kategoriId, double fiyat, double miktar)
        {
            _id = id;
            _ad = ad;
            _kategoriId = kategoriId;
            _fiyat = fiyat;
            _miktar = miktar;
            // ? Nereye ekledik???
        }
        public void UrunDuzelt(int id)
        {
            //...
        }

        public void UrunSil(int id)
        {
            //...
        }
    }
}
