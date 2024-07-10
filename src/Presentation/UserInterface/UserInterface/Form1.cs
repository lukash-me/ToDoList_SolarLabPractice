using Base;
using Microsoft.VisualBasic;
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

        private void button1_Click(object sender, EventArgs e)
        {
            de.addToTasksList(list, taskIdTextBox.Text,
                        taskNameTextBox.Text,
                        taskTagTextBox.Text,
                        TaskPriorityComboBox.Text,
                        taskDurationTextBox.Text,
                        taskDeadlineDateBox.Value);
            tasksListRefresh();
        }

        private void tasksListRefresh()
        {
            TasksListView.Items.Clear();

            Tasks task = list.ElementAt(0);

            string[] str = de.taskToString(task);

            ListViewItem item = new ListViewItem(str[0]);

            item.SubItems.Add(str[1]);
            item.SubItems.Add(str[2]);
            item.SubItems.Add(str[3]);
            item.SubItems.Add(str[4]);
            item.SubItems.Add(str[5]);
            item.SubItems.Add(str[6]);

            TasksListView.Items.Add(item);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            TasksListView.Items.Clear();
            tasksListRefresh();
        }
    }
}
