using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 85;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 4;

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (var x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine("----");
                
            }


            Console.WriteLine("--------Metotlar-----------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle2(urun2);
            





        }
    }
}








//Do not repeat yourself!!! - Clean Code