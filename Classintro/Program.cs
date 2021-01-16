using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;
            kurs kurs1 = new kurs();
            kurs1.kursAdı = "C#";
            kurs1.egitmen = "Engin Demirog";
            kurs1.izlenmeOranı = 68;

            kurs kurs2 = new kurs();
            kurs1.kursAdı = "Java";
            kurs1.egitmen = "Kadir AKAR";
            kurs1.izlenmeOranı = 64;

            kurs kurs3 = new kurs();
            kurs1.kursAdı = "Python";
            kurs1.egitmen = "Berkay Bilgin";
            kurs1.izlenmeOranı = 70;

            //Console.WriteLine(kurs1.kursAdı + ":", kurs1.egitmen);

            kurs[] kurslar = new kurs[](kurs1, kurs2, kurs3);

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdı);
            }

            //Console.WriteLine("Hello World!");
        }
    }

    class kurs
    {
        public string kursAdı { get; set; }
        public kursunEgitmeni egitmen { get; set; }
        public int MyProperty { get; set; }



    }



}
