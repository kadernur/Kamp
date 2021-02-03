using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        //imza aynı içerik farklı olan durumlarda interface kullanırız.

        void Hesapla();
        //oluşturduğum kredi sınıflarının her biri hesapla işini
        //farklı ele alır bu nedenle KrediManger tek başına bir anlam ifade etmez.
        void BiseyYap();

    }
}
