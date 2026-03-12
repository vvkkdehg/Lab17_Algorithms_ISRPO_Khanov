int[] numbers = { 5, 8, 3, 1, 9 };

int max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine($"Максимальный элемент: {max}");
