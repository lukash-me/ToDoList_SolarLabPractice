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
                + @"\..\..\..\..\Domain\Data\test.txt";

        public void loadData(List<Tasks> taskList)
        {
            using (StreamReader stream = new StreamReader(path))
                stream.ReadLine();
        }
        public void saveData(List<Tasks> taskList)
        {
            using (StreamWriter stream = new StreamWriter(path, true))
            {
                foreach (var task in taskList) {
                    stream.WriteLine(task.ToString());
                }
            }
        }
    }
}
