using Tyuiu.KvashninKA.Sprint5.Task2.V30.Lib;
namespace Tyuiu.KvashninKA.Sprint5.Task2.V30.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            int[,] matrix = new int[3, 3]
            {
                { 3, -1, -3 },
                { -2, -5, 0 },
                { -8, -7, 2 }
            };

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}