using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            Kurs kurs2 = new Kurs();
            Kurs kurs3 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin demiroğ";
            kurs1.Izlenme = 68;
            kurs2.KursAdi = "C######";
            kurs2.Egitmen = "Enginnnnn demiroğ";
            kurs2.Izlenme = 67;
            kurs3.KursAdi = "C";
            kurs3.Egitmen = "Derin demiroğ";
            kurs3.Izlenme = 67;
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
            foreach( Kurs   kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.Egitmen);
                Console.WriteLine(kurs.Izlenme);


            }

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
        }

    }
}

    class Kurs

    {

        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int Izlenme { get; set; }




    }
