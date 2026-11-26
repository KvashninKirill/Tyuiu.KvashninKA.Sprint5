using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KvashninKA.Sprint5.Task7.V7.Lib
{
    public class DataService : ISprint5Task7V7
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V7.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            if (fileInfo.Exists)
            {
                File.Delete(pathSaveFile);
            }

            string text = File.ReadAllText(path);
            string result = new string(text.Where(c => !(c >= 'А' && c <= 'Я' || c == 'Ё')).ToArray());

            File.WriteAllText(pathSaveFile, result);
            return pathSaveFile;
        }
    }
}