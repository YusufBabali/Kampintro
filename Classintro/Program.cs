using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "yusuf";
            int yas = 19;

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "eNGIN";
            kurs1.IzlenmeOrani = 68;
            kurs1.Kursadi = "C#";

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Ahmet";
            kurs2.IzlenmeOrani = 50;
            kurs2.Kursadi = "python";

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Mehmet";
            kurs3.IzlenmeOrani = 80;
            kurs3.Kursadi = "Java";

            //Console.WriteLine(kurs1.Kursadi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (Kurs takmaisim in kurslar)
            {
                Console.WriteLine("-----");
                Console.WriteLine(takmaisim.Egitmen + " : " + takmaisim.Kursadi);
                Console.WriteLine(takmaisim.IzlenmeOrani);
                
            }
        }
    }
    class Kurs
    {
        public string Kursadi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
        
    }
}
foreach (var item in collection)
{

}