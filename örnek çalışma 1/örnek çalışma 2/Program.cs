//Faktöriyel Hesaplama

int number = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= number; i++)
{
    factorial *= i;



}
Console.WriteLine($"Faktöriyel: {factorial}");
