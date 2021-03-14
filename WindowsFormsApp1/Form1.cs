using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Synchronization;
using WindowsFormsApp1.Util;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {


            using (var webclient = new WebClient())
            {
                var result = await webclient.DownloadDataTaskAsync(new Uri("https://kassio.net"));
                textBox1.Text += $"Downloaded {result.Length} bytes\r\n";
            }
        }

        private async void primeNumbersCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var primeNumbers = new PrimeNumbers();
            for (int i = 1; i <= 10; i++)
            {
                var start = i * 1000000;
                var count = await primeNumbers.GetPrimesCountAsync(start, 1000000);
                textBox1.Text += $"{count} primes between {start} and {((i + 1) * 1000000 - 1)}\r\n";
            }
        }

        private void primeNumbersTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            primeNumbersTaskToolStripMenuItem.Enabled = false;
            Task.Run(() => Go());
        }

        void Go()
        {
            var primeNumbers = new PrimeNumbers();
            for (int i = 1; i < 5; i++)
            {
                int result = primeNumbers.GetPrimesCount(i * 1000000, 1000000);
                BeginInvoke(new Action(() =>
              textBox1.Text += result + " primes between " + (i * 1000000) +
              " and " + ((i + 1) * 1000000 - 1) + Environment.NewLine));
            }
            BeginInvoke(new Action(() => primeNumbersTaskToolStripMenuItem.Enabled = true));
        }

        private void throwUnhandledExToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new Exception("Exception ocurred on UI thread.");
        }

        private void threadUnhandledExToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Thread(_ => throw new Exception("Exception ocurred on worker thread.")).Start();
        }

        async Task<int> Delay1() { await Task.Delay(1000); return 1; }
        async Task<int> Delay2() { await Task.Delay(2000); return 2; }
        async Task<int> Delay3() { await Task.Delay(3000); return 3; }

        private async void taskCombinatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Task combinators Task.WhenAny and Task.WhenAll

            //if a task other then winningTask throw an exception it will be unobserved
            var winningTask = await Task.WhenAny(Delay1(), Delay2(), Delay3());
            textBox1.Text += winningTask.Result + Environment.NewLine;

            var allTask = await Task.WhenAll(Delay1(), Delay2(), Delay3());
            foreach (var result in allTask)
            {
                textBox1.Text += "WhenAll: " + result + Environment.NewLine;
            }
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var monitor = new ExclusiveLockExample(AddOutput);
            var t1 = new Thread(monitor.DivideValues);
            t1.Name = "T1";
            var t2 = new Thread(monitor.DivideValues);
            t2.Name = "T2";

            t1.Start();
            t2.Start();
        }

        private void semaphoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nonexclusiveLock = new NonExclusiveLockExample(AddOutput);
            nonexclusiveLock.StartSemaphore();
        }

        private void AddOutput(string text)
        {
            if (InvokeRequired)
                BeginInvoke(new Action(() => AddOutput(text)));
            else
                textBox1.Text += text + Environment.NewLine;
        }

        private void readWriterLockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nonexclusiveLock = new NonExclusiveLockExample(AddOutput);
            nonexclusiveLock.StartReadWriterLock();
        }

        private void manualResetEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var signaling = new SignalingExample(AddOutput);
            signaling.RunManualResetExample();
        }

        private void autoResetEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var signaling = new SignalingExample(AddOutput);
            signaling.RunAutoResetExample();
        }
    }
}
