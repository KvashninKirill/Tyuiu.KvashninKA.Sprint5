using Tyuiu.KvashninKA.Sprint5.Task3.V7.Lib;
namespace Tyuiu.KvashninKA.Sprint5.Task3.V7.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            int x = 2;

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(x);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}