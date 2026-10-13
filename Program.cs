// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader() {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №6");
//     Console.WriteLine("0_0");
// }

// void PrintFooter() {
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("X_X");
// }
// PrintStudentCard("Иванов Иван", "ИСП-221", 2);
// PrintStudentCard("Смирнова Анна", "ИСП-222", 2);

// void PrintStudentCard(string name, string group, int course)
// {
//     Console.WriteLine($"Студент: {name}, группа {group}, курс {course}");
// }

// PrintPurchase("Ноутбук", 65000, true);
// PrintPurchase("Мышь", 1200, false);

// void PrintPurchase(string itemName, double price, bool hasDiscount) {
//     string discountLabel = hasDiscount ? " (со скидкой)" : "";
//     Console.WriteLine($"{itemName}: {price} руб.{discountLabel}");
// }

// int sum = Add(15, 27);
// Console.WriteLine($"Сумма: {sum}");

// double area = CalculateRectangleArea(3.5, 4.2);
// Console.WriteLine($"Площадь прямоугольника: {area}");

// bool isAdult = IsAdult(20);
// Console.WriteLine($"Совершеннолетний: {isAdult}");

// int Add(int a, int b) {
//     return a + b;
// }

// double CalculateRectangleArea(double width, double height) {
//     return width * height;
// }

// bool IsAdult(int age)
// {
//     return age >= 18;
// }

// Console.WriteLine();
// Console.WriteLine($"5 + 10 = {Add(5, 10)}");
// Console.WriteLine($"Площадь 2x2 больше площади 1x5: {CalculateRectangleArea(2, 2) > CalculateRectangleArea(1, 5)}");


// class Program {
//     static void Main() {
//         Console.WriteLine(Add(2, 3));  // вызовет первый вариант: int Add(int, int) → 5
//         Console.WriteLine(Add(2.5, 3.5)); // вызовет второй вариант: double Add(double, double) → 6.0
//         Console.WriteLine(Add(2, 3, 4)); // вызовет третий вариант: int Add(int, int, int) → 9
//     }

//     static int Add(int a, int b) {
//         return a + b;
//     }

//     static double Add(double a, double b) {
//         return a + b;
//     }

//     static int Add(int a, int b, int c) {
//         return a + b + c;
//     }
// }

// Console.WriteLine();
// Console.WriteLine($"5 + 10 = {Add(5, 10)}");
// Console.WriteLine($"Площадь 2x2 больше площади 1x5: {CalculateRectangleArea(2, 2) > CalculateRectangleArea(1, 5)}");

// Console.WriteLine();
// Console.WriteLine("Методы + цикл");
// for (int i = 1; i <= 5; i++)
// {
//     PrintNumberInfo(i);
// }

// bool IsEven(int number) {
//     return number % 2 == 0;
// }

// void PrintNumberInfo(int number)
// {
//     string parity = IsEven(number) ? "чётное" : "нечётное";
//     Console.WriteLine($"{number} — {parity} число");
// }


// Программа-«набор утилит для чисел»
int number = 6;
bool IsPrime(int number)
{
    for (int i = 2; i <= number - 1; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine(IsPrime(number));

int FindMax(int a, int b, int c)
{
    if (a > b)
    {
        return a;
    }
    if (b > c)
    {
        return b;
    }
    if (c > a)
    {
        return c;
    }
    return a;
}
double CalculateAverage(int a, int b, int c)
{
    return ((double)(a + b + c) / 3);
}

Console.WriteLine($"Введите первое число:");
int s1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите второе число:");
int s2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите третье число:");
int s3 = int.Parse(Console.ReadLine());

int mas2(int c, int r)
{
    if (c > r)
    {
        return c;
    }
    return r;
}

Console.WriteLine($"{s1} простое: {IsPrime(s1)}");
Console.WriteLine($"{s2} простое: {IsPrime(s2)}");
Console.WriteLine($"{s3} простое: {IsPrime(s3)}");
Console.WriteLine($"Максимум из трех: {FindMax(s1, s2, s3)}");
Console.WriteLine($"Максимум из первых двух: {mas2(s1, s2)}");
Console.WriteLine($"Среднееврифметическое {CalculateAverage(s1, s2, s3)}");


