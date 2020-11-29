using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSepeti
{
    interface IUrun : ITemel
    {
        // Ürün arayüzü...
        void UrunEkle(int id, string ad, int kategoriId, double fiyat, double miktar);
        void UrunDuzelt(int id);
        void UrunSil(int id);
    }
}
