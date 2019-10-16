using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskScheduler.Models
{
    class TaskScheduler : IDisposable
    { 
        Thread mainThread;
        private readonly SynchronizationContext sync;

        public List<ITask> Tasks { get; }
        public event Action<int> OnChange;
        public event Action<int> OnExecute;
        public event Action<int> OnComplete;
        public event Action<ITask> OnCurrentChange;

        public TaskScheduler(SynchronizationContext sync)
        {
            Tasks = new List<ITask>();
            this.sync = sync;
        }

        public void InvokeAction<T>(Action<T> act, T parameter)
        {
            sync.Post(state => act?.Invoke((T)state), parameter);
        }


        internal void Add(ITask task)
        {
            Tasks.Add(task);
            Tasks.Sort((x,y) => y.Priority - x.Priority);
            InvokeAction(OnChange, task.Id);

            task.OnComplete += Task_OnComplete;
            task.OnExecute += Task_OnExecute;
        }

        private void Task_OnExecute(int id)
        {
            InvokeAction(OnExecute, id);
        }

        private void Task_OnComplete(int id)
        {
            InvokeAction(OnComplete, id);

            var task = Tasks.FirstOrDefault(t => t.Id == id);
            Tasks.Remove(task);
            InvokeAction(OnChange, task.Id);
            task.OnComplete -= Task_OnComplete;
            task.OnExecute -= Task_OnExecute;
        }

        public void Start()
        {
            if (mainThread == null)
            {
                mainThread = new Thread(Action)
                {
                    IsBackground = true
                };
                mainThread.Start();
            }
        }

        public void Action()
        {
            int _taskIndex = 0;
            while (true)
            {
                ITask current = null;
                if (_taskIndex >= Tasks.Count)
                    _taskIndex = 0;
                if (Tasks.Count > 0)
                {
                    current = Tasks[_taskIndex++];
                    current.DoWork();
                    InvokeAction(OnCurrentChange, current);
                }
                Thread.Sleep(Random.Get(min: 1900));
                current?.Pause();
            }
        }

        public void Dispose()
        {
            mainThread?.Abort();
            Tasks?.ForEach(t => t.Dispose());
        }
    }
}
