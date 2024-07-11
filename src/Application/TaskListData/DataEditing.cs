using Base;
using Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace TaskListData
{
    public class DataEditing
    {
        public Tasks toTasks(decimal id, string name, string tag, string priority, string duration, string deadline, string hours, string mins)
        {
            Tasks task = new Tasks();
            task.id = Convert.ToInt32(id);
            task.name = name;
            task.tag = tag;
            task.priority = priority;
            task.status = "Не начата";
            task.duration = Convert.ToDouble(duration);
            task.deadline = Convert.ToDateTime($"{deadline} {hours}:{mins}:00"); //если mins, hours = null?

            return task;
        }
        
        public Tasks toTasks()
        {
            DataProvider provider = new DataProvider();
            string str = provider.loadData();

            Tasks task = new Tasks();
            string[] splitted = str.Split(",");

            task.id = Convert.ToInt32(splitted[0]);
            task.name = splitted[1];
            task.tag = splitted[2];
            task.priority = splitted[3];
            task.status = splitted[4];
            task.duration = Convert.ToDouble(splitted[5]);
            task.deadline = Convert.ToDateTime(splitted[6]);

            return task;
        }

        public void addToTasksList(List<Tasks> list, decimal id, string name, string tag, string priority, string duration, string deadline, string hours, string mins)
        {

            list.Add(toTasks(id, name, tag, priority, duration, deadline, hours, mins));
        }

        public void deleteFromTaskList(List<Tasks> list, int id)
        {
            list.Remove(searchTask(list, id));
        }

        public void editTask(Tasks task, string id, string name, string tag, string priority, string duration, string deadline, string hours, string mins)
        {
            task.id = Convert.ToInt32(id);
            task.name = name;
            task.tag = tag;
            task.priority = priority;
            task.duration = Convert.ToDouble(duration);
            task.deadline = Convert.ToDateTime($"{deadline} {hours}:{mins}:00"); //если mins, hours = null?
        }

        public string[] taskToString(Tasks task)
        {
            string str = $"{task.id},{task.name},{task.tag},{task.priority},{task.status},{task.duration},{task.deadline}";

            return str.Split(",");
        }

        public void statusChanging(List<Tasks> list, int id, int changing)
        {
            switch (changing)
            {
                case 0:
                    break;
                case 1:
                    searchTask(list, id).status = "В работе";
                    break;
                case 2:
                    searchTask(list, id).status = "Выполнено";
                    break;
            }
        }
        public Tasks searchTask(List<Tasks> list, int id)
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

        
    }
}
