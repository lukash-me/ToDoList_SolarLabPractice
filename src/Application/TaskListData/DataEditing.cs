using Base;

namespace TaskListData
{
    public class DataEditing
    {
        /// <summary>
        /// Создание экземпляра Tasks из получаемых данных.
        /// </summary>
        /// <param name="id">Номер.</param>
        /// <param name="name">Название.</param>
        /// <param name="tag">Тег.</param>
        /// <param name="priority">Приоритет.</param>
        /// <param name="duration">Длительность.</param>
        /// <param name="deadline">Срок выполнения.</param>
        /// <returns>Экземпляр Tasks</returns>
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

        /// <summary>
        /// Преобразование списка строк с информацией о задачах в список экземаляров класса Tasks.
        /// </summary>
        /// <param name="strList">Список задач в строковом формате</param>
        /// <returns>Список экземпляров Tasks</returns>
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

        /// <summary>
        /// Добавление задачи в список задач.
        /// </summary>
        /// <param name="list">Список задач.</param>
        /// <param name="id">Номер.</param>
        /// <param name="name">Название.</param>
        /// <param name="tag">Тег.</param>
        /// <param name="priority">Приоритет.</param>
        /// <param name="duration">Длительность.</param>
        /// <param name="deadline">Срок выполнения.</param>
        public void addToTasksList(List<Tasks> list, int id, string name, string tag, string priority, int duration, DateTime deadline)
        {
            list.Add(toTasks(id, name, tag, priority, duration, deadline));
        }

        /// <summary>
        /// Удаление задачи из списка задач.
        /// </summary>
        /// <param name="list">Список задач.</param>
        /// <param name="id">Номер.</param>
        public void deleteFromTaskList(List<Tasks> list, int id)
        {
            list.Remove(DataProcessing.searchTask(list, id));
        }

        /// <summary>
        /// Изменение задачи.
        /// </summary>
        /// <param name="task"></param>
        /// <param name="id">Номер.</param>
        /// <param name="name">Название.</param>
        /// <param name="tag">Тег.</param>
        /// <param name="priority">Приоритет.</param>
        /// <param name="duration">Длительность.</param>
        /// <param name="deadline">Срок выполнения.</param>
        public void editTask(Tasks task, int id, string name, string tag, string priority, int duration, DateTime deadline)
        {
            task.id = id;
            task.name = name;
            task.tag = tag;
            task.priority = priority;
            task.duration = duration;
            task.deadline = deadline;
        }
        
        /// <summary>
        /// Изменение статуса задачи.
        /// </summary>
        /// <param name="list">Список задач.</param>
        /// <param name="id">Номер.</param>
        /// <param name="changing">Номер желаемого изменения статуса.</param>
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
