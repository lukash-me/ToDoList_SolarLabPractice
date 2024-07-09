using Base;
using Microsoft.VisualBasic;
using TaskListData;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        TasksCollection collection = new TasksCollection();
        DataEditing de = new DataEditing();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            de.addToTasksList(collection.list, taskNameTextBox.Text,
                        taskTagTextBox.Text,
                        TaskPriorityComboBox.Text,
                        taskDurationTextBox.Text,
                        taskDeadlineDateBox.Value);
            tasksListRefresh();
        }

        private void tasksListRefresh()
        {
            TasksListBox.Items.Clear();
            //вывести все элементы списка
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            TasksListBox.Items.Clear();
            tasksListRefresh();
        }
    }
}
