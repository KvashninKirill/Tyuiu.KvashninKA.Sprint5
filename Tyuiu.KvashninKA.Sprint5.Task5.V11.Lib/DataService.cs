using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KvashninKA.Sprint5.Task5.V11.Lib
{
    public class DataService : ISprint5Task5V11
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] tokens = text.Split(new[] { ' ', '\n', '\r', '\t', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);

            double res = 1;
            bool hasOdd = false;

            foreach (string token in tokens)
            {
                if (int.TryParse(token, NumberStyles.Integer, CultureInfo.InvariantCulture, out int num))
                {
                    if (num % 2 != 0)
                    {
                        res *= num;
                        hasOdd = true;
                    }
                }
            }

            return hasOdd ? Math.Round(res, 3) : 0;
        }
    }
}