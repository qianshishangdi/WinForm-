using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace ToolStrip
{
    public partial class Form1 : Form
    {
        private DispatcherTimer timer;
        private CultureInfo providers;
        public Form1()
        {
            this.providers = new CultureInfo("en-us");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("");
            InitializeComponent();
            CreateTimer();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void update_progressbar()
        { 
        }
        private void CreateTimer()
        {
            this.timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromMilliseconds(300),
            };
            this.timer.Tick += dispatcherTimer_Tick;
            this.timer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.toolStripProgressBar1.Value < 100)
                {
                    this.toolStripProgressBar1.PerformStep();
                    this.toolStripTextBox1.Text = this.toolStripProgressBar1.Value.ToString(providers);
                }
                else
                {
                    this.toolStripProgressBar1.PerformStep();
                    this.timer.Stop();
                    this.timer.Tick -= dispatcherTimer_Tick;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
