using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSepeti
{
    class Urunler
    {
        public Urun UrunGetir(int id)
        {
            Urun urun = new Urun();

            if (true)
            {
                urun._id = 1;
                urun._ad = "Karpuz";
                urun._kategoriId = 1;
                urun._miktar = 10;
                urun._miktarTuru = MiktarTuru.Kilogram;
                urun._fiyat = 2;
            }
            return urun;
        }

        public List<Urun> UrunGetir()
        {
            return new List<Urun>();
        }
    }
}
