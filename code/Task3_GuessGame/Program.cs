Random rand = new Random();
int secretNumber = rand.Next(1, 101);
int chislo = 0;
int attempts = 0;

Console.WriteLine("Я загадал число от 1 до 100. Угадай его!");

while (chislo != secretNumber)
{
    Console.Write("Твой вариант: ");
    chislo = Convert.ToInt32(Console.ReadLine());
    attempts++;
    
    if (chislo < secretNumber)
    {
        Console.WriteLine("Больше");
    }
    else if (chislo > secretNumber)
    {
        Console.WriteLine("Меньше");
    }
}

Console.WriteLine($"Поздравляю! Ты угадал число {secretNumber} за {attempts} попыток!");
