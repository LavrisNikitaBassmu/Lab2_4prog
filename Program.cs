using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение x (в радианах): ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение q (порог для остановки): ");
        double q = Math.Abs(Convert.ToDouble(Console.ReadLine()));

        double sum = 0;
        double term = 1;
        int n = 0;

        
        while (Math.Abs(term) >= q)
        {
            sum += term;
            n++;

            term *= -x * x / ((2 * n) * (2 * n - 1));
        }

        Console.WriteLine($"Приближенное значение cos({x}) = {sum}");
        Console.WriteLine($"Количество учтенных слагаемых: {n}");
    }
}