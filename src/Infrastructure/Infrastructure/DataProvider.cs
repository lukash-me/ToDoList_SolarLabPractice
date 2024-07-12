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

        /// <summary>
        /// Путь к файлу.
        /// </summary>
        public string Path
        {
            get { return path; }
            set { path = value; userPath = true; }
        }

        /// <summary>
        /// Загрузка данных из файла.
        /// </summary>
        /// <returns>Строковый список задач.</returns>
        public List<string> loadData()
        {
            List<string> strList = new List<string>();
            using (StreamReader stream = new StreamReader(path))
            {
                while (!stream.EndOfStream)
                {
                    strList.Add(stream.ReadLine());
                }
            }
            return strList;
        }

        /// <summary>
        /// Сохранение данных в файл.
        /// </summary>
        /// <param name="strList">Строковый список задач.</param>
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
