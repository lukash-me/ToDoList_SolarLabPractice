using Base;

namespace TaskListData
{
    static public class DataProcessing
    {
        public static void statusFilter(List<Tasks> list, List<string[]> filteredList, string choice)
        {
            //List<string[]> filteredList;

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
    }
}
