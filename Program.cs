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
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        UrunleriGoster();
                        UrunTalep();
                        MusteriBilgisiniIste();
                        SiparisListesiHazirla();
                        KacAdetOlacak();
            */
            Siparis s1 = new Siparis();
            s1._id = 1;
            s1._ad = "İlk sipariş";
            s1._miktar = 12;
            s1._miktarTuru = MiktarTuru.Kilogram;
            s1.SiparisHazirla();

            Urun u1 = new Urun();
            u1._id = 1;
            u1._ad = "Karpuz";
            u1._kategoriId = 12;
            u1._fiyat = 2;
            u1._miktar = 100;
            
            Console.WriteLine(u1._id.ToString());
            Console.ReadKey();
        }
    }
}
