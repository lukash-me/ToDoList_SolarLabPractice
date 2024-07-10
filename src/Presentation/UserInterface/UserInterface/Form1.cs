using Base;
using Microsoft.VisualBasic;
using System.Data;
using TaskListData;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        List<Tasks> list = new List<Tasks>();
        DataEditing de = new DataEditing();
        public Form1()
        {
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            de.addToTasksList(list, taskIdUpDown.Value,
                        taskNameTextBox.Text,
                        taskTagTextBox.Text,
                        TaskPriorityComboBox.Text,
                        taskDurationTextBox.Text,
                        taskDeadlineDateBox.Value.ToShortDateString(),
                        taskHoursComboBox.Text,
                        taskMinsComboBox.Text);
            actualIdcomboBox.Items.Add(taskIdUpDown.Value);
            tasksListRefresh();
        }

        public void tasksListRefresh()
        {
            TasksListView.Items.Clear();

            foreach (Tasks task in list)
            {
                string[] str = de.taskToString(task);
                ListViewItem item = new ListViewItem(str[0]);

                for (int i = 1; i < 7; i++)
                {
                    item.SubItems.Add(str[i]);
                }

                TasksListView.Items.Add(item);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            TasksListView.Items.Clear();
            tasksListRefresh();
        }

        private void startTaskButton_Click(object sender, EventArgs e)
        {
            de.statusChanging(list, Convert.ToInt32(actualIdcomboBox.Text), 1);
            tasksListRefresh();
        }

        private void completeTaskButton_Click(object sender, EventArgs e)
        {
            de.statusChanging(list, Convert.ToInt32(actualIdcomboBox.Text), 2);
            tasksListRefresh();
        }
        private void editTaskButton_Click(object sender, EventArgs e)
        {
            TaskEditingForm taskEditingForm = new TaskEditingForm(de, list);

            string[] texts = de.taskToString(de.searchTask(list, Convert.ToInt32(actualIdcomboBox.Text)));

            taskEditingForm.setTexts(texts[0], texts[1], texts[2], texts[3], texts[5], texts[6].Split(" ")[0], texts[6].Split(" ")[1].Split(":")[0], texts[6].Split(" ")[1].Split(":")[1]);
            taskEditingForm.ShowDialog();
            tasksListRefresh();
        }
    }
}