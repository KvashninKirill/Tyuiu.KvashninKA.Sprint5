using Tyuiu.KvashninKA.Sprint5.Task3.V7.Lib;
namespace Tyuiu.KvashninKA.Sprint5.Task3.V7;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* Спринт #5                                                                                              *");
        Console.WriteLine("* Тема: Обработка файлов в C#                                                                            *");
        Console.WriteLine("* Задание #3                                                                                             *");
        Console.WriteLine("* Вариант #7                                                                                             *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                     *");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
        Console.WriteLine("* Дано выражение , вычислить его значение при x = 2, результат сохранить в бинарный файл                 *");
        Console.WriteLine("* OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков после запятой.                      *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("**********************************************************************************************************");



        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
        Console.WriteLine("**********************************************************************************************************");

        int x = 2;
        Console.WriteLine("x = " + x);

        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
        Console.WriteLine("**********************************************************************************************************");

        string res = ds.SaveToFileTextData(x);

        double fileValue;
        using (BinaryReader reader = new BinaryReader(File.Open(res, FileMode.Open)))
        {
            fileValue = reader.ReadDouble();
        }

        Console.WriteLine("Результат: " + fileValue);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");

        Console.ReadLine();
    }
}