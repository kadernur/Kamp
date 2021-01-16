using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[] {urun1,urun2};

            //type safe
            foreach( Urun urun  in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");

            }
            
          
                 



            Console.WriteLine("--------Metodlar----------");
            // instance - Örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager. Ekle(urun2);
            
           



        }
    }
}
//tekrar tekrar kullanılabilmeyi sağlar.-DRY
//clean code önemli!!!
//best practice -doğru uygulama teknikleri

