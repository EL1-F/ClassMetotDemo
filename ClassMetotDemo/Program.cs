using System;

namespace ClassMetotDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            //Musteri musteri1 = new Musteri();
            //musteri1.ad = "Elif";
            //musteri1.soyad = "Coşkuner";
            //musteri1.tc = 11111111111;
            //musteri1.telefonNo = 05555555555;

            //Musteri musteri2 = new Musteri();
            //musteri2.ad = "Tarık";
            //musteri2.soyad = "Yıldırmış";
            //musteri2.tc = 22222222222;
            //musteri2.telefonNo = 05366666666;

            //Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            //diziler üzerinde oynama yapılamıyor

            
            Console.WriteLine("Yapılacak İşlem Listesi: \n Müşteri sorgulama işlemi için 1'e basınız. \n " +
                "Müşteri eklemek için 2'ye basınız. \n Müşteri silmek için 3'e basınız. \n " +
                "Mevcut Müşterileri listelemek için 4'e basınız.\n Çıkış için 5 'e basınız.");

            bool dongu = true;

            while (dongu)
            {
                int giris = int.Parse(Console.ReadLine());

                if (giris == 1)
                {
                    musteriManager.Sorgula();
                    Console.WriteLine("Yapmak istediğiniz işlemiseçiniz.");
                }
                else if (giris == 2)
                {
                    musteriManager.Ekle();
                    Console.WriteLine("Yapmak istediğiniz işlemiseçiniz.");
                }
                else if (giris == 3)
                {
                    musteriManager.Sil();
                    Console.WriteLine("Yapmak istediğiniz işlemiseçiniz.");

                }
                else if (giris == 4)
                {
                    musteriManager.Listele();
                    Console.WriteLine("Yapmak istediğiniz işlemiseçiniz.");

                }
                else if (giris == 5)
                {
                    dongu = false;
                    Console.WriteLine("İşlemler sonlandırılıyor.");
                }
                else
                {
                    Console.WriteLine("Yanlış tuşa bastınız.");
                }
            }


            





        }
    }
}
