Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (IsPrime(n))
{
    Console.WriteLine("Простое число");
}
else
{
    Console.WriteLine("Не простое число");
}

static bool IsPrime(int number)
{
    if (number < 2) return false;
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}
