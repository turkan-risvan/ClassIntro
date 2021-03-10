using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Türkan Rişvan";
            kurs1.IzlenmeOrani = 33;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C";
            kurs2.Egitmen = "Gökhan Rişvan";
            kurs2.IzlenmeOrani = 35;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Yusuf Rişvan";
            kurs3.IzlenmeOrani = 34;


            // Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen );

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);

            }

        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }

    }
}
