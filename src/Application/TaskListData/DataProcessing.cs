using Base;

namespace TaskListData
{
    static public class DataProcessing
    {
        /// <summary>
        /// Фильтр задач по готовности.
        /// </summary>
        /// <param name="list">Список задач.</param>
        /// <param name="filteredList">Отфильтрованный список задач.</param>
        /// <param name="choice">Выбор параметра фильтрации.</param>
        public static void statusFilter(List<Tasks> list, List<string[]> filteredList, string choice)
        {
            switch (choice)
            {
                case "Все":
                    foreach (Tasks task in list)
                    {
                        filteredList.Add(taskToString(task));
                    }
                    break;
                case "В ожидании":
                    foreach (Tasks task in list)
                    {
                        if (task.status == "В ожидании") filteredList.Add(taskToString(task));
                    }
                    break;
                case "В работе":
                    foreach (Tasks task in list)
                    {
                        if (task.status == "В работе") filteredList.Add(taskToString(task));
                    }
                    break;
                case "Выполненные":
                    foreach (Tasks task in list)
                    {
                        if (task.status == "Выполнено") filteredList.Add(taskToString(task));
                    }
                    break;
                
            }
        }

        /// <summary>
        /// Преобразование задачи в строку.
        /// </summary>
        /// <param name="task">Экземпляр Tasks</param>
        /// <returns>Массив строк</returns>
        public static string[] taskToString(Tasks task)
        {
            string str = $"{task.id},{task.name},{task.tag},{task.priority},{task.status},{task.duration},{task.deadline}";

            return str.Split(",");
        }

        /// <summary>
        /// Преобразование списка из экземпляров Tasks в список задач в формате строк.
        /// </summary>
        /// <param name="list">Список задач Tasks</param>
        /// <param name="strList">Строковый список задач</param>
        public static void tasksListToString(List<Tasks> list, List<string> strList)
        {
            foreach (Tasks task in list)
                strList.Add($"{task.id},{task.name},{task.tag},{task.priority},{task.status},{task.duration},{task.deadline}");
        }

        /// <summary>
        /// Поиск задачи в списке.
        /// </summary>
        /// <param name="list">Список задач.</param>
        /// <param name="id">Номер.</param>
        /// <returns>Найденный экземпляр</returns>
        public static Tasks searchTask(List<Tasks> list, int id)
        {
            foreach (Tasks task in list)
            {
                if (task.id == Convert.ToInt32(id))
                {
                    return task;
                }
            }
            return null;
        }

        /// <summary>
        /// Получения списка всех номеров списка задач.
        /// </summary>
        /// <param name="list">Список задач.</param>
        /// <returns>Списк номеров.</returns>
        public static List<int> TaskListNumbers(List<Tasks> list)
        {
            List<int> result = new List<int>();
            foreach (Tasks task in list)
                result.Add(task.id);
            return result;
        }
    }
}
