using Tyuiu.KvashninKA.Sprint5.Task1.V29.Lib;
namespace Tyuiu.KvashninKA.Sprint5.Task1.V29;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* Спринт #5                                                                                              *");
        Console.WriteLine("* Тема: Обработка файлов в C#                                                                            *");
        Console.WriteLine("* Задание #1                                                                                             *");
        Console.WriteLine("* Вариант #29                                                                                            *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                     *");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
        Console.WriteLine("* Дана функция F(x) = sin(x)/(x + 1.2) + cos(x) * 7x - 2 (произвести табулирование) f(x) на заданном     *");
        Console.WriteLine("* диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль. При делении на ноль вернуть          *");
        Console.WriteLine("* значение 0. Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на                      *");
        Console.WriteLine("* консоль в таблицу. Значения округлить до двух знаков после запятой.                                    *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("**********************************************************************************************************");



        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
        Console.WriteLine("**********************************************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
        Console.WriteLine("**********************************************************************************************************");

        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|    X     |   f(x)   |");
        Console.WriteLine("+----------+----------+");

        string[] lines = File.ReadAllLines(res);
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine("|{0,5:d}     |  {1,6}  |", startValue + i, lines[i]);
        }

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();

        Console.ReadLine();
    }
}