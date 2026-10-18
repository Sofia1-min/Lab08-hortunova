/*PrintHeader("дом");
PrintHeader("спать");
Console.WriteLine(Max(5, 6));
Console.WriteLine(Max(10, 7));
Console.WriteLine(IsEven(4));
Console.WriteLine(IsEven(7));
Console.WriteLine(IsEven(0));
Console.WriteLine(Average(marks));
Console.WriteLine(CountGreater(marks, 100));
Console.WriteLine(ToFahrenheit(0));
Console.WriteLine(ToFahrenheit(100));
Console.WriteLine(ToFahrenheit(37));
Console.WriteLine($"Факториал 5 = {Factorial(5)}"); 
Console.WriteLine("Простые числа от 2 до 50:");
for (int i = 2; i <= 50; i++)
{
    if (IsPrime(i))
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine($"Сумма: {a + b}");
Console.Write(message);
*/
//Задание 1
/*
static void PrintLine()
{
    Console.WriteLine("^_^");
}
static void PrintHeader(string title)
{
    PrintLine();
    Console.WriteLine(title);
    PrintLine();
}
// Задание 2.1
static int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
//Задание 2.2
static bool IsEven(int n)
{
    return (n % 2 == 0);
}
//Задание 3
static double Average(int[] arr)
{
    int a = 0;
    int b = 0;
    foreach (int x in arr)
    {
        a++;
        b += x;
    }
    return (Double)b / a;
}
int[] marks = { 120, 45, 300, 80, 15, 210};
static int CountGreater(int[] arr, int limit)
{
    int d = 0;
    foreach (int x in arr)
    {
        if (x > limit)
        {
            d++;
        }
        else
        {
            d += 0;
        }
    }
    return d;
}
// Задание 4

static double ToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}*/
// Самостоятельные задания
//Задание 5

/*for (int i = 2; i <= 50; i++)
{
    if (IsPrime(i))
    {
        Console.Write(i + " ");
    }
}*/

/*static long Factorial(int n)
{
    long result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

static bool IsPrime(int n)
{
    if (n < 2) return false;

    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}*/
//Задание 6

/*
int a = ReadPositive("Введите первое число: ");
int b = ReadPositive("Введите второе число: ");



static int ReadPositive(string message)
{
    int number;
    do
    {

        number = int.Parse(Console.ReadLine());
    }
    while (number <= 0);

    return number;
}*/
//Итоговая задача. «Меню-калькулятор»
int choice;
do
{
    Console.WriteLine("1 - сумма двух чисел");
    Console.WriteLine("2 - большее из двух чисел");
    Console.WriteLine("3 - факториал");
    Console.WriteLine("0 - выход");
    Console.Write("Выберите пункт: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            int a = ReadPositive("Введите первое число: ");
            int b = ReadPositive("Введите второе число: ");
            Console.WriteLine($"Сумма: {Sum(a, b)}");
            break;
        case 2:
            int c = ReadPositive("Введите первое число: ");
            int d = ReadPositive("Введите второе число: ");
            Console.WriteLine($"Большее: {Max(c, d)}");
            break;
        case 3:
            int f = ReadPositive("Введите число: ");
            Console.WriteLine($"Факториал: {Factorial(f)}");
            break;
        case 0:
            break;
        default:
            Console.WriteLine("Нет такого пункта");
            break;
    }
} while (choice != 0);



static int ReadPositive(string message)
{
    int x;
    do
    {
        Console.Write(message);
        x = int.Parse(Console.ReadLine());
    } while (x <= 0);
    return x;
}

static int Sum(int a, int b) 
{
    return a + b;
}

static int Max(int a, int b) 
{
    if (a > b) return a;
    else return b;
}

static long Factorial(int n)
{
    long result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}
//Дополнительное задание ★★★

/*Console.WriteLine($"Gcd(48, 18) = {Gcd(48, 18)}");
Console.WriteLine($"Lcm(4, 6) = {Lcm(4, 6)}");


static int Gcd(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

static int Lcm(int a, int b)
{
    return a / Gcd(a, b) * b;
}*/