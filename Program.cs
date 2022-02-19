using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cuma);

            int sicaklik = 32;
            if(sicaklik<=(int)HavaDurumu.ÇokSıcak)
            {
                Console.WriteLine("Hava çok Sıcak");
            }
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Sali,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar

    }
    enum HavaDurumu
    {
        Soğuk =5,
        Normal = 20,
        Sıcak =30,
        ÇokSıcak = 40
    }
}