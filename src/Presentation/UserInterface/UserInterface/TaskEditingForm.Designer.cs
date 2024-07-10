namespace UserInterface
{
    partial class TaskEditingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taskEditHoursComboBox = new ComboBox();
            taskEditMinsComboBox = new ComboBox();
            taskEditIdUpDown = new NumericUpDown();
            taskEditDeadlineDateBox = new DateTimePicker();
            taskEditDurationTextBox = new TextBox();
            taskEditTagTextBox = new TextBox();
            taskEditNameTextBox = new TextBox();
            taskEditPriorityComboBox = new ComboBox();
            editTaskButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)taskEditIdUpDown).BeginInit();
            SuspendLayout();
            // 
            // taskEditHoursComboBox
            // 
            taskEditHoursComboBox.FormattingEnabled = true;
            taskEditHoursComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            taskEditHoursComboBox.Location = new Point(653, 62);
            taskEditHoursComboBox.Name = "taskEditHoursComboBox";
            taskEditHoursComboBox.Size = new Size(38, 23);
            taskEditHoursComboBox.TabIndex = 20;
            // 
            // taskEditMinsComboBox
            // 
            taskEditMinsComboBox.FormattingEnabled = true;
            taskEditMinsComboBox.Items.AddRange(new object[] { "1", "2", "4", "5", "6", "7", "8", "9", "10" });
            taskEditMinsComboBox.Location = new Point(697, 62);
            taskEditMinsComboBox.Name = "taskEditMinsComboBox";
            taskEditMinsComboBox.Size = new Size(38, 23);
            taskEditMinsComboBox.TabIndex = 21;
            // 
            // taskEditIdUpDown
            // 
            taskEditIdUpDown.Location = new Point(4, 63);
            taskEditIdUpDown.Name = "taskEditIdUpDown";
            taskEditIdUpDown.Size = new Size(67, 23);
            taskEditIdUpDown.TabIndex = 19;
            // 
            // taskEditDeadlineDateBox
            // 
            taskEditDeadlineDateBox.CustomFormat = "";
            taskEditDeadlineDateBox.Format = DateTimePickerFormat.Short;
            taskEditDeadlineDateBox.Location = new Point(545, 63);
            taskEditDeadlineDateBox.MinDate = new DateTime(2024, 7, 10, 0, 0, 0, 0);
            taskEditDeadlineDateBox.Name = "taskEditDeadlineDateBox";
            taskEditDeadlineDateBox.Size = new Size(89, 23);
            taskEditDeadlineDateBox.TabIndex = 18;
            taskEditDeadlineDateBox.TabStop = false;
            taskEditDeadlineDateBox.Value = new DateTime(2024, 7, 10, 0, 0, 0, 0);
            // 
            // taskEditDurationTextBox
            // 
            taskEditDurationTextBox.Location = new Point(430, 63);
            taskEditDurationTextBox.Name = "taskEditDurationTextBox";
            taskEditDurationTextBox.Size = new Size(100, 23);
            taskEditDurationTextBox.TabIndex = 17;
            // 
            // taskEditTagTextBox
            // 
            taskEditTagTextBox.Location = new Point(197, 63);
            taskEditTagTextBox.Name = "taskEditTagTextBox";
            taskEditTagTextBox.Size = new Size(100, 23);
            taskEditTagTextBox.TabIndex = 16;
            // 
            // taskEditNameTextBox
            // 
            taskEditNameTextBox.Location = new Point(91, 63);
            taskEditNameTextBox.Name = "taskEditNameTextBox";
            taskEditNameTextBox.Size = new Size(100, 23);
            taskEditNameTextBox.TabIndex = 15;
            // 
            // taskEditPriorityComboBox
            // 
            taskEditPriorityComboBox.FormattingEnabled = true;
            taskEditPriorityComboBox.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий", "Срочно" });
            taskEditPriorityComboBox.Location = new Point(303, 63);
            taskEditPriorityComboBox.Name = "taskEditPriorityComboBox";
            taskEditPriorityComboBox.Size = new Size(121, 23);
            taskEditPriorityComboBox.TabIndex = 14;
            // 
            // editTaskButton
            // 
            editTaskButton.Location = new Point(200, 92);
            editTaskButton.Name = "editTaskButton";
            editTaskButton.Size = new Size(354, 23);
            editTaskButton.TabIndex = 13;
            editTaskButton.Text = "Сохранить изменения";
            editTaskButton.UseVisualStyleBackColor = true;
            editTaskButton.Click += editTaskButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(200, 121);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(354, 23);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // TaskEditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 225);
            Controls.Add(taskEditHoursComboBox);
            Controls.Add(taskEditMinsComboBox);
            Controls.Add(taskEditIdUpDown);
            Controls.Add(taskEditDeadlineDateBox);
            Controls.Add(taskEditDurationTextBox);
            Controls.Add(taskEditTagTextBox);
            Controls.Add(taskEditNameTextBox);
            Controls.Add(taskEditPriorityComboBox);
            Controls.Add(cancelButton);
            Controls.Add(editTaskButton);
            Name = "TaskEditingForm";
            Text = "TaskEditingForm";
            ((System.ComponentModel.ISupportInitialize)taskEditIdUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox taskEditHoursComboBox;
        private ComboBox taskEditMinsComboBox;
        private NumericUpDown taskEditIdUpDown;
        private DateTimePicker taskEditDeadlineDateBox;
        private TextBox taskEditDurationTextBox;
        private TextBox taskEditTagTextBox;
        private TextBox taskEditNameTextBox;
        private ComboBox taskEditPriorityComboBox;
        private Button editTaskButton;
        private Button cancelButton;
    }
}