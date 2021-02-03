using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // method injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme yaparız.
            // burda dikkat etmemiz gereken nokta hangi krediyi kullanırsam onun üzerinden 
            //başvuru alacaktır buda kötü bir programlamadır.

            krediManager.Hesapla();
            loggerService.Log();

            //krediyi bağımsız hale getiririz yukarıdaki kod parçasıyla.



        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }


    }
}
