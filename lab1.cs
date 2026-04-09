using System;

class Program
{
    // 1. Площа рівностороннього трикутника
    static double TriangleArea(double p)
    {
        double a = p / 3;
        return (Math.Sqrt(3) / 4) * a * a;
    }

    // 2. Перевірка на парність
    static bool IsEven(int n)
    {
        return n % 2 == 0;
    }

    // 3. Перевірка точки (півколо радіуса 9, x >= 0)
    static string CheckPoint(double x, double y)
    {
        double r = 9;
        double value = x * x + y * y;

        if (x >= 0)
        {
            if (Math.Abs(value - r * r) < 0.0001)
                return "На межі";
            else if (value < r * r)
                return "Так";
        }
        return "Ні";
    }

    // 4. Масть карт
    static string GetSuit(int m)
    {
        switch (m)
        {
            case 1: return "піки";
            case 2: return "трефи";
            case 3: return "бубни";
            case 4: return "черви";
            default: return "невірне значення";
        }
    }

    // 5. Куб суми двох чисел
    static double CubeSum(double a, double b)
    {
        return Math.Pow(a + b, 3);
    }

    static void Main()
    {
        // 1
        Console.Write("Введіть периметр трикутника p: ");
        double p = double.Parse(Console.ReadLine());
        Console.WriteLine("Площа = " + TriangleArea(p));

        // 2
        Console.Write("Введіть ціле число: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(IsEven(n) ? "Парне" : "Непарне");

        // 3
        Console.Write("Введіть x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введіть y: ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine(CheckPoint(x, y));

        // 4
        Console.Write("Введіть номер масті (1-4): ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine(GetSuit(m));

        // 5
        Console.Write("Введіть a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Куб суми = " + CubeSum(a, b));

        // 6 (вираз)
        Console.Write("Введіть n: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("Введіть m: ");
        int m2 = int.Parse(Console.ReadLine());

        double result = (double)(n2 + 1) / (m2 + 1) - (5.0 / m2);
        Console.WriteLine("Результат виразу = " + result);
    }
}
