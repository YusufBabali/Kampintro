using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            String kurs1 = "1";
            String kurs2 = "2";
            String kurs3 = "3";

            String[] kurslar = new string[] {"1","2","3"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
           
            // foreach dizi temelli yapilari tek tek donmeye yarar
            foreach (string kurs in kurslar)
            //kurs kisminda ne yazdigi onemli degil
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        
        }
    }
}
