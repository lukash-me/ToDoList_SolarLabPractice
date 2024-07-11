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
        private bool userPath = false;
        private string path = Directory.GetCurrentDirectory()
                + @"\..\..\..\..\..\..\Domain\Data\ToDoList.txt";

        public string Path
        {
            get { return path; }
            set { path = value; userPath = true; }
        }

        public string loadData()
        {
            using (StreamReader stream = new StreamReader(path))
                return stream.ReadLine();
        }
        public void saveData(List<string> strList)
        {
            if(userPath == false)
            {
                int i = 1;
                while (File.Exists(path))
                {
                    Path = Directory.GetCurrentDirectory()
                    + $@"\..\..\..\..\..\..\Domain\Data\ToDoList_{i}.txt";
                    i++;
                }
            }
            
            using (StreamWriter stream = new StreamWriter(path))
            {
                foreach(string str in strList)
                    stream.WriteLine(str);
            }
            userPath = true;
        }
    }
}
