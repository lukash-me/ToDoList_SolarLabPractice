using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class TasksCollection : List<object>
    {
        public List<Tasks> list;

        public TasksCollection()
        {
            List<Tasks> list = new List<Tasks>();
        }
    }
}
