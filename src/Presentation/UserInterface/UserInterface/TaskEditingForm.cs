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
            taskEditDeadlineDateBox.Value = DateTime.Now;
            taskEditHoursComboBox.Text = "0";
            taskEditMinsComboBox.Text = "0";
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
            if (taskEditDurationTextBox.Text == string.Empty) taskEditDurationTextBox.Text = "0";
            try
            {
                de.editTask(DataProcessing.searchTask(list, Convert.ToInt32(taskEditIdTextBox.Text)),
                        Convert.ToInt32(taskEditIdTextBox.Text),
                        taskEditNameTextBox.Text,
                        taskEditTagTextBox.Text,
                        taskEditPriorityComboBox.Text,
                        Convert.ToInt32(taskEditDurationTextBox.Text),
                        Convert.ToDateTime($"{taskEditDeadlineDateBox.Value.ToShortDateString()} {taskEditHoursComboBox.Text}:{taskEditMinsComboBox.Text}:00")
                        );
                Close();
            }
            catch (FormatException)
            {
                durationLabel.Text = "Введите целое число";
                durationLabel.ForeColor = Color.Red;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
