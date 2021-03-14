using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Synchronization
{
    public class ExclusiveLockExample : Example
    {
        static int Value1 = 20;
        static int Value2 = 10;
        object _lock = new object();

        public ExclusiveLockExample(Action<string> print) : base(print)
        {
        }

        public void DivideValues()
        {
            if (Value2 != 0)
                print(Thread.CurrentThread.Name + Environment.NewLine + (Value1 / Value2));
            Value2 = 0;
        }

        public void DivideValuesWithLock()
        {
            lock (_lock)
            {
                if (Value2 != 0)
                    print(Thread.CurrentThread.Name + Environment.NewLine + (Value1 / Value2));
                Value2 = 0;
            }
        }

        public void DivideValuesWithMonitor()
        {
            Monitor.Enter(_lock);
            try
            {
                if (Value2 != 0)
                    print(Thread.CurrentThread.Name + Environment.NewLine + (Value1 / Value2));
                Value2 = 0;
            }
            finally
            {
                Monitor.Exit(_lock);
            }
        }

        public void DivideValuesWithMonitor2()
        {
            bool lockTaken = false;
            try
            {
                Monitor.Enter(_lock, ref lockTaken);
                if (Value2 != 0)
                    print(Thread.CurrentThread.Name + Environment.NewLine + (Value1 / Value2));
                Value2 = 0;
            }
            finally
            {
                if (lockTaken)
                    Monitor.Exit(_lock);
            }
        }
    }
}
