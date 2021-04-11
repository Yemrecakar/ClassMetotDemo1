using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri1) 
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Tebrikler !!! Müşteri Eklendi.");
            Console.WriteLine("-------------------");
        }

        public void Sil() 
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Müşteri Silindi");
            Console.WriteLine("--------------------");
        }

        public void Listele() 
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Müşteriler Listelendi.");
            Console.WriteLine("------------------------");
        }
    }
}
