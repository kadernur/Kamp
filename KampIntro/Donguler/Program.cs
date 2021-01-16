using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Programlamaya baslangıc  için temel kurs";
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu",
            "Programlamaya baslangıc  için temel kurs","java kursu",
                "python kursu"};

          for (int i=0;i<kurslar.Length;i++)
          {
                Console.WriteLine(kurslar[i]);
          }

            Console.WriteLine("For bitti");
          foreach(string kurs in kurslar)
            {
                Console.WriteLine(kurs);


            }


            Console.WriteLine("sayfa sonu - footer");
          

        }
    }
}
