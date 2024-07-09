using Base;
using Infrastructure;


namespace TaskListData
{
    public class DataEditing
    {
        public Tasks toTasks(string name, string tag, string priority, string duration, DateTime deadline)
        {
            Tasks task = new Tasks();
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

        public void addToTasksList(List<Tasks> list, string name, string tag, string priority, string duration, DateTime deadline)
        {
            list.Add(toTasks(name, tag, priority, duration, deadline));
        }
    }
}
