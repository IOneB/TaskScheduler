using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskScheduler.Models
{
    abstract class ObjectiveTask : ITask
    {
        protected readonly int _stubCounter;
        private ManualResetEventSlim _lock;
        private Thread _taskThread;

        public event Action<int> OnExecute;
        public event Action<int> OnComplete;

        public int Priority { get; }
        public int Id { get; }

        protected ObjectiveTask(int stubCounter, int priority)
        {
            _stubCounter = stubCounter;
            Priority = priority;
            Id = IdMaker.MakeId();
            _lock = new ManualResetEventSlim(false);

            _taskThread = new Thread(InnerWork)
            {
                IsBackground = true
            };
            _taskThread.Start();
        }

        public void DoWork()
        {
            _lock.Set();
        }

        public void Pause()
        {
            _lock.Reset();
        }

        private void InnerWork()
        {
            _lock.Wait();
            for (int i = 0; i < _stubCounter; i++)
            {
                Thread.Sleep(Random.Get(max:1200));
                _lock.Wait();
                OnExecute?.Invoke(Id);
            }
            _lock.Wait();
            Thread.Sleep(Random.Get(max: 1200));
            OnComplete?.Invoke(Id);
        }

        public override string ToString()
            => $"Задача {Id}";

        public void Dispose()
        {
            _taskThread.Abort();
        }
    }
}
