using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSepeti
{
    // Enum tipinde bir özellik
    public enum MiktarTuru { Tane = 0, Kilogram = 1, Litre = 2, Metre = 3 }
    partial class Urun : Temel, IUrun, IDisposable
    {
        //
        public int _kategoriId { get; set; }
        public double _fiyat { get; set; }
        public double _miktar { get; set; }
        public MiktarTuru _miktarTuru { get; set; }

        public void Dispose()
        {
            // IDisposable..
        }
    }
}
