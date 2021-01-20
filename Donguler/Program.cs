using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java Kursu";

            // array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme kampı", "Programlamaya başlangıç için temel kurs", "Java Kursu", "phyton", "c#" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti!!");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("Sayfa Sonu");
        }
    }
}
