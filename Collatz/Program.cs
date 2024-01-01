Console.ReadKey();
Console.WriteLine("Collatz Problem");
while (true)
{
    Console.WriteLine("Lütfen Bir sayı seçiniz : ");
    string sayi = Console.ReadLine();
    Console.WriteLine(String.Format("Lütfen Bir sayı seçiniz : {0}", sayi));

    //Eğer Seçilen sayı çift ise 2 ye böl (x / 2) tek ise 3 ile çarp 1 ekle 3X+1
    int secilenSayi = (int)Convert.ToInt64(sayi);
    while (true)
    {
        if (secilenSayi % 2 == 0)
        {
            secilenSayi = secilenSayi / 2;
            Console.WriteLine(String.Format("Yeni Sayımız : {0}", secilenSayi));
        }
        else
        {
            secilenSayi = (secilenSayi * 3) + 1;
            Console.WriteLine(String.Format("Yeni Sayımız : {0}", secilenSayi));
        }
        if (secilenSayi == 1)
        {
            //Döngüden çık
            break;
        }
        System.Threading.Thread.Sleep(100);    
    }

    Console.ReadKey();
}