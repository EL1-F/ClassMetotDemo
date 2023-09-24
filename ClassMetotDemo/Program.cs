
using ClassMetotDemo;

MusteriManager musteriManager = new MusteriManager();


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
        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");

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
