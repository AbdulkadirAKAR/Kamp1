using System;

namespace Kamp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string kategoriEtiketi = "Kategori.";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            Console.WriteLine(kategoriEtiketi);
            bool sistemeGirisYapmısMı = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.25;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }



            if (sistemeGirisYapmısMı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu ");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yap");
            }



        }
    }
}
