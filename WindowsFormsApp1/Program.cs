using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var mutex = new Mutex(true, "Global\\WindowsFormsApp"))
            {
                try
                {
                    if (!mutex.WaitOne(1000))
                        return;//application already running

                    // Add the event handler for handling UI thread exceptions to the event.
                    Application.ThreadException += UIThreadException;

                    // Set the unhandled exception mode to force all Windows Forms errors to go through
                    // our handler.
                    Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                    // Add the event handler for handling non-UI thread exceptions to the event. 
                    AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

                    TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
        }

        private static void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            ShowExceptionDialog("Unobserved exception ocurred", e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            ShowExceptionDialog("Unhandled exception", ex);
        }

        private static void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            ShowExceptionDialog("Windows Forms Error [UI Thread]", t.Exception);
        }

        // Creates the error message and displays it.
        private static void ShowExceptionDialog(string title, Exception e)
        {
            var builder = new StringBuilder();

            builder.AppendLine(e.Message);
            if (e is AggregateException)
            {
                foreach (var ex in (e as AggregateException).InnerExceptions)
                {
                    builder.AppendLine(ex.Message);
                }
            }
            else if (e.InnerException != null)
            {
                builder.AppendLine(e.InnerException.Message);
            }

            var dialogResult = MessageBox.Show(builder.ToString(), title, MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Stop);


            // Exits the program when the user clicks Abort.
            if (dialogResult == DialogResult.Abort)
                Application.Exit();
        }

    }
}
