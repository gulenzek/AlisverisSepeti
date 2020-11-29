using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSepeti
{
    /*
    Ödev 

    Enum, Class ve İnterface yapısını daha iyi anlamak  amacıyla bir uygulama yazmanızı istiyorum. 
    Bu uygulamada kullanılacak olan yapilar ve program yapısı şu şekilde olmalıdır ;


    1)	Classlar ; Urun, Musteri ve Siparis Classlari. Bu classlari oluştururken interface 
    yapısını kullanın.
    2)	Oluşturulacak listeler : Urun listesi, Musteri Listesi ve Sipariş Listesi
    3)	Classlarlardan en az birinde “partial” yapısının kullanın
    4)	Class icerisinde tanımlayacağınız field’lardan en az biri Enum tipinde olsun. Enumun 
    ne olduğunu hatırlayalım ve ona göre bir seçim yapalim

    Yapacağınız uygulama calistiginda ekrana satin alinabilecek ürünleri yazdirin ve seçim 
    yapıldıktan sonra müşteri bilgilerini alın. Aldığınız bu değerleri sipariş listesine ekleyin. 
    Sipariş alırken müşteriden kaç adet almak istediğini öğrenin ve tanımlanan ürün listesindeki 
    stok sayisi 5 adetin altina düştüğünde ekrana bir mesaj yazdirin. Bu mesaji yazdırırken 
    kullanılacak fonksiyon tipine dikkat edin.

    */
    partial class Siparis : Temel, ISiparis, IDisposable
    {
        public Siparis()
        {
            //
        }
        public Siparis(int id)
        {
            this._id = id;
        }
        public void Dispose()
        {
            // ...
        }

        public void SiparisHazirla()
            => Console.WriteLine("{0} {1} {2} {3}", _id, _ad, _miktar, _miktarTuru);
    }
}
