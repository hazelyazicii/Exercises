^

 
int Number = Convert.ToInt32(Console.ReadLine());
bool isPrime = true;
for (int i = 2; i <= Math.Sqrt(Number); i++)
{
    if (Number % i == 0)
    {
        isPrime = false;
        break;
    }
}
Console.WriteLine(isPrime ? "Asal" : "Asal değil");

