
//Alan Çalışması
using System;
class HelloWorld
{
    static void Main(string[] args)
    {
        const double PI = 3.14;
        double yaricap, alan, cevre;
        Console.Write("Dairenin yarı çapı: ");

        yaricap = Convert.ToDouble(Console.ReadLine());

        alan = PI * yaricap * yaricap;

        cevre = 2 * PI * yaricap;

        Console.WriteLine("Dairenin Alanı: " + alan);
        Console.WriteLine("Dairenin Çevresi: " + cevre);

    }
}