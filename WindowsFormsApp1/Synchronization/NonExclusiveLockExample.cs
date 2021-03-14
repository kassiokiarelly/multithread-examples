using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Synchronization
{
    public class NonExclusiveLockExample : Example
    {
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);
        static ReaderWriterLockSlim readWriterLock = new ReaderWriterLockSlim();
        private List<int> numberList = new List<int>();

        public NonExclusiveLockExample(Action<string> print) : base(print)
        {
        }

        public void StartSemaphore()
        {
            for (int i = 0; i < 5; i++)
            {
                var temp = i;
                new Thread(_ => DoSomething(temp)).Start();
            }
        }

        public void DoSomething(int id)
        {
            print($"Try do something for id {id}");
            semaphoreSlim.Wait();
            print($"ID {id} entered the semaphore");
            Thread.Sleep(1000 * (int)id); // can be here at
            print(id + " is leaving"); // a time.
            semaphoreSlim.Release();
        }

        public void StartReadWriterLock()
        {
            new Thread(ReadList).Start();
            new Thread(ReadList).Start();
            new Thread(ReadList).Start();

            var write1 = new Thread(WriteList);
            write1.Name = "Write1";
            var write2 = new Thread(WriteList);
            write2.Name = "Write2";
            write1.Start();
            write2.Start();
        }

        private void ReadList()
        {
            var run = true;
            while (run)
            {
                try
                {
                    readWriterLock.EnterReadLock();
                    int count = 0;
                    foreach (var item in numberList)
                    {
                        count++;
                    }
                    if (count > 50)
                        run = false;
                }
                finally
                {
                    readWriterLock.ExitReadLock();
                }
            }
        }

        private void WriteList()
        {
            var run = true;
            while (run)
            {
                var rand = new Random();
                var value = rand.Next(999);
                try
                {
                    readWriterLock.EnterWriteLock();
                    numberList.Add(value);
                    print($"Thread {Thread.CurrentThread.Name} just added the value {value}");
                    Thread.Sleep(value);
                    if (numberList.Count > 50)
                        run = false;
                }
                finally
                {
                    readWriterLock.ExitWriteLock();
                }
            }
        }


    }
}
