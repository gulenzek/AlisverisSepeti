using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSepeti
{
    interface IMusteri : ITemel
    {
        // 
        bool MusteriKontrol(string id, string sifre);

    }
}
