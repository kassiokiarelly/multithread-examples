using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Synchronization
{
    public class SignalingExample : Example
    {
        public SignalingExample(Action<string> print) : base(print)
        {
        }

        public void RunManualResetExample()
        {
            var manualResetEvent = new ManualResetEventSlim();
            var threads = new Thread[3];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() =>
                {
                    manualResetEvent.Wait();
                    print($"{Thread.CurrentThread.Name} - {DateTime.Now:dd/MM/yyyy hh:mm:ss.fffffff}");
                });
                threads[i].Name = $"T{i}";
                threads[i].Start();
            }
            print("ManualResetEvent Signal");
            manualResetEvent.Set();
        }

        public void RunAutoResetExample()
        {
            var autoResetEvent = new AutoResetEvent(false);
            var threads = new Thread[3];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() =>
                {
                    autoResetEvent.WaitOne();
                    print($"{Thread.CurrentThread.Name} - {DateTime.Now:dd/MM/yyyy hh:mm:ss.fffffff}");
                });
                threads[i].Name = $"T{i}";
                threads[i].Start();
            }
            print("AutoResetEvent Signal");
            autoResetEvent.Set();
        }
    }
}
