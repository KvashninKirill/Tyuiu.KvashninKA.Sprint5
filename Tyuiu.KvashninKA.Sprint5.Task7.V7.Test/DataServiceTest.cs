using Tyuiu.KvashninKA.Sprint5.Task7.V7.Lib;
namespace Tyuiu.KvashninKA.Sprint5.Task7.V7.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedLoadDataAndSave()
        {
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "Привет, Мир! Ёлка Hello 123");

            DataService ds = new DataService();
            string pathSaveFile = ds.LoadDataAndSave(path);

            string res = File.ReadAllText(pathSaveFile);
            string wait = "ривет, ир! лка Hello 123";

            File.Delete(path);
            File.Delete(pathSaveFile);
            Assert.AreEqual(wait, res);
        }
    }
}
