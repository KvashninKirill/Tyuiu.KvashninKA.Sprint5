using Tyuiu.KvashninKA.Sprint5.Task2.V30.Lib;
namespace Tyuiu.KvashninKA.Sprint5.Task2.V30;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* Спринт #5                                                                                              *");
        Console.WriteLine("* Тема: Обработка файлов в C#                                                                            *");
        Console.WriteLine("* Задание #2                                                                                             *");
        Console.WriteLine("* Вариант #30                                                                                            *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                     *");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры.              *");
        Console.WriteLine("* Заменить положительные элементы массива на 1, отрицательные на 0. Результат сохранить в файл           *");
        Console.WriteLine("* OutPutFileTask2.csv и вывести на консоль.                                                              *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("**********************************************************************************************************");



        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
        Console.WriteLine("**********************************************************************************************************");

        int rows = 3;
        int columns = 3;
        int[,] mtrx = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введите {i},{j} элемент массива: ");
                mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
        Console.WriteLine("**********************************************************************************************************");

        string res = ds.SaveToFileTextData(mtrx);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.WriteLine("Содержимое файла:");
        Console.WriteLine(File.ReadAllText(res));

        Console.ReadLine();
    }
}