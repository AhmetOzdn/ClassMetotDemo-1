using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo_1
{
    class MusteriManager
    {
        public void Ekle(Musteri Musteriler)
        {
            Console.WriteLine("Başarıyla Eklendi : "+ Musteriler.Ad + " - " + Musteriler.Soyad);
        }

        public void Sil(Musteri Musteriler) 
        {
            Console.WriteLine("Başarılaya Silindi : "+Musteriler.Ad + " " + Musteriler.Soyad);
        }

        public void List(Musteri Musteriler)
        {
            
            Console.WriteLine("Kişi Başarıyla Listelendi : "+Musteriler.Ad + " " + Musteriler.Soyad);
        }

        
    }
}
