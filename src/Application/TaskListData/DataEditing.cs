using Base;
using Infrastructure.TaskExceptions;

namespace TaskListData
{
    public class DataEditing
    {
        public Tasks toTasks(int id, string name, string tag, string priority, int duration, DateTime deadline)
        {
            Tasks task = new Tasks();
            task.id = id;
            task.name = name;
            task.tag = tag;
            task.priority = priority;
            task.status = "В ожидании";
            task.duration = duration;
            task.deadline = deadline; 

            return task;
        }
        
        public List<Tasks> toTasks(List<string> strList)
        {
            
            List<Tasks> list = new List<Tasks>();
            string[] taskStr;
            foreach (string str in strList)
            {
                Tasks task = new Tasks();
                taskStr = str.Split(",");
                task.id = Convert.ToInt32(taskStr[0]);
                task.name = taskStr[1];
                task.tag = taskStr[2];
                task.priority = taskStr[3];
                task.status = taskStr[4];
                task.duration = Convert.ToDouble(taskStr[5]);
                task.deadline = Convert.ToDateTime(taskStr[6]);
                list.Add(task);
            }
            return list;
        }

        public void addToTasksList(List<Tasks> list, int id, string name, string tag, string priority, int duration, DateTime deadline)
        {

            list.Add(toTasks(id, name, tag, priority, duration, deadline));
        }

        public void deleteFromTaskList(List<Tasks> list, int id)
        {
            list.Remove(DataProcessing.searchTask(list, id));
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

        public void statusChanging(List<Tasks> list, int id, int changing)
        {
            switch (changing)
            {
                case 0:
                    break;
                case 1:
                    DataProcessing.searchTask(list, id).status = "В работе";
                    break;
                case 2:
                    DataProcessing.searchTask(list, id).status = "Выполнено";
                    break;
            }
        }
        

        
    }
}
