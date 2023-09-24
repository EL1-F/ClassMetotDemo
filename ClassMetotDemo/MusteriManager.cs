using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
        List<Musteri> musteriler = new List<Musteri>();

        public void Sorgula()
        {

            long girilenKimlikNo;
            Console.Write("Bulmak istediğiniz müşteri kimlik numarasını 11 haneli olarak giriniz: ");
            girilenKimlikNo = long.Parse(Console.ReadLine());
            string gkn = girilenKimlikNo.ToString();
            int uzunluk = gkn.Length;

            if (uzunluk == 11)
            {
                foreach (var musteri in musteriler)
                {
                    if (girilenKimlikNo == musteri.tc)
                    {
                        Console.WriteLine(musteri.ad + " " + musteri.soyad + "\n" + musteri.tc + "\n" + musteri.telefonNo);
                    }
                }
            }
            else
            {
                Console.WriteLine("Eksik girdiniz.");
            }
        }

        public void Ekle()
        {
            Musteri yeniMusteri = new Musteri();

            Console.WriteLine("Adınız: ");
            yeniMusteri.ad = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            yeniMusteri.soyad = Console.ReadLine();
            Console.WriteLine("11 haneli kimlik numaranız: ");
            yeniMusteri.tc = long.Parse(Console.ReadLine());
            Console.WriteLine("Telefon numaranız: ");
            yeniMusteri.telefonNo = long.Parse(Console.ReadLine());

            musteriler.Add(yeniMusteri);
            Console.WriteLine("İşlem tamamlanmıştır.");
        }

        public void Listele()
        {
            Console.WriteLine("Mevcut Müşterilerimiz\n");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.ad + " " + musteri.soyad + "\n" + "Kimlik numarası: " + musteri.tc + "\n" + "Telefon umarası: " + musteri.telefonNo);
                Console.WriteLine("******");
            }
        }

        public void Sil()
        {
            Musteri eleman = new Musteri();
            Console.WriteLine("Silmek istediğiniz müşteri kimlik numarasını 11 haneli olarak giriniz: ");
            eleman.tc = long.Parse(Console.ReadLine());
            string gkn = eleman.tc.ToString();
            int uzunluk = gkn.Length;

            if (uzunluk == 11)
            {
                foreach (var musteri in musteriler)
                {
                    if (eleman.tc == musteri.tc)
                    {
                        musteriler.Remove(eleman);
                        Console.WriteLine("İşlem tamamlanmıştır.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Eksik girdiniz.");
            }
        }
    }
}
