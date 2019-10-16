using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler.Models
{
    class HighTask : ObjectiveTask
    {
        public HighTask() : base(stubCounter: 10, priority: 1)
        {

        }
        public override string ToString()
        {
            return "Тяжелая " + base.ToString();
        }
    }
}
