internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            double ans = 0;
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите арифметическое действие: ");
            string operation = Console.ReadLine()!;
            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

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
                default:
                    Console.WriteLine("Неизвестная операция");


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