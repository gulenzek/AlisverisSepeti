using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSepeti
{
    partial class Musteri : Temel, IMusteri, IDisposable
    {
        public Musteri(int id)
        {
            Id = id;
        }

        //
        public bool MusteriKontrol(string id, string sifre)
        {
            // Dummy
            if(id == "zeki" && sifre == "sifre")
            {
                return true;
            }
            return false;
        }
        public void Dispose()
        {
            // IDisposable..
        }
    }
}
