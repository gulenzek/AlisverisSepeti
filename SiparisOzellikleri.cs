using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSepeti
{
    partial class Siparis : Temel, ISiparis, IDisposable
    {
        // 2 kg Domates, 3 Çikolatalı Gofret, 3 Ekmek, 2 Şişe Su
        public int _musteriId { get; set; }
        public double _miktar { get; set; }
        public MiktarTuru _miktarTuru { get; set; }
        public double _fiyat { get; set; }
        public double _toplam { get; set; }
        public DateTime _tarih { get; set; }
        public int _adres { get; set; }
    }
}
