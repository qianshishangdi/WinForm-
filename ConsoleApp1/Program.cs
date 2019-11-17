using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace WinformConsole
{
    class Form1 : Form
    {
        /// <summary>
        /// 变量
        /// </summary>
        private IContainer components = null;
        private ResourceManager resourcemanager = null;
        private ComponentResourceManager componentresourcemanager = null;

#pragma warning disable CA2213 // 应释放可释放的字段
        private BackgroundWorker backgroundWorker1;
        private Button startBtn;
        private Button cancelBtn;
#pragma warning restore CA2213 // 应释放可释放的字段

        /// <summary>
        /// 构造函数
        /// </summary>
        public Form1()
        {
            // 选择UI界面语言-中文
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CN");
            InitializeComponent();
        }
        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="disposing"> 是否进行释放 </param>
        protected override void Dispose(bool disposing)
        {
            
            if (disposing && (this.components != null))
            {
                this.components.Dispose();      // 释放托管成员
            }
            base.Dispose(disposing);            // 释放非托管成员
        }
        /// <summary>
        /// 控件初始化
        /// </summary>
        private void InitializeComponent()
        {   
            this.components = new Container();
            this.resourcemanager = new ResourceManager("BackGroundWorker.Resources.ProgramStrings", Assembly.GetExecutingAssembly());
            this.componentresourcemanager = new ComponentResourceManager(typeof(Form1));

            // 新建变量
            this.backgroundWorker1 = new BackgroundWorker();
            this.startBtn = new Button();
            this.cancelBtn = new Button();
            // 托管新建的变量
            this.components.Add(this.backgroundWorker1);
            this.components.Add(this.startBtn);
            this.components.Add(this.cancelBtn);

            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // startBtn
            // 
            this.componentresourcemanager.ApplyResources(startBtn, "startBtn", CultureInfo.CurrentUICulture);
            this.startBtn.Name = "startBtn";
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // cancelBtn
            // 
            this.componentresourcemanager.ApplyResources(this.cancelBtn, "cancelBtn", CultureInfo.CurrentUICulture);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Form1
            // 
            this.componentresourcemanager.ApplyResources(this, "$this", CultureInfo.CurrentUICulture);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            // Extract the argument.
            int arg = (int)e.Argument;

            // Start the time-consuming operation.
            e.Result = TimeConsumingOperation(bw, arg);

            // If the operation was canceled by the user, 
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        // This event handler demonstrates how to interpret 
        // the outcome of the asynchronous operation implemented
        // in the DoWork event handler.
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                MessageBox.Show(this.resourcemanager.GetString("backworkercancel", CultureInfo.CurrentCulture));
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = this.resourcemanager.GetString("erroroccurred", CultureInfo.CurrentCulture) + string.Format(CultureInfo.CurrentCulture, "{0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
            {
                // The operation completed normally.
                string msg = this.resourcemanager.GetString("backworkerresult", CultureInfo.CurrentCulture) + string.Format(CultureInfo.CurrentCulture, "{0}", e.Result);
                MessageBox.Show(msg);
            }
        }
        // This method models an operation that may take a long time 
        // to run. It can be cancelled, it can raise an exception,
        // or it can exit normally and return a result. These outcomes
        // are chosen randomly.
        private int TimeConsumingOperation(BackgroundWorker bw, int sleepPeriod)
        {
            var result = 0;

            Random rand = new Random();

            while (!bw.CancellationPending)
            {
                bool exit = false;

                var rand_value = rand.Next(3);
                Console.WriteLine(rand_value);
                switch (rand_value)
                {
                    // Raise an exception.
                    case 0:
                        {
                            throw new Exception(this.resourcemanager.GetString("backworkererrormsg", CultureInfo.CurrentCulture));
                        }

                    // Sleep for the number of milliseconds
                    // specified by the sleepPeriod parameter.
                    case 1:
                        {
                            Thread.Sleep(sleepPeriod);
                            break;
                        }

                    // Exit and return normally.
                    case 2:
                        {
                            result = rand_value;
                            exit = true;
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

                if (exit)
                {
                    break;
                }
            }

            return result;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.RunWorkerAsync(2000);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.CancelAsync();
        }
        /// <summary>
        /// 创建系统定时器
        /// </summary>
        private void CreateTimer()
        {
            DispatcherTimer timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromMilliseconds(1000),
            };
        }

    }

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (Form1 myform = new Form1())
            {
                Application.Run(myform);
            }
        }
    }
}