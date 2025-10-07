using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            double ans = 0;
            double a;
            while (true)
            {
                Console.Write("Введите первое число: ");
                if (double.TryParse(Console.ReadLine(), out a))
                    break;
                Console.WriteLine("Ошибка! Введите число правильно.");
            }
            Console.WriteLine("Введите арифметическое действие: ");

            string operation = Console.ReadLine()!;
            while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Неизвестная операция. Используйте (+, -, *, /)");
                operation = Console.ReadLine()!;

            }
            double b;
            while (true)
            {
                Console.Write("Введите второе число: ");
                if (double.TryParse(Console.ReadLine(), out b))
                    break;
                Console.WriteLine("привет");
            }

            switch (operation)
            {
                case "+":
                    ans = a + b;
                    break;
                case "-":
                    ans = a - b;
                    break;
                case "*":
                    ans = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                    }
                    ans = a / b;
                    break;

            }
            if (b != 0)
            {

            Console.WriteLine($"Ответ: {ans}");

            }

            Console.WriteLine("Нажмите любую клавишу для выполнения программы еще раз");
            Console.WriteLine("Нажмите Esc для выхода из программы");

            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape)
                break;

            Console.ReadKey();
        }
    }
}