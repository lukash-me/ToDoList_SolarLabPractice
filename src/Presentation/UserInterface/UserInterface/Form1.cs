using Base;
using Infrastructure;
using System.Runtime.InteropServices;
using TaskListData;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        List<Tasks> list = new List<Tasks>();
        DataEditing de = new DataEditing();
        DataProvider provider = new DataProvider();

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
            listPresentation(filterComboBox.Text);
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

        private void startTaskButton_Click(object sender, EventArgs e)
        {
            de.statusChanging(list, Convert.ToInt32(actualIdcomboBox.Text), 1);
            listPresentation(filterComboBox.Text);
        }

        private void completeTaskButton_Click(object sender, EventArgs e)
        {
            de.statusChanging(list, Convert.ToInt32(actualIdcomboBox.Text), 2);
            listPresentation(filterComboBox.Text);
        }
        private void editTaskButton_Click(object sender, EventArgs e)
        {
            //if (userAlert) checkAlerts(userAlert);

            TaskEditingForm taskEditingForm = new TaskEditingForm(de, list);

            try
            {
                string[] texts = DataProcessing.taskToString(DataProcessing.searchTask(list, Convert.ToInt32(actualIdcomboBox.Text)));
                taskEditingForm.setTexts(texts[0], texts[1], texts[2], texts[3], texts[5], texts[6].Split(" ")[0], texts[6].Split(" ")[1].Split(":")[0], texts[6].Split(" ")[1].Split(":")[1]);
                taskEditingForm.ShowDialog();
                listPresentation(filterComboBox.Text);
            }
            catch (SystemException)
            {
                idToEdit.Text = "Введите номер";
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
            listPresentation(filterComboBox.Text);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            listPresentation(filterComboBox.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<string> tasksListStr = new List<string>();
            DataProcessing.tasksListToString(list, tasksListStr);
            provider.saveData(tasksListStr);
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory()
                + @"\..\..\..\..\..\..\Domain\Data";
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.ShowDialog();

            provider.Path = openFileDialog1.FileName.Split(".")[0] + ".txt";

            List<string> tasksListStr = new List<string>();
            DataProcessing.tasksListToString(list, tasksListStr);
            provider.saveData(tasksListStr);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory()
                + @"\..\..\..\..\..\..\Domain\Data";
            openFileDialog1.ShowDialog();
            provider.Path = openFileDialog1.FileName;

            List<string> tasksListStr = provider.loadData();
            list = de.toTasks(tasksListStr);

            filterComboBox.Text = "Все";
            listPresentation(filterComboBox.Text);
        }
    }
}