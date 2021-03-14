namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primeNumbersCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primeNumbersTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.throwUnhandledExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threadUnhandledExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskCombinatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchronizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semaphoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readWriterLockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualResetEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.autoResetEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.synchronizationToolStripMenuItem,
            this.signalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.primeNumbersCountToolStripMenuItem,
            this.primeNumbersTaskToolStripMenuItem,
            this.throwUnhandledExToolStripMenuItem,
            this.threadUnhandledExToolStripMenuItem,
            this.taskCombinatorsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // primeNumbersCountToolStripMenuItem
            // 
            this.primeNumbersCountToolStripMenuItem.Name = "primeNumbersCountToolStripMenuItem";
            this.primeNumbersCountToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.primeNumbersCountToolStripMenuItem.Text = "Prime numbers count";
            this.primeNumbersCountToolStripMenuItem.Click += new System.EventHandler(this.primeNumbersCountToolStripMenuItem_Click);
            // 
            // primeNumbersTaskToolStripMenuItem
            // 
            this.primeNumbersTaskToolStripMenuItem.Name = "primeNumbersTaskToolStripMenuItem";
            this.primeNumbersTaskToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.primeNumbersTaskToolStripMenuItem.Text = "Prime numbers task";
            this.primeNumbersTaskToolStripMenuItem.Click += new System.EventHandler(this.primeNumbersTaskToolStripMenuItem_Click);
            // 
            // throwUnhandledExToolStripMenuItem
            // 
            this.throwUnhandledExToolStripMenuItem.Name = "throwUnhandledExToolStripMenuItem";
            this.throwUnhandledExToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.throwUnhandledExToolStripMenuItem.Text = "Throw unhandled ex";
            this.throwUnhandledExToolStripMenuItem.Click += new System.EventHandler(this.throwUnhandledExToolStripMenuItem_Click);
            // 
            // threadUnhandledExToolStripMenuItem
            // 
            this.threadUnhandledExToolStripMenuItem.Name = "threadUnhandledExToolStripMenuItem";
            this.threadUnhandledExToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.threadUnhandledExToolStripMenuItem.Text = "Thread unhandled ex";
            this.threadUnhandledExToolStripMenuItem.Click += new System.EventHandler(this.threadUnhandledExToolStripMenuItem_Click);
            // 
            // taskCombinatorsToolStripMenuItem
            // 
            this.taskCombinatorsToolStripMenuItem.Name = "taskCombinatorsToolStripMenuItem";
            this.taskCombinatorsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.taskCombinatorsToolStripMenuItem.Text = "Task combinators";
            this.taskCombinatorsToolStripMenuItem.Click += new System.EventHandler(this.taskCombinatorsToolStripMenuItem_Click);
            // 
            // synchronizationToolStripMenuItem
            // 
            this.synchronizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monitorToolStripMenuItem,
            this.semaphoreToolStripMenuItem,
            this.readWriterLockToolStripMenuItem});
            this.synchronizationToolStripMenuItem.Name = "synchronizationToolStripMenuItem";
            this.synchronizationToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.synchronizationToolStripMenuItem.Text = "Synchronization";
            // 
            // monitorToolStripMenuItem
            // 
            this.monitorToolStripMenuItem.Name = "monitorToolStripMenuItem";
            this.monitorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monitorToolStripMenuItem.Text = "Monitor";
            this.monitorToolStripMenuItem.Click += new System.EventHandler(this.monitorToolStripMenuItem_Click);
            // 
            // semaphoreToolStripMenuItem
            // 
            this.semaphoreToolStripMenuItem.Name = "semaphoreToolStripMenuItem";
            this.semaphoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.semaphoreToolStripMenuItem.Text = "Semaphore";
            this.semaphoreToolStripMenuItem.Click += new System.EventHandler(this.semaphoreToolStripMenuItem_Click);
            // 
            // readWriterLockToolStripMenuItem
            // 
            this.readWriterLockToolStripMenuItem.Name = "readWriterLockToolStripMenuItem";
            this.readWriterLockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readWriterLockToolStripMenuItem.Text = "ReadWriterLock";
            this.readWriterLockToolStripMenuItem.Click += new System.EventHandler(this.readWriterLockToolStripMenuItem_Click);
            // 
            // signalToolStripMenuItem
            // 
            this.signalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualResetEventToolStripMenuItem,
            this.autoResetEventToolStripMenuItem});
            this.signalToolStripMenuItem.Name = "signalToolStripMenuItem";
            this.signalToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.signalToolStripMenuItem.Text = "Signal";
            // 
            // manualResetEventToolStripMenuItem
            // 
            this.manualResetEventToolStripMenuItem.Name = "manualResetEventToolStripMenuItem";
            this.manualResetEventToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualResetEventToolStripMenuItem.Text = "ManualResetEvent";
            this.manualResetEventToolStripMenuItem.Click += new System.EventHandler(this.manualResetEventToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(10, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(780, 406);
            this.textBox1.TabIndex = 2;
            // 
            // autoResetEventToolStripMenuItem
            // 
            this.autoResetEventToolStripMenuItem.Name = "autoResetEventToolStripMenuItem";
            this.autoResetEventToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoResetEventToolStripMenuItem.Text = "AutoResetEvent";
            this.autoResetEventToolStripMenuItem.Click += new System.EventHandler(this.autoResetEventToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem primeNumbersCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primeNumbersTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem throwUnhandledExToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threadUnhandledExToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskCombinatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synchronizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semaphoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readWriterLockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualResetEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoResetEventToolStripMenuItem;
    }
}

