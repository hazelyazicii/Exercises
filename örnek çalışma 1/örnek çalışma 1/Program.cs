//YÜZDELİK HESAPLAMA
    
{
    double sayi, yuzde, sonuc;
    Console.Write("Sayıyı Giriniz :");
    sayi = Convert.ToDouble(Console.ReadLine());
    Console.Write("Yüzdeyi Giriniz :");
    yuzde = Convert.ToDouble(Console.ReadLine());
    sonuc = sayi * yuzde / 100;
    Console.WriteLine("Girilen sayının % {0}' i : {1}", yuzde, sonuc);
    Console.ReadKey();




}
