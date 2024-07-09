using System;
using System.Collections;
using System.IO;
using Base;

namespace Infrastructure
{
    /// <summary>
    /// Передача данных в/из файла
    /// </summary>
    public class DataProvider : IDataProvider
    {
        string path = Directory.GetCurrentDirectory()
                + @"\..\..\..\..\..\..\Domain\Data\.tempStorage.txt";
        public string loadData()
        {
            using (StreamReader stream = new StreamReader(path))
                return stream.ReadLine();
        }
        public void saveData(Tasks task)
        {
            using (StreamWriter stream = new StreamWriter(path, true))
            {
                stream.WriteLine($"{task.name},{task.tag},{task.priority},{task.status},{task.duration},{task.deadline}");
            }
        }
    }
}
