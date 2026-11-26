using Tyuiu.KvashninKA.Sprint5.Task4.V2.Lib;
namespace Tyuiu.KvashninKA.Sprint5.Task4.V2.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedLoadFromDataFile()
        {
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "1");

            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            double wait = 16.061;

            File.Delete(path);
            Assert.AreEqual(wait, res);
        }
    }
}