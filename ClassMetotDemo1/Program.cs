using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            Console.WriteLine("Lütfen müşteri adını yazın : ");
            musteri1.MusteriAdi = Console.ReadLine();

            Console.WriteLine("Lütfen müşteri Id sini yazın :");
            musteri1.MusteriId = Console.Read();


            musteriManager.Ekle(musteri1);








        }
    }
}
