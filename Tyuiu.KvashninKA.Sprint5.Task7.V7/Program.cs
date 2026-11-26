using Tyuiu.KvashninKA.Sprint5.Task7.V7.Lib;
namespace Tyuiu.KvashninKA.Sprint5.Task7.V7;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* Спринт #5                                                                                              *");
        Console.WriteLine("* Тема: Обработка файлов в C#                                                                            *");
        Console.WriteLine("* Задание #7                                                                                             *");
        Console.WriteLine("* Вариант #7                                                                                             *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                     *");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V7.txt (файл взять из архива согласно вашему варианту.     *");
        Console.WriteLine("* Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор символьных     *");
        Console.WriteLine("* данных.Удалить все заглавные русские буквы из файла.Полученный результат сохранить в файл              *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("**********************************************************************************************************");



        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
        Console.WriteLine("**********************************************************************************************************");

        string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V7.txt");
        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
        Console.WriteLine("**********************************************************************************************************");

        string res = ds.LoadDataAndSave(path);
        Console.WriteLine("Находится в файле: " + res);

        Console.ReadLine();
    }
}