using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler.Models
{
    interface ITask : IDisposable
    {
        event Action<int> OnExecute;
        event Action<int> OnComplete;
        int Priority { get; }
        int Id { get; }
        void DoWork();
        void Pause();
    }
}
