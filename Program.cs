using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть температуру води");
        string input = Console.ReadLine();
        int temperature = int.Parse(input);

        if (temperature <= 0)
        {
            Console.WriteLine("Лід");
        }
        else if (temperature >= 0 && temperature < 100)
        {
            Console.WriteLine("Тепло");
        }
        else if ( temperature >= 100)
        {
            Console.WriteLine("Пара");
        }
    }
}