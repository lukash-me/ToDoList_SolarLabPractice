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
        public void loadData(Tasks taskList)
        {
            using (StreamReader stream = new StreamReader(path))
                stream.ReadLine();
            // прописать правильное чтение из файла
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
