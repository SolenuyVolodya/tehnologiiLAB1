using System;

class Program
{
   
    static long Factorial(long y)
    {
        if (y == 0) return 1;
        return y * Factorial(y - 1);
    }

    
    static double Function(double x)
    {
        double a = Math.Sqrt(Math.Log(4 / 3)) + (x + 9 / 7) - Math.Exp(1.3 * x - 0.7);
        return a;
    }

   
    static string Fibonachi(int x)
    {
        int c1 = 0;
        int c2 = 1;
        int sum = 0;
        for (int i = 0; i < x; i++)
        {
            if (c1 == 0)
            {
                Console.WriteLine(0);
            }
            if ((c1 == 1) && (c2 == 1))
            {
                Console.WriteLine(1);
            }
            sum = c1 + c2;
            Console.WriteLine(Math.Abs(sum));
            c1 = c2;
            c2 = sum;
        }
        return "Готово";
    }

   
    static double Cos(double x, int n, int prec)
    {
        var t = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial((uint)(2 * n));
        if (Math.Abs(t) < prec)
        {
            return t;
        }
        return t + Cos(x, n + 1, prec);
    }

    static void Main()
    {
        int a = 1;
        while (a == 1)
        {
            Console.WriteLine("Что вы хотите сделать?");
        Console.WriteLine("1 - Вычислить факториал");
        Console.WriteLine("2 - Вычислить функцию");
        Console.WriteLine("3 - Вычислить числа Фибоначчи");
        Console.WriteLine("4 - Вычислить косинус");

        int otvet = int.Parse(Console.ReadLine());
        
       
        switch (otvet)
        {
            case 1:
                Console.WriteLine("Факториал какого числа вы хотите узнать?");
                long x = long.Parse(Console.ReadLine());
                Console.WriteLine(Factorial(x));
                break;
            case 2:
                Console.WriteLine("Введите x в функции");
                double x2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Function(x2));
                break;
            case 3:
                Console.WriteLine("Введите число, до которого нужно посчитать числа фибоначи.");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(Fibonachi(n));
                break;
            case 4:
                Console.WriteLine("Введите x для вычисления косинуса");
                double x3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите точность вычисления");
                int prec = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число рядов");
                int c = int.Parse(Console.ReadLine());
                double result = Cos(x3, c, prec);
                Console.WriteLine(Math.Round(result, prec));
                break;
            default:
                Console.WriteLine("Неверный выбор!");
                break;
        }
    }
}
}
