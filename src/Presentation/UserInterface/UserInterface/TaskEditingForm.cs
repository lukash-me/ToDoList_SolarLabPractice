using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class TaskEditingForm : Form
    {
        public TaskEditingForm()
        {
            InitializeComponent();
        }

        public void setTexts(string id, string name, string tag, string priority, string duration, string date, string hours, string mins)
        {
            taskEditIdUpDown.Value = Convert.ToDecimal(id);
            taskEditNameTextBox.Text = name;
            taskEditTagTextBox.Text = tag;
            taskEditPriorityComboBox.Text = priority;
            taskEditDurationTextBox.Text = duration;
            taskEditDeadlineDateBox.Text = date;
            taskEditHoursComboBox.Text = hours;
            taskEditMinsComboBox.Text = mins;
        }

        private void editTaskButton_Click(object sender, EventArgs e)
        {

        }


    }
}
