using Base;
using Infrastructure;


namespace TaskListData
{
    public class DataEditing
    {
        public Tasks toTasks(string id, string name, string tag, string priority, string duration, DateTime deadline)
        {
            Tasks task = new Tasks();
            task.id = Convert.ToInt32(id);
            task.name = name;
            task.tag = tag;
            task.priority = priority;
            task.duration = Convert.ToDouble(duration);
            task.deadline = deadline;

            return task;
        }

        public Tasks toTasks()
        {
            DataProvider provider = new DataProvider();
            string str = provider.loadData();

            Tasks task = new Tasks();
            string[] splitted = str.Split(",");

            task.name = splitted[0];
            task.tag = splitted[1];
            task.priority = splitted[2];
            task.status = splitted[3];
            task.duration = Convert.ToDouble(splitted[4]);
            task.deadline = Convert.ToDateTime(splitted[5]);

            return task;
        }

        public void addToTasksList(List<Tasks> list, string id, string name, string tag, string priority, string duration, DateTime deadline)
        {
            list.Add(toTasks(id, name, tag, priority, duration, deadline));
        }

        public string[] taskToString(Tasks task)
        {
            string str = $"{task.id},{task.name},{task.tag},{task.priority},{task.status},{task.duration},{task.deadline}";

            return str.Split(",");
        }
    }
}
