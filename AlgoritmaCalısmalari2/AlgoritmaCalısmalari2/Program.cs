//Algoritma Çalışmaları2

static void Mean(string[] args)

{
    Console.Write("Başlangıç Değerini Giriniz : ");
    int baslangic = int.Parse(Console.ReadLine());
    Console.Write("Bitiş Değerini Giriniz : ");
    int bitis = int.Parse(Console.ReadLine());
    for (int i = baslangic; i < bitis; i++)
    {
        if (i % 2 == 0)
            Console.WriteLine("{0} Çifttir", i);
        else if (i % 2 == 1)
            Console.WriteLine("{0} Tektir", i);
    }
    Console.ReadKey();
}