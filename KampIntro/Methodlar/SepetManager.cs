using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        // naming convension
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi :" + urun.Adi);
            


        }
       /* public void Ekle2(string urunAdi,string aciklama,double fiyat)

        {
                bütün sayfalarda güncelleme gerektirir.
                o nedenle class tercih edilmesi daha doğru olacaktır.

        }*/
    }
}
