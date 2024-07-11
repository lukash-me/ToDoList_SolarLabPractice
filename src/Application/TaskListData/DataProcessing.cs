using Base;

namespace TaskListData
{
    static public class DataProcessing
    {
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

        public static string[] taskToString(Tasks task)
        {
            string str = $"{task.id},{task.name},{task.tag},{task.priority},{task.status},{task.duration},{task.deadline}";

            return str.Split(",");
        }

        public static List<string> tasksListToString(List<Tasks> list, List<string> strList)
        {
            foreach (Tasks task in list)
                strList.Add($"{task.id},{task.name},{task.tag},{task.priority},{task.status},{task.duration},{task.deadline}");
            
            return strList;
        }

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

        public static List<int> TaskListNumbers(List<Tasks> list)
        {
            List<int> result = new List<int>();
            foreach (Tasks task in list)
                result.Add(task.id);
            return result;
        }
    }
}
