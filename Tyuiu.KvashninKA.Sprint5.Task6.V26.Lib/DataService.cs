using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KvashninKA.Sprint5.Task6.V26.Lib
{
    public class DataService : ISprint5Task6V26
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            int count = text.Count(c => c == '?');
            return count;
        }
    }
}