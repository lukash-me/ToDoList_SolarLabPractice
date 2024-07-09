using Base;
using Infrastructure;


namespace TaskListData
{
    public class DataEditing
    {
        public void toTasks(string name, string tag, string priority, string duration, DateTime deadline)
        {
            Tasks task = new Tasks();
            task.name = name;
            task.tag = tag;
            task.priority = priority;
            task.duration = Convert.ToDouble(duration);
            task.deadline = deadline;

            DataProvider provider = new DataProvider();
            provider.saveData(task);
        }
    }
}
