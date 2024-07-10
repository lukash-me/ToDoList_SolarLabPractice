using Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TaskListData;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
    }
}
