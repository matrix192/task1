using System.Numerics;

internal class Program
{
    private static double EnterNumbers(string message)
    {

        while (true)
        {
            double number;
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("Введите число!");

        }
        
    }

    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            double ans = 0;

            double a = EnterNumbers("Введите первое число: ");

            Console.Write("Введите арифметическое действие: ");

            string operation = Console.ReadLine()!;
            while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Неизвестная операция. Используйте (+, -, *, /)");
                operation = Console.ReadLine()!;

            }
            double b = EnterNumbers("Введите второе число: ");

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
                        break;
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
