namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Конвертировать из Цельсия в Фаренгейт");
                Console.WriteLine("2. Конвертировать из Фаренгейта в Цельсия");
                Console.WriteLine("3. Конвертировать из Цельсия в Кельвины");
                Console.WriteLine("4. Конвертировать из Кельвинов в Цельсия");
                Console.WriteLine("5. Конвертировать из Фаренгейта в Кельвины");
                Console.WriteLine("6. Конвертировать из Кельвинов в Фаренгейты");
                Console.WriteLine("7. Выйти из программы");
                Console.Write("Введите номер действия: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите номер действия.");
                    continue;
                }

                if (choice == 7)
                {
                    Console.WriteLine("Программа завершена.");
                    break;
                }

                double temperature;

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите температуру в градусах Цельсия: ");
                        if (!double.TryParse(Console.ReadLine(), out temperature))
                        {
                            Console.WriteLine("Неверный ввод. Пожалуйста, введите числовое значение.");
                            continue;
                        }
                        Console.WriteLine($"Температура в градусах Фаренгейта: {TemperatureConverter.CelsiusToFahrenheit(temperature)}");
                        break;

                    case 2:
                        Console.Write("Введите температуру в градусах Фаренгейта: ");
                        if (!double.TryParse(Console.ReadLine(), out temperature))
                        {
                            Console.WriteLine("Неверный ввод. Пожалуйста, введите числовое значение.");
                            continue;
                        }
                        Console.WriteLine($"Температура в градусах Цельсия: {TemperatureConverter.FahrenheitToCelsius(temperature)}");
                        break;

                    case 3:
                        Console.Write("Введите температуру в градусах Цельсия: ");
                        if (!double.TryParse(Console.ReadLine(), out temperature))
                        {
                            Console.WriteLine("Неверный ввод. Пожалуйста, введите числовое значение.");
                            continue;
                        }
                        Console.WriteLine($"Температура в Кельвинах: {TemperatureConverter.CelsiusToKelvin(temperature)}");
                        break;

                    case 4:
                        Console.Write("Введите температуру в Кельвинах: ");
                        if (!double.TryParse(Console.ReadLine(), out temperature))
                        {
                            Console.WriteLine("Неверный ввод. Пожалуйста, введите числовое значение.");
                            continue;
                        }
                        Console.WriteLine($"Температура в градусах Цельсия: {TemperatureConverter.KelvinToCelsius(temperature)}");
                        break;

                    case 5:
                        Console.Write("Введите температуру в градусах Фаренгейта: ");
                        if (!double.TryParse(Console.ReadLine(), out temperature))
                        {
                            Console.WriteLine("Неверный ввод. Пожалуйста, введите числовое значение.");
                            continue;
                        }
                        Console.WriteLine($"Температура в Кельвинах: {TemperatureConverter.FahrenheitToKelvin(temperature)}");
                        break;

                    case 6:
                        Console.Write("Введите температуру в Кельвинах: ");
                        if (!double.TryParse(Console.ReadLine(), out temperature))
                        {
                            Console.WriteLine("Неверный ввод. Пожалуйста, введите числовое значение.");
                            continue;
                        }
                        Console.WriteLine($"Температура в градусах Фаренгейта: {TemperatureConverter.KelvinToFahrenheit(temperature)}");
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
    }
}
