using System;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Sepete Eklendi : " + urun.Adi);

        }


        public void Ekle2(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi:" + urun.Adi);
        }

    }
}
