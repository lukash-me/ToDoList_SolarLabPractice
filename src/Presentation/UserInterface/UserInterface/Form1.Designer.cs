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
            saveButton = new Button();
            TaskPriorityComboBox = new ComboBox();
            taskNameTextBox = new TextBox();
            taskTagTextBox = new TextBox();
            taskDurationTextBox = new TextBox();
            taskDeadlineDateBox = new DateTimePicker();
            TasksListView = new ListView();
            idTasksListView = new ColumnHeader();
            nameTasksListView = new ColumnHeader();
            tagTasksListView = new ColumnHeader();
            priorityTasksListView = new ColumnHeader();
            statusTasksListView = new ColumnHeader();
            durationTasksListView = new ColumnHeader();
            deadlineTasksListView = new ColumnHeader();
            taskIdUpDown = new NumericUpDown();
            taskMinsComboBox = new ComboBox();
            taskHoursComboBox = new ComboBox();
            startTaskButton = new Button();
            actualIdcomboBox = new ComboBox();
            completeTaskButton = new Button();
            editTaskButton = new Button();
            deleteTaskButton = new Button();
            idToEdit = new Label();
            filterComboBox = new ComboBox();
            filterButton = new Button();
            saveAsButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            loadButton = new Button();
            nameLabel = new Label();
            idLabel = new Label();
            tagLabel = new Label();
            priorityLabel = new Label();
            durationLabel = new Label();
            dateLabel = new Label();
            labelHours = new Label();
            minsLabel = new Label();
            filterLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)taskIdUpDown).BeginInit();
            SuspendLayout();
            // 
            // addTaskButton
            // 
            addTaskButton.BackgroundImage = Properties.Resources.ButtonColor;
            addTaskButton.FlatStyle = FlatStyle.Flat;
            addTaskButton.ForeColor = Color.Black;
            addTaskButton.Location = new Point(205, 102);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(368, 30);
            addTaskButton.TabIndex = 0;
            addTaskButton.Text = "Добавить задачу";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackgroundImage = Properties.Resources.ButtonColor;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Location = new Point(9, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(101, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // TaskPriorityComboBox
            // 
            TaskPriorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TaskPriorityComboBox.FormattingEnabled = true;
            TaskPriorityComboBox.Items.AddRange(new object[] { "", "Низкий", "Средний", "Высокий", "Срочно" });
            TaskPriorityComboBox.Location = new Point(311, 73);
            TaskPriorityComboBox.Name = "TaskPriorityComboBox";
            TaskPriorityComboBox.Size = new Size(121, 23);
            TaskPriorityComboBox.TabIndex = 2;
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Location = new Point(99, 73);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(100, 23);
            taskNameTextBox.TabIndex = 3;
            // 
            // taskTagTextBox
            // 
            taskTagTextBox.Location = new Point(205, 73);
            taskTagTextBox.Name = "taskTagTextBox";
            taskTagTextBox.Size = new Size(100, 23);
            taskTagTextBox.TabIndex = 4;
            // 
            // taskDurationTextBox
            // 
            taskDurationTextBox.Location = new Point(438, 73);
            taskDurationTextBox.Name = "taskDurationTextBox";
            taskDurationTextBox.Size = new Size(135, 23);
            taskDurationTextBox.TabIndex = 5;
            // 
            // taskDeadlineDateBox
            // 
            taskDeadlineDateBox.CustomFormat = "";
            taskDeadlineDateBox.Format = DateTimePickerFormat.Short;
            taskDeadlineDateBox.Location = new Point(593, 73);
            taskDeadlineDateBox.MinDate = new DateTime(2024, 7, 10, 0, 0, 0, 0);
            taskDeadlineDateBox.Name = "taskDeadlineDateBox";
            taskDeadlineDateBox.Size = new Size(75, 23);
            taskDeadlineDateBox.TabIndex = 6;
            taskDeadlineDateBox.TabStop = false;
            taskDeadlineDateBox.Value = new DateTime(2024, 7, 12, 0, 0, 0, 0);
            // 
            // TasksListView
            // 
            TasksListView.Columns.AddRange(new ColumnHeader[] { idTasksListView, nameTasksListView, tagTasksListView, priorityTasksListView, statusTasksListView, durationTasksListView, deadlineTasksListView });
            TasksListView.GridLines = true;
            TasksListView.Location = new Point(0, 273);
            TasksListView.Name = "TasksListView";
            TasksListView.Size = new Size(800, 177);
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
            taskIdUpDown.Location = new Point(12, 73);
            taskIdUpDown.Maximum = new decimal(new int[] { 101, 0, 0, 0 });
            taskIdUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            taskIdUpDown.Name = "taskIdUpDown";
            taskIdUpDown.Size = new Size(67, 23);
            taskIdUpDown.TabIndex = 10;
            taskIdUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // taskMinsComboBox
            // 
            taskMinsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            taskMinsComboBox.FormattingEnabled = true;
            taskMinsComboBox.Items.AddRange(new object[] { "0", "1", "2", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21 ", "22 ", "23 ", "24 ", "25 ", "26 ", "27 ", "28 ", "29 ", "30 ", "31 ", "32 ", "33 ", "34 ", "35 ", "36 ", "37 ", "38 ", "39 ", "40 ", "41 ", "42 ", "43 ", "44 ", "45 ", "46 ", "47 ", "48 ", "49 ", "50 ", "51 ", "52 ", "53 ", "54 ", "55 ", "56 ", "57 ", "58 ", "59" });
            taskMinsComboBox.Location = new Point(718, 73);
            taskMinsComboBox.Name = "taskMinsComboBox";
            taskMinsComboBox.Size = new Size(38, 23);
            taskMinsComboBox.TabIndex = 12;
            // 
            // taskHoursComboBox
            // 
            taskHoursComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            taskHoursComboBox.FormattingEnabled = true;
            taskHoursComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            taskHoursComboBox.Location = new Point(674, 73);
            taskHoursComboBox.Name = "taskHoursComboBox";
            taskHoursComboBox.Size = new Size(38, 23);
            taskHoursComboBox.TabIndex = 12;
            // 
            // startTaskButton
            // 
            startTaskButton.BackColor = Color.PaleTurquoise;
            startTaskButton.FlatStyle = FlatStyle.Flat;
            startTaskButton.Location = new Point(127, 167);
            startTaskButton.Name = "startTaskButton";
            startTaskButton.Size = new Size(97, 52);
            startTaskButton.TabIndex = 13;
            startTaskButton.Text = "Приступить к выполнению";
            startTaskButton.UseVisualStyleBackColor = false;
            startTaskButton.Click += startTaskButton_Click;
            // 
            // actualIdcomboBox
            // 
            actualIdcomboBox.BackColor = Color.PaleTurquoise;
            actualIdcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            actualIdcomboBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            actualIdcomboBox.FormattingEnabled = true;
            actualIdcomboBox.ImeMode = ImeMode.NoControl;
            actualIdcomboBox.Location = new Point(12, 175);
            actualIdcomboBox.Name = "actualIdcomboBox";
            actualIdcomboBox.Size = new Size(98, 33);
            actualIdcomboBox.Sorted = true;
            actualIdcomboBox.TabIndex = 12;
            // 
            // completeTaskButton
            // 
            completeTaskButton.BackColor = Color.PaleTurquoise;
            completeTaskButton.FlatStyle = FlatStyle.Flat;
            completeTaskButton.Location = new Point(230, 167);
            completeTaskButton.Name = "completeTaskButton";
            completeTaskButton.Size = new Size(108, 52);
            completeTaskButton.TabIndex = 14;
            completeTaskButton.Text = "Пометить выполненной";
            completeTaskButton.UseVisualStyleBackColor = false;
            completeTaskButton.Click += completeTaskButton_Click;
            // 
            // editTaskButton
            // 
            editTaskButton.BackColor = Color.PaleTurquoise;
            editTaskButton.FlatStyle = FlatStyle.Flat;
            editTaskButton.Location = new Point(344, 167);
            editTaskButton.Name = "editTaskButton";
            editTaskButton.Size = new Size(108, 52);
            editTaskButton.TabIndex = 15;
            editTaskButton.Text = "Редактировать";
            editTaskButton.UseVisualStyleBackColor = false;
            editTaskButton.Click += editTaskButton_Click;
            // 
            // deleteTaskButton
            // 
            deleteTaskButton.BackColor = Color.PaleTurquoise;
            deleteTaskButton.FlatStyle = FlatStyle.Flat;
            deleteTaskButton.Location = new Point(458, 167);
            deleteTaskButton.Name = "deleteTaskButton";
            deleteTaskButton.Size = new Size(101, 52);
            deleteTaskButton.TabIndex = 16;
            deleteTaskButton.Text = "Удалить";
            deleteTaskButton.UseVisualStyleBackColor = false;
            deleteTaskButton.Click += deleteTaskButton_Click;
            // 
            // idToEdit
            // 
            idToEdit.AutoSize = true;
            idToEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            idToEdit.Location = new Point(12, 157);
            idToEdit.Name = "idToEdit";
            idToEdit.Size = new Size(45, 15);
            idToEdit.TabIndex = 17;
            idToEdit.Text = "Номер";
            // 
            // filterComboBox
            // 
            filterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { "Все", "Выполненные", "В работе", "В ожидании" });
            filterComboBox.Location = new Point(595, 232);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(87, 23);
            filterComboBox.TabIndex = 18;
            // 
            // filterButton
            // 
            filterButton.BackgroundImage = Properties.Resources.ButtonColor;
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Location = new Point(688, 232);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(100, 23);
            filterButton.TabIndex = 19;
            filterButton.Text = "Применить";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // saveAsButton
            // 
            saveAsButton.BackgroundImage = Properties.Resources.ButtonColor;
            saveAsButton.FlatStyle = FlatStyle.Flat;
            saveAsButton.Location = new Point(116, 3);
            saveAsButton.Name = "saveAsButton";
            saveAsButton.Size = new Size(134, 23);
            saveAsButton.TabIndex = 20;
            saveAsButton.Text = "Сохранить как...";
            saveAsButton.UseVisualStyleBackColor = true;
            saveAsButton.Click += saveAsButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.CheckPathExists = false;
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // loadButton
            // 
            loadButton.BackgroundImage = Properties.Resources.ButtonColor;
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Location = new Point(256, 3);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(98, 23);
            loadButton.TabIndex = 22;
            loadButton.Text = "Открыть";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(99, 55);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 15);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Название";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(9, 55);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(45, 15);
            idLabel.TabIndex = 23;
            idLabel.Text = "Номер";
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Location = new Point(205, 55);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new Size(24, 15);
            tagLabel.TabIndex = 23;
            tagLabel.Text = "Тег";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(311, 55);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(67, 15);
            priorityLabel.TabIndex = 23;
            priorityLabel.Text = "Приоритет";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(438, 55);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(135, 15);
            durationLabel.TabIndex = 23;
            durationLabel.Text = "Длительность (в часах)";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(593, 55);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(32, 15);
            dateLabel.TabIndex = 23;
            dateLabel.Text = "Дата";
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Location = new Point(674, 55);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(36, 15);
            labelHours.TabIndex = 23;
            labelHours.Text = "Часы";
            // 
            // minsLabel
            // 
            minsLabel.AutoSize = true;
            minsLabel.Location = new Point(716, 55);
            minsLabel.Name = "minsLabel";
            minsLabel.Size = new Size(52, 15);
            minsLabel.TabIndex = 23;
            minsLabel.Text = "Минуты";
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            filterLabel.Location = new Point(593, 214);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(51, 15);
            filterLabel.TabIndex = 17;
            filterLabel.Text = "Фильтр:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(idLabel);
            Controls.Add(minsLabel);
            Controls.Add(labelHours);
            Controls.Add(dateLabel);
            Controls.Add(durationLabel);
            Controls.Add(priorityLabel);
            Controls.Add(tagLabel);
            Controls.Add(nameLabel);
            Controls.Add(loadButton);
            Controls.Add(saveAsButton);
            Controls.Add(filterButton);
            Controls.Add(filterComboBox);
            Controls.Add(filterLabel);
            Controls.Add(idToEdit);
            Controls.Add(deleteTaskButton);
            Controls.Add(editTaskButton);
            Controls.Add(completeTaskButton);
            Controls.Add(startTaskButton);
            Controls.Add(actualIdcomboBox);
            Controls.Add(taskHoursComboBox);
            Controls.Add(taskMinsComboBox);
            Controls.Add(taskIdUpDown);
            Controls.Add(TasksListView);
            Controls.Add(taskDeadlineDateBox);
            Controls.Add(taskDurationTextBox);
            Controls.Add(taskTagTextBox);
            Controls.Add(taskNameTextBox);
            Controls.Add(TaskPriorityComboBox);
            Controls.Add(saveButton);
            Controls.Add(addTaskButton);
            Name = "Form1";
            Text = "ToDo";
            ((System.ComponentModel.ISupportInitialize)taskIdUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addTaskButton;
        private Button saveButton;
        private ComboBox TaskPriorityComboBox;
        private TextBox taskNameTextBox;
        private TextBox taskTagTextBox;
        private TextBox taskDurationTextBox;
        private DateTimePicker taskDeadlineDateBox;
        private ListView TasksListView;
        private ColumnHeader nameTasksListView;
        private ColumnHeader tagTasksListView;
        private ColumnHeader priorityTasksListView;
        private ColumnHeader statusTasksListView;
        private ColumnHeader durationTasksListView;
        private ColumnHeader deadlineTasksListView;
        private ColumnHeader idTasksListView;
        private NumericUpDown taskIdUpDown;
        private ComboBox taskMinsComboBox;
        private ComboBox taskHoursComboBox;
        private Button startTaskButton;
        private ComboBox actualIdcomboBox;
        private Button completeTaskButton;
        private Button editTaskButton;
        private Button deleteTaskButton;
        private Label idToEdit;
        private ComboBox filterComboBox;
        private Button filterButton;
        private Button saveAsButton;
        private OpenFileDialog openFileDialog1;
        private Button loadButton;
        private Label nameLabel;
        private Label idLabel;
        private Label tagLabel;
        private Label priorityLabel;
        private Label durationLabel;
        private Label dateLabel;
        private Label labelHours;
        private Label minsLabel;
        private Label filterLabel;
    }
}
