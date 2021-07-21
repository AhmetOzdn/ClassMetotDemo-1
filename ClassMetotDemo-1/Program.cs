using System;

namespace ClassMetotDemo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.Ad = "Ahmet" ;
            Musteri1.Soyad = "OZDEN" ;
            Musteri1.TCNo = 2222 ;
            Musteri1.Id = 111111;
            Musteri1.KartNo = 999999999;


            Musteri Musteri2 = new Musteri();
            Musteri2.Ad = "Mehmet";
            Musteri2.Soyad = "OZDEN";
            Musteri2.TCNo = 1111;
            Musteri2.Id = 333333;
            Musteri2.KartNo = 777777777;


            Musteri Musteri3 = new Musteri();
            Musteri3.Ad = "Hüseyin";
            Musteri3.Soyad = "OZDEN";
            Musteri3.TCNo = 3333;
            Musteri3.Id = 222222;
            Musteri3.KartNo = 555555555;

            Musteri[] MusteriList = new Musteri[] {Musteri1,Musteri2,Musteri3};

            foreach (var Musteri in MusteriList)
            {
                Console.WriteLine(Musteri.Ad +" "+Musteri.Soyad +" "+Musteri.Id +" "+Musteri.KartNo +" "+Musteri.TCNo);
            }

            MusteriManager Musterimanager = new MusteriManager();
            Musterimanager.Ekle(Musteri1);
            Musterimanager.Sil(Musteri2);
            Musterimanager.List(Musteri3);
        }
    }
}
