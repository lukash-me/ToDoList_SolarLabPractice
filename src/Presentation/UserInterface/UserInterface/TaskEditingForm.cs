using Base;
using TaskListData;

namespace UserInterface
{
    public partial class TaskEditingForm : Form
    {
        DataEditing de;
        List<Tasks> list;
        public TaskEditingForm(DataEditing de, List<Tasks> list)
        {
            InitializeComponent();
            this.de = de;
            this.list = list;
        }

        public void setTexts(string id, string name, string tag, string priority, string duration, string date, string hours, string mins)
        {
            taskEditIdTextBox.Text = id;
            taskEditIdTextBox.ReadOnly = true;
            taskEditNameTextBox.Text = name;
            taskEditTagTextBox.Text = tag;
            taskEditPriorityComboBox.Text = priority;
            taskEditDurationTextBox.Text = duration;
            taskEditDeadlineDateBox.Text = date;
            taskEditHoursComboBox.Text = hours;
            taskEditMinsComboBox.Text = mins;
        }

        private void saveTaskButton_Click(object sender, EventArgs e)
        {
            de.editTask(de.searchTask(list, Convert.ToInt32(taskEditIdTextBox.Text)),
                                        taskEditIdTextBox.Text,
                                        taskEditNameTextBox.Text,
                                        taskEditTagTextBox.Text,
                                        taskEditPriorityComboBox.Text,
                                        taskEditDurationTextBox.Text,
                                        taskEditDeadlineDateBox.Text,
                                        taskEditHoursComboBox.Text,
                                        taskEditMinsComboBox.Text
            );
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
