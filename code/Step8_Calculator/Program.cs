int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(Sum(num1, num2));
Console.WriteLine(Sub(num1, num2));
Console.WriteLine(Mul(num1, num2));
Console.WriteLine(Div(num1, num2));

static int Sum(int x, int y) { return x + y; }
static int Sub(int x, int y) { return x - y; }
static int Mul(int x, int y) { return x * y; }
static int Div(int x, int y) { return x / y; }
