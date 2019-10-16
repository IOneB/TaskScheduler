using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler.Models
{
    class LigthTask : ObjectiveTask
    {
        public LigthTask()
            : base(stubCounter: 5, priority: 0)
        {

        }
        public override string ToString()
        {
            return "Легкая " + base.ToString();
        }
    }
}
