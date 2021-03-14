using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Synchronization
{
    public abstract class Example
    {
        protected Action<string> print;

        public Example(Action<string> print)
        {
            this.print = print;
        }
    }
}
