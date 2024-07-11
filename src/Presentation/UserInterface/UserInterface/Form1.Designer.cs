namespace UserInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addTaskButton = new Button();
            button2 = new Button();
            TaskPriorityComboBox = new ComboBox();
            taskNameTextBox = new TextBox();
            taskTagTextBox = new TextBox();
            taskDurationTextBox = new TextBox();
            taskDeadlineDateBox = new DateTimePicker();
            RefreshButton = new Button();
            TasksListView = new ListView();
            idTasksListView = new ColumnHeader();
            nameTasksListView = new ColumnHeader();
            tagTasksListView = new ColumnHeader();
            priorityTasksListView = new ColumnHeader();
            statusTasksListView = new ColumnHeader();
            durationTasksListView = new ColumnHeader();
            deadlineTasksListView = new ColumnHeader();
            taskIdUpDown = new NumericUpDown();
            label1 = new Label();
            taskMinsComboBox = new ComboBox();
            taskHoursComboBox = new ComboBox();
            startTaskButton = new Button();
            actualIdcomboBox = new ComboBox();
            completeTaskButton = new Button();
            fontDialog1 = new FontDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            editTaskButton = new Button();
            deleteTaskButton = new Button();
            ((System.ComponentModel.ISupportInitialize)taskIdUpDown).BeginInit();
            SuspendLayout();
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(205, 82);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(354, 23);
            addTaskButton.TabIndex = 0;
            addTaskButton.Text = "Добавить задачу";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 232);
            button2.Name = "button2";
            button2.Size = new Size(354, 23);
            button2.TabIndex = 1;
            button2.Text = "Сохранить список";
            button2.UseVisualStyleBackColor = true;
            // 
            // TaskPriorityComboBox
            // 
            TaskPriorityComboBox.FormattingEnabled = true;
            TaskPriorityComboBox.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий", "Срочно" });
            TaskPriorityComboBox.Location = new Point(308, 53);
            TaskPriorityComboBox.Name = "TaskPriorityComboBox";
            TaskPriorityComboBox.Size = new Size(121, 23);
            TaskPriorityComboBox.TabIndex = 2;
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Location = new Point(96, 53);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(100, 23);
            taskNameTextBox.TabIndex = 3;
            // 
            // taskTagTextBox
            // 
            taskTagTextBox.Location = new Point(202, 53);
            taskTagTextBox.Name = "taskTagTextBox";
            taskTagTextBox.Size = new Size(100, 23);
            taskTagTextBox.TabIndex = 4;
            // 
            // taskDurationTextBox
            // 
            taskDurationTextBox.Location = new Point(435, 53);
            taskDurationTextBox.Name = "taskDurationTextBox";
            taskDurationTextBox.Size = new Size(100, 23);
            taskDurationTextBox.TabIndex = 5;
            // 
            // taskDeadlineDateBox
            // 
            taskDeadlineDateBox.CustomFormat = "";
            taskDeadlineDateBox.Format = DateTimePickerFormat.Short;
            taskDeadlineDateBox.Location = new Point(550, 53);
            taskDeadlineDateBox.MinDate = new DateTime(2024, 7, 10, 0, 0, 0, 0);
            taskDeadlineDateBox.Name = "taskDeadlineDateBox";
            taskDeadlineDateBox.Size = new Size(89, 23);
            taskDeadlineDateBox.TabIndex = 6;
            taskDeadlineDateBox.TabStop = false;
            taskDeadlineDateBox.Value = new DateTime(2024, 7, 10, 0, 0, 0, 0);
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(12, 232);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(75, 23);
            RefreshButton.TabIndex = 8;
            RefreshButton.Text = "Обновить";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // TasksListView
            // 
            TasksListView.Columns.AddRange(new ColumnHeader[] { idTasksListView, nameTasksListView, tagTasksListView, priorityTasksListView, statusTasksListView, durationTasksListView, deadlineTasksListView });
            TasksListView.GridLines = true;
            TasksListView.Location = new Point(12, 261);
            TasksListView.Name = "TasksListView";
            TasksListView.Size = new Size(776, 177);
            TasksListView.TabIndex = 9;
            TasksListView.UseCompatibleStateImageBehavior = false;
            TasksListView.View = View.Details;
            // 
            // idTasksListView
            // 
            idTasksListView.Text = "Номер";
            // 
            // nameTasksListView
            // 
            nameTasksListView.Text = "Название";
            nameTasksListView.TextAlign = HorizontalAlignment.Center;
            nameTasksListView.Width = 180;
            // 
            // tagTasksListView
            // 
            tagTasksListView.Tag = "";
            tagTasksListView.Text = "Тег";
            tagTasksListView.TextAlign = HorizontalAlignment.Center;
            tagTasksListView.Width = 130;
            // 
            // priorityTasksListView
            // 
            priorityTasksListView.Text = "Приоритет";
            priorityTasksListView.TextAlign = HorizontalAlignment.Center;
            priorityTasksListView.Width = 100;
            // 
            // statusTasksListView
            // 
            statusTasksListView.Text = "Статус";
            statusTasksListView.TextAlign = HorizontalAlignment.Center;
            statusTasksListView.Width = 80;
            // 
            // durationTasksListView
            // 
            durationTasksListView.Text = "Длительность";
            durationTasksListView.TextAlign = HorizontalAlignment.Center;
            durationTasksListView.Width = 100;
            // 
            // deadlineTasksListView
            // 
            deadlineTasksListView.Text = "Дедлайн";
            deadlineTasksListView.TextAlign = HorizontalAlignment.Center;
            deadlineTasksListView.Width = 120;
            // 
            // taskIdUpDown
            // 
            taskIdUpDown.Location = new Point(9, 53);
            taskIdUpDown.Name = "taskIdUpDown";
            taskIdUpDown.Size = new Size(67, 23);
            taskIdUpDown.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 117);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // taskMinsComboBox
            // 
            taskMinsComboBox.FormattingEnabled = true;
            taskMinsComboBox.Items.AddRange(new object[] { "1", "2", "4", "5", "6", "7", "8", "9", "10" });
            taskMinsComboBox.Location = new Point(702, 52);
            taskMinsComboBox.Name = "taskMinsComboBox";
            taskMinsComboBox.Size = new Size(38, 23);
            taskMinsComboBox.TabIndex = 12;
            // 
            // taskHoursComboBox
            // 
            taskHoursComboBox.FormattingEnabled = true;
            taskHoursComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            taskHoursComboBox.Location = new Point(658, 52);
            taskHoursComboBox.Name = "taskHoursComboBox";
            taskHoursComboBox.Size = new Size(38, 23);
            taskHoursComboBox.TabIndex = 12;
            // 
            // startTaskButton
            // 
            startTaskButton.Location = new Point(91, 144);
            startTaskButton.Name = "startTaskButton";
            startTaskButton.Size = new Size(97, 52);
            startTaskButton.TabIndex = 13;
            startTaskButton.Text = "Приступить к выполнению";
            startTaskButton.UseVisualStyleBackColor = true;
            startTaskButton.Click += startTaskButton_Click;
            // 
            // actualIdcomboBox
            // 
            actualIdcomboBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            actualIdcomboBox.FormattingEnabled = true;
            actualIdcomboBox.Location = new Point(9, 152);
            actualIdcomboBox.Name = "actualIdcomboBox";
            actualIdcomboBox.Size = new Size(58, 33);
            actualIdcomboBox.TabIndex = 12;
            // 
            // completeTaskButton
            // 
            completeTaskButton.Location = new Point(194, 144);
            completeTaskButton.Name = "completeTaskButton";
            completeTaskButton.Size = new Size(108, 52);
            completeTaskButton.TabIndex = 14;
            completeTaskButton.Text = "Пометить выполненной";
            completeTaskButton.UseVisualStyleBackColor = true;
            completeTaskButton.Click += completeTaskButton_Click;
            // 
            // editTaskButton
            // 
            editTaskButton.Location = new Point(308, 144);
            editTaskButton.Name = "editTaskButton";
            editTaskButton.Size = new Size(108, 52);
            editTaskButton.TabIndex = 15;
            editTaskButton.Text = "Редактировать";
            editTaskButton.UseVisualStyleBackColor = true;
            editTaskButton.Click += editTaskButton_Click;
            // 
            // deleteTaskButton
            // 
            deleteTaskButton.Location = new Point(422, 144);
            deleteTaskButton.Name = "deleteTaskButton";
            deleteTaskButton.Size = new Size(101, 52);
            deleteTaskButton.TabIndex = 16;
            deleteTaskButton.Text = "Удалить";
            deleteTaskButton.UseVisualStyleBackColor = true;
            deleteTaskButton.Click += deleteTaskButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteTaskButton);
            Controls.Add(editTaskButton);
            Controls.Add(completeTaskButton);
            Controls.Add(startTaskButton);
            Controls.Add(actualIdcomboBox);
            Controls.Add(taskHoursComboBox);
            Controls.Add(taskMinsComboBox);
            Controls.Add(label1);
            Controls.Add(taskIdUpDown);
            Controls.Add(TasksListView);
            Controls.Add(RefreshButton);
            Controls.Add(taskDeadlineDateBox);
            Controls.Add(taskDurationTextBox);
            Controls.Add(taskTagTextBox);
            Controls.Add(taskNameTextBox);
            Controls.Add(TaskPriorityComboBox);
            Controls.Add(button2);
            Controls.Add(addTaskButton);
            Name = "Form1";
            Text = "ToDo";
            ((System.ComponentModel.ISupportInitialize)taskIdUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addTaskButton;
        private Button button2;
        private ComboBox TaskPriorityComboBox;
        private TextBox taskNameTextBox;
        private TextBox taskTagTextBox;
        private TextBox taskDurationTextBox;
        private DateTimePicker taskDeadlineDateBox;
        private Button RefreshButton;
        private ListView TasksListView;
        private ColumnHeader nameTasksListView;
        private ColumnHeader tagTasksListView;
        private ColumnHeader priorityTasksListView;
        private ColumnHeader statusTasksListView;
        private ColumnHeader durationTasksListView;
        private ColumnHeader deadlineTasksListView;
        private ColumnHeader idTasksListView;
        private NumericUpDown taskIdUpDown;
        private Label label1;
        private ComboBox taskMinsComboBox;
        private ComboBox taskHoursComboBox;
        private Button startTaskButton;
        private ComboBox actualIdcomboBox;
        private Button completeTaskButton;
        private FontDialog fontDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button editTaskButton;
        private Button deleteTaskButton;
    }
}
