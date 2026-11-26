using Tyuiu.KvashninKA.Sprint5.Task4.V2.Lib;
namespace Tyuiu.KvashninKA.Sprint5.Task4.V2;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* Спринт #5                                                                                              *");
        Console.WriteLine("* Тема: Обработка файлов в C#                                                                            *");
        Console.WriteLine("* Задание #4                                                                                             *");
        Console.WriteLine("* Вариант #2                                                                                             *");
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

        string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V0.txt");
        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
        Console.WriteLine("**********************************************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);

        Console.ReadLine();
    }
}