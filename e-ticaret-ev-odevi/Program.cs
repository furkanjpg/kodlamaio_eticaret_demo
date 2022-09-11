using System;

namespace Otel_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            // urun1, urun2 ve urun3 Adında class değişkenleri oluşturup içerisinde olmasını istediğim değerleri atadım
            Product urun1 = new Product();
            urun1.urunAdi = "RTX 3060";
            urun1.urunFiyat = 12000;
            urun1.urunIndirim = 20;

            Product urun2 = new Product();
            urun2.urunAdi = "AMD RX 580";
            urun2.urunFiyat = 8000;
            urun2.urunIndirim = 15;

            Product urun3 = new Product();
            urun3.urunAdi = "Quadro 20000";
            urun3.urunFiyat = 18000;
            urun3.urunIndirim = 15;

            // Product clasımı array'e çevirerek products değişkenime atadım ve ARRAY içerisine urun1, urun2 ve urun3'ü ekledim.
            Product[] products = new Product[] { urun1, urun2, urun3 };

            // FOR DÖNGÜSÜ
            #region For
            Console.WriteLine("----------------------- URUNLER ---------------------------- \n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("----------------------- " + products[i].urunAdi + " ----------------------------");
                Console.WriteLine("Ürün Adı: " + products[i].urunAdi + "\nÜrün Fiyatı: " + products[i].urunFiyat + "\nİndirim: " + products[i].urunIndirim);
            }
            #endregion
            // FOREACH DÖNGÜSÜ
            #region Foreach

            Console.WriteLine("----------------------- URUNLER ---------------------------- \n");
            foreach (var list in products)
            {
                Console.WriteLine("----------------------- " + list.urunAdi + " ----------------------------");
                Console.WriteLine("Ürün Adı: " + list.urunAdi + "\nÜrün Fiyatı: " + list.urunFiyat + "\nİndirim: " + list.urunIndirim);
            }
            #endregion

            // WHİLE DÖNGÜSÜ
            #region While
            Console.WriteLine("----------------------- URUNLER ---------------------------- \n");
            int repeatWhile = 0;
            while (repeatWhile < 3)
            {

                Console.WriteLine("----------------------- " + products[repeatWhile].urunAdi + " ----------------------------");
                Console.WriteLine("Ürün Adı: " + products[repeatWhile].urunAdi + "\nÜrün Fiyatı: " + products[repeatWhile].urunFiyat + "\nİndirim: " + products[repeatWhile].urunIndirim);
                repeatWhile++;
            }
            #endregion

            // KLAVYEDEN GİRDİ BEKLEMESİ İÇİN. (CONSOLE AÇILINCA KAPANIYORSA BUNU KULLANIN)
            Console.ReadKey();
        }
    }

    // PRODUCT ADINDA BİR CLASS OLUŞTURUP ONUN İÇERİSİNE URUNLERİN BİLGİLERİNİ ATADIM.
    class Product
    {
        public string urunAdi { get; set; }
        public int urunFiyat { get; set; }
        public int urunIndirim { get; set; }
    }
}
