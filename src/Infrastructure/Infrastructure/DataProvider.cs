using System;
using System.IO;

namespace Infrastructure
{
    /// <summary>
    /// Передача данных в/из файла
    /// </summary>
    public class DataProvider : IDataProvider
    {
        string path = Directory.GetCurrentDirectory()
                + @"\..\..\..\..\Domain\Data\test.txt";

        public void loadData()
        {
            using (StreamReader stream = new StreamReader(path))
                stream.ReadLine();
        }

        public void saveData()
        {
            using (StreamWriter stream = new StreamWriter(path, true))
                stream.WriteLine("Ok");
        }
    }
}
