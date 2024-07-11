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
            taskEditDeadlineDateBox = new DateTimePicker();
            taskEditDurationTextBox = new TextBox();
            taskEditTagTextBox = new TextBox();
            taskEditNameTextBox = new TextBox();
            taskEditPriorityComboBox = new ComboBox();
            saveTaskButton = new Button();
            cancelButton = new Button();
            taskEditIdTextBox = new TextBox();
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
            // saveTaskButton
            // 
            saveTaskButton.Location = new Point(200, 92);
            saveTaskButton.Name = "saveTaskButton";
            saveTaskButton.Size = new Size(354, 23);
            saveTaskButton.TabIndex = 13;
            saveTaskButton.Text = "Сохранить изменения";
            saveTaskButton.UseVisualStyleBackColor = true;
            saveTaskButton.Click += saveTaskButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(200, 121);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(354, 23);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // taskEditIdTextBox
            // 
            taskEditIdTextBox.Location = new Point(12, 62);
            taskEditIdTextBox.Name = "taskEditIdTextBox";
            taskEditIdTextBox.Size = new Size(67, 23);
            taskEditIdTextBox.TabIndex = 23;
            // 
            // TaskEditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 225);
            Controls.Add(taskEditIdTextBox);
            Controls.Add(taskEditHoursComboBox);
            Controls.Add(taskEditMinsComboBox);
            Controls.Add(taskEditDeadlineDateBox);
            Controls.Add(taskEditDurationTextBox);
            Controls.Add(taskEditTagTextBox);
            Controls.Add(taskEditNameTextBox);
            Controls.Add(taskEditPriorityComboBox);
            Controls.Add(cancelButton);
            Controls.Add(saveTaskButton);
            Name = "TaskEditingForm";
            Text = "TaskEditingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox taskEditHoursComboBox;
        private ComboBox taskEditMinsComboBox;
        private DateTimePicker taskEditDeadlineDateBox;
        private TextBox taskEditDurationTextBox;
        private TextBox taskEditTagTextBox;
        private TextBox taskEditNameTextBox;
        private ComboBox taskEditPriorityComboBox;
        private Button saveTaskButton;
        private Button cancelButton;
        private TextBox taskEditIdTextBox;
    }
}