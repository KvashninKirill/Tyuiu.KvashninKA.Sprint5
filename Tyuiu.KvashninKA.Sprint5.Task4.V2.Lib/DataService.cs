using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KvashninKA.Sprint5.Task4.V2.Lib
{
    public class DataService : ISprint5Task4V2
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim().Replace(',', '.');
            double x = Convert.ToDouble(strX, CultureInfo.InvariantCulture);

            double res = (Math.Cos(x) + 3 * x) / (0.25 * x) + 4 - 2.1 * x;
            res = Math.Round(res, 3);

            return res;
        }
    }
}