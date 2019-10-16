namespace TaskScheduler
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Очередь", System.Windows.Forms.HorizontalAlignment.Left);
            this.createLightTask = new System.Windows.Forms.Button();
            this.createHighTask = new System.Windows.Forms.Button();
            this.tasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentTask = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createLightTask
            // 
            this.createLightTask.Location = new System.Drawing.Point(620, 400);
            this.createLightTask.Name = "createLightTask";
            this.createLightTask.Size = new System.Drawing.Size(151, 38);
            this.createLightTask.TabIndex = 0;
            this.createLightTask.Text = "Создать легкую задачу";
            this.createLightTask.UseVisualStyleBackColor = true;
            this.createLightTask.Click += new System.EventHandler(this.CreateLightTask_Click);
            // 
            // createHighTask
            // 
            this.createHighTask.Location = new System.Drawing.Point(449, 400);
            this.createHighTask.Name = "createHighTask";
            this.createHighTask.Size = new System.Drawing.Size(151, 38);
            this.createHighTask.TabIndex = 0;
            this.createHighTask.Text = "Создать тяжелую задачу";
            this.createHighTask.UseVisualStyleBackColor = true;
            this.createHighTask.Click += new System.EventHandler(this.CreateHighTask_Click);
            // 
            // tasks
            // 
            this.tasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            listViewGroup4.Header = "Очередь";
            listViewGroup4.Name = "listViewGroup1";
            this.tasks.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4});
            this.tasks.HideSelection = false;
            this.tasks.Location = new System.Drawing.Point(12, 12);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(225, 355);
            this.tasks.TabIndex = 1;
            this.tasks.UseCompatibleStateImageBehavior = false;
            this.tasks.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Очередь";
            this.columnHeader1.Width = 500;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.log.Location = new System.Drawing.Point(256, 31);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(532, 336);
            this.log.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "История действий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Текущая задача";
            // 
            // currentTask
            // 
            this.currentTask.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentTask.Location = new System.Drawing.Point(12, 395);
            this.currentTask.Name = "currentTask";
            this.currentTask.ReadOnly = true;
            this.currentTask.Size = new System.Drawing.Size(225, 20);
            this.currentTask.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(281, 400);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(151, 38);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Запустить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.currentTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.tasks);
            this.Controls.Add(this.createHighTask);
            this.Controls.Add(this.createLightTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createLightTask;
        private System.Windows.Forms.Button createHighTask;
        private System.Windows.Forms.ListView tasks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentTask;
        private System.Windows.Forms.Button startButton;
    }
}

