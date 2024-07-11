using Base;
using Microsoft.VisualBasic;
using System.Data;
using System.Windows.Forms;
using TaskListData;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        List<Tasks> list = new List<Tasks>();
        DataEditing de = new DataEditing();
        bool userAlert = false;
        int[] userAlertArr = [10]; //0 - idAdd, 1 - nameAdd, 2 - tagAdd, 3 - durationAdd, 4 - hoursAdd, 5 - minAdd, 6 - idEdit, 7 - startEdit, 8 - doneEdit, 9 - editEdit 10 - deleteEdit
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

        //Ёто нужно заменить на listPresentation
        public void tasksListRefresh()
        {
            TasksListView.Items.Clear();

            foreach (Tasks task in list)
            {
                string[] str = DataProcessing.taskToString(task);
                ListViewItem item = new ListViewItem(str[0]);

                for (int i = 1; i < 7; i++)
                {
                    item.SubItems.Add(str[i]);
                }

                TasksListView.Items.Add(item);
            }
        }

        public void listPresentation(string filter)
        {
            TasksListView.Items.Clear();
            List<string[]> filteredList = new List<string[]>();
            DataProcessing.statusFilter(list, filteredList, filter);

            foreach (string[] taskStr in filteredList)
            {
                ListViewItem item = new ListViewItem(taskStr[0]);
                for (int i = 1; i < 7; i++)
                {
                    item.SubItems.Add(taskStr[i]);
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
            //if (userAlert) checkAlerts(userAlert);

            TaskEditingForm taskEditingForm = new TaskEditingForm(de, list);

            try
            {
                string[] texts = DataProcessing.taskToString(de.searchTask(list, Convert.ToInt32(actualIdcomboBox.Text)));
                taskEditingForm.setTexts(texts[0], texts[1], texts[2], texts[3], texts[5], texts[6].Split(" ")[0], texts[6].Split(" ")[1].Split(":")[0], texts[6].Split(" ")[1].Split(":")[1]);
                taskEditingForm.ShowDialog();
                tasksListRefresh();
            }
            catch (SystemException)
            {
                idToEdit.Text = "¬ведите номер";
                idToEdit.ForeColor = Color.FromArgb(255, 0, 0);
                actualIdcomboBox.BackColor = Color.FromArgb(250, 128, 114);

                userAlertArr[6] = 1;
                userAlertArr[9] = 1;
                userAlert = true;
            }
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            de.deleteFromTaskList(list, Convert.ToInt32(actualIdcomboBox.Text));
            actualIdcomboBox.Items.Remove(Convert.ToDecimal(actualIdcomboBox.Text));
            actualIdcomboBox.Text = string.Empty;
            tasksListRefresh();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            listPresentation(filterComboBox.Text);
        }
    }
}