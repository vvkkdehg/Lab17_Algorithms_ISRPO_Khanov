Console.Write("Введите вес (кг): ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите рост (cм): ");
double height = Convert.ToDouble(Console.ReadLine());

double bmi = weight / ( (height / 100) * ( height / 100 ));

Console.WriteLine("Ваш ИМТ: " + bmi);

if (bmi < 18.5)
{
    Console.WriteLine("Недостаточный вес");
}
else if (bmi < 25)
{
    Console.WriteLine("Нормальный вес");
}
else if (bmi < 30)
{
    Console.WriteLine("Избыточный вес");
}
else
{
    Console.WriteLine("Ожирение");
}
