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
            idLabel = new Label();
            minsLabel = new Label();
            labelHours = new Label();
            dateLabel = new Label();
            durationLabel = new Label();
            priorityLabel = new Label();
            tagLabel = new Label();
            nameLabel = new Label();
            SuspendLayout();
            // 
            // taskEditHoursComboBox
            // 
            taskEditHoursComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            taskEditHoursComboBox.FormattingEnabled = true;
            taskEditHoursComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            taskEditHoursComboBox.Location = new Point(640, 62);
            taskEditHoursComboBox.Name = "taskEditHoursComboBox";
            taskEditHoursComboBox.Size = new Size(52, 23);
            taskEditHoursComboBox.TabIndex = 20;
            // 
            // taskEditMinsComboBox
            // 
            taskEditMinsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            taskEditMinsComboBox.FormattingEnabled = true;
            taskEditMinsComboBox.Items.AddRange(new object[] { "0", "1", "2", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21 ", "22 ", "23 ", "24 ", "25 ", "26 ", "27 ", "28 ", "29 ", "30 ", "31 ", "32 ", "33 ", "34 ", "35 ", "36 ", "37 ", "38 ", "39 ", "40 ", "41 ", "42 ", "43 ", "44 ", "45 ", "46 ", "47 ", "48 ", "49 ", "50 ", "51 ", "52 ", "53 ", "54 ", "55 ", "56 ", "57 ", "58 ", "59" });
            taskEditMinsComboBox.Location = new Point(697, 62);
            taskEditMinsComboBox.Name = "taskEditMinsComboBox";
            taskEditMinsComboBox.Size = new Size(52, 23);
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
            taskEditDurationTextBox.Location = new Point(401, 62);
            taskEditDurationTextBox.Name = "taskEditDurationTextBox";
            taskEditDurationTextBox.Size = new Size(135, 23);
            taskEditDurationTextBox.TabIndex = 17;
            // 
            // taskEditTagTextBox
            // 
            taskEditTagTextBox.Location = new Point(197, 62);
            taskEditTagTextBox.Name = "taskEditTagTextBox";
            taskEditTagTextBox.Size = new Size(100, 23);
            taskEditTagTextBox.TabIndex = 16;
            // 
            // taskEditNameTextBox
            // 
            taskEditNameTextBox.Location = new Point(91, 62);
            taskEditNameTextBox.Name = "taskEditNameTextBox";
            taskEditNameTextBox.Size = new Size(100, 23);
            taskEditNameTextBox.TabIndex = 15;
            // 
            // taskEditPriorityComboBox
            // 
            taskEditPriorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            taskEditPriorityComboBox.FormattingEnabled = true;
            taskEditPriorityComboBox.Items.AddRange(new object[] { "", "Низкий", "Средний", "Высокий", "Срочно" });
            taskEditPriorityComboBox.Location = new Point(303, 63);
            taskEditPriorityComboBox.Name = "taskEditPriorityComboBox";
            taskEditPriorityComboBox.Size = new Size(92, 23);
            taskEditPriorityComboBox.TabIndex = 14;
            // 
            // saveTaskButton
            // 
            saveTaskButton.BackgroundImage = Properties.Resources.ButtonColor;
            saveTaskButton.FlatStyle = FlatStyle.Flat;
            saveTaskButton.Location = new Point(200, 101);
            saveTaskButton.Name = "saveTaskButton";
            saveTaskButton.Size = new Size(354, 40);
            saveTaskButton.TabIndex = 13;
            saveTaskButton.Text = "Сохранить изменения";
            saveTaskButton.UseVisualStyleBackColor = true;
            saveTaskButton.Click += saveTaskButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackgroundImage = Properties.Resources.ButtonColor;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Location = new Point(200, 147);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(354, 39);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // taskEditIdTextBox
            // 
            taskEditIdTextBox.Enabled = false;
            taskEditIdTextBox.Location = new Point(12, 62);
            taskEditIdTextBox.Name = "taskEditIdTextBox";
            taskEditIdTextBox.Size = new Size(67, 23);
            taskEditIdTextBox.TabIndex = 23;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(12, 44);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(45, 15);
            idLabel.TabIndex = 24;
            idLabel.Text = "Номер";
            // 
            // minsLabel
            // 
            minsLabel.AutoSize = true;
            minsLabel.Location = new Point(697, 44);
            minsLabel.Name = "minsLabel";
            minsLabel.Size = new Size(52, 15);
            minsLabel.TabIndex = 25;
            minsLabel.Text = "Минуты";
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Location = new Point(640, 44);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(36, 15);
            labelHours.TabIndex = 26;
            labelHours.Text = "Часы";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(545, 44);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(32, 15);
            dateLabel.TabIndex = 27;
            dateLabel.Text = "Дата";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(401, 44);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(135, 15);
            durationLabel.TabIndex = 28;
            durationLabel.Text = "Длительность (в часах)";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(303, 44);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(67, 15);
            priorityLabel.TabIndex = 29;
            priorityLabel.Text = "Приоритет";
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Location = new Point(197, 44);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new Size(24, 15);
            tagLabel.TabIndex = 30;
            tagLabel.Text = "Тег";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(91, 44);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 15);
            nameLabel.TabIndex = 31;
            nameLabel.Text = "Название";
            // 
            // TaskEditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(764, 225);
            Controls.Add(idLabel);
            Controls.Add(minsLabel);
            Controls.Add(labelHours);
            Controls.Add(dateLabel);
            Controls.Add(durationLabel);
            Controls.Add(priorityLabel);
            Controls.Add(tagLabel);
            Controls.Add(nameLabel);
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
        private Label idLabel;
        private Label minsLabel;
        private Label labelHours;
        private Label dateLabel;
        private Label durationLabel;
        private Label priorityLabel;
        private Label tagLabel;
        private Label nameLabel;
    }
}