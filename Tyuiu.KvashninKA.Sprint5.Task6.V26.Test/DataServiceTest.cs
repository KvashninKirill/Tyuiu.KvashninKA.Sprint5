using Tyuiu.KvashninKA.Sprint5.Task6.V26.Lib;
namespace Tyuiu.KvashninKA.Sprint5.Task6.V26.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedLoadFromDataFile()
        {
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "Привет? Как дела? Тест! ??");

            DataService ds = new DataService();
            int res = ds.LoadFromDataFile(path);
            int wait = 4;

            File.Delete(path);
            Assert.AreEqual(wait, res);
        }
    }
}
