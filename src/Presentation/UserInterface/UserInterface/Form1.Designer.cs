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
            button1 = new Button();
            button2 = new Button();
            TaskPriorityComboBox = new ComboBox();
            taskNameTextBox = new TextBox();
            taskTagTextBox = new TextBox();
            taskDurationTextBox = new TextBox();
            taskDeadlineDateBox = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(195, 296);
            button1.Name = "button1";
            button1.Size = new Size(354, 23);
            button1.TabIndex = 0;
            button1.Text = "Добавить задачу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(195, 344);
            button2.Name = "button2";
            button2.Size = new Size(354, 23);
            button2.TabIndex = 1;
            button2.Text = "Сохранить список";
            button2.UseVisualStyleBackColor = true;
            // 
            // TaskPriorityComboBox
            // 
            TaskPriorityComboBox.FormattingEnabled = true;
            TaskPriorityComboBox.Location = new Point(308, 143);
            TaskPriorityComboBox.Name = "TaskPriorityComboBox";
            TaskPriorityComboBox.Size = new Size(121, 23);
            TaskPriorityComboBox.TabIndex = 2;
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Location = new Point(55, 143);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(100, 23);
            taskNameTextBox.TabIndex = 3;
            // 
            // taskTagTextBox
            // 
            taskTagTextBox.Location = new Point(183, 143);
            taskTagTextBox.Name = "taskTagTextBox";
            taskTagTextBox.Size = new Size(100, 23);
            taskTagTextBox.TabIndex = 4;
            // 
            // taskDurationTextBox
            // 
            taskDurationTextBox.Location = new Point(459, 143);
            taskDurationTextBox.Name = "taskDurationTextBox";
            taskDurationTextBox.Size = new Size(100, 23);
            taskDurationTextBox.TabIndex = 5;
            // 
            // taskDeadlineDateBox
            // 
            taskDeadlineDateBox.Location = new Point(588, 143);
            taskDeadlineDateBox.Name = "taskDeadlineDateBox";
            taskDeadlineDateBox.Size = new Size(200, 23);
            taskDeadlineDateBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(taskDeadlineDateBox);
            Controls.Add(taskDurationTextBox);
            Controls.Add(taskTagTextBox);
            Controls.Add(taskNameTextBox);
            Controls.Add(TaskPriorityComboBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "ToDo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox TaskPriorityComboBox;
        private TextBox taskNameTextBox;
        private TextBox taskTagTextBox;
        private TextBox taskDurationTextBox;
        private DateTimePicker taskDeadlineDateBox;
    }
}
