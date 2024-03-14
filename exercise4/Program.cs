using system;

namespace forOrnek
{
    class Ornek
    {
        static void main(String args[])
        {
            int sayi;
            Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                sayi++;
            }

            Console.Write("Sayı :" + sayi);
        }
    }
}