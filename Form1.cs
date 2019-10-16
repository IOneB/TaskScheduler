using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TaskScheduler.Models;

namespace TaskScheduler
{
    public partial class Form1 : Form
    {
        private readonly Models.TaskScheduler taskScheduler;

        public Form1()
        {
            InitializeComponent();
            taskScheduler = new Models.TaskScheduler(sync: System.Threading.SynchronizationContext.Current);
            taskScheduler.OnChange += TasksChange;
            taskScheduler.OnComplete += TaskScheduler_OnComplete;
            taskScheduler.OnCurrentChange += TaskScheduler_OnCurrentChange;
            taskScheduler.OnExecute += TaskScheduler_OnExecute;
        }

        private void TaskScheduler_OnExecute(int id)
        {
            if (!IsDisposed)
                log.AppendText($"Задача {id} выполняется\r\n");
        }

        private void TaskScheduler_OnCurrentChange(ITask task)
        {
            if (!IsDisposed)
                currentTask.Text = task.ToString();
        }

        private void TaskScheduler_OnComplete(int id)
        {
            if (!IsDisposed)
                log.AppendText($"Задача {id} завершена\r\n");
        }

        private void CreateHighTask_Click(object sender, EventArgs e)
        {
            taskScheduler.Add(new HighTask());
        }

        private void CreateLightTask_Click(object sender, EventArgs e)
        {
            taskScheduler.Add(new LigthTask());
        }

        private void TasksChange(int id)
        {
            if (IsDisposed)
                return;
            tasks.Items.Clear();
            ListViewItem selector(ITask task) => new ListViewItem(task.ToString(), tasks.Groups[0]);
            ListViewItem[] items = taskScheduler.Tasks
                                    .Select(selector)
                                    .ToArray();
            tasks.Items.AddRange(items);
            if (items.Length == 0)
                currentTask.Text = string.Empty;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            taskScheduler.Start();
            startButton.Enabled = false;
        }

        protected override void OnClosed(EventArgs e)
        {
            taskScheduler.Dispose();
            base.OnClosed(e);
        }
    }
}
