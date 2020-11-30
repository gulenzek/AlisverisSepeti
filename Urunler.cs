using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSepeti
{
    class Urunler : IEnumerable
    {
        Urun urun = new Urun();

        public Urun UrunGetir(int id)
        {
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

        IEnumerator GetEnumerator()
        {
            return (IEnumerator<Urun>)GetEnumerator();
        }

        private bool isDisposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            // IDisposable..
            if (!isDisposed)
            {
                if (disposing)
                {
                    if (urun != null)
                        urun.Dispose();
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public class UrunlerEnum: IEnumerator<Urun>
    {
        public Urun[] _urun;
        int pozisyon = -1;

        public UrunlerEnum(Urun[] urunListesi)
        {
            _urun = urunListesi;
        }
        public bool MoveNext()
        {
            pozisyon++;
            return (pozisyon<_urun.Length);
        }
        public void Reset()
        {
            pozisyon = -1;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        /*
        object IEnumerator.MevcutUrun
        {
            get
            {
                return MevcutUrun;
            }
        }
        */
        public Urun MevcutUrun
        {
            get
            {
                try
                {
                    return _urun[pozisyon];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }

        }

        public Urun Current => throw new NotImplementedException();

        object System.Collections.IEnumerator.Current => throw new NotImplementedException();
    }
}
