using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugün = 7.55;


            if (dolarDun>dolarBugün)
            {
                Console.WriteLine("Azalış Butonu");

            }

            else if (dolarDun<dolarBugün)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Eşittir Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
;            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
