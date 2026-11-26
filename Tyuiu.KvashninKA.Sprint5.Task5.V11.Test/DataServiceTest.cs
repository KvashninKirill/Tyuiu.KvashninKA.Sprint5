using Tyuiu.KvashninKA.Sprint5.Task5.V11.Lib;
namespace Tyuiu.KvashninKA.Sprint5.Task5.V11.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedLoadFromDataFile()
        {
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "1 2 3 4.5 -5");

            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            double wait = -15;

            File.Delete(path);
            Assert.AreEqual(wait, res);
        }
    }
}