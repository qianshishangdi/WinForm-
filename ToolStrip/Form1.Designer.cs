namespace ToolStrip
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.这是一个分离按钮ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分离按钮分支1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分离按钮分支2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分离按钮选项2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.这是一个下拉按钮ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下拉按钮选项1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下拉按钮选项2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripSplitButton1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripComboBox1,
            this.toolStripTextBox1,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "工具栏按钮";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "工具栏标签";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.这是一个分离按钮ToolStripMenuItem,
            this.分离按钮选项2ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.这是一个下拉按钮ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "项目1",
            "项目2",
            "项目3"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.Text = "文本框";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // 这是一个分离按钮ToolStripMenuItem
            // 
            this.这是一个分离按钮ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.分离按钮分支1ToolStripMenuItem,
            this.分离按钮分支2ToolStripMenuItem});
            this.这是一个分离按钮ToolStripMenuItem.Name = "这是一个分离按钮ToolStripMenuItem";
            this.这是一个分离按钮ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.这是一个分离按钮ToolStripMenuItem.Text = "分离按钮选项1";
            // 
            // 分离按钮分支1ToolStripMenuItem
            // 
            this.分离按钮分支1ToolStripMenuItem.Name = "分离按钮分支1ToolStripMenuItem";
            this.分离按钮分支1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.分离按钮分支1ToolStripMenuItem.Text = "分离按钮分支1";
            // 
            // 分离按钮分支2ToolStripMenuItem
            // 
            this.分离按钮分支2ToolStripMenuItem.Name = "分离按钮分支2ToolStripMenuItem";
            this.分离按钮分支2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.分离按钮分支2ToolStripMenuItem.Text = "分离按钮分支2";
            // 
            // 分离按钮选项2ToolStripMenuItem
            // 
            this.分离按钮选项2ToolStripMenuItem.Name = "分离按钮选项2ToolStripMenuItem";
            this.分离按钮选项2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.分离按钮选项2ToolStripMenuItem.Text = "分离按钮选项2";
            // 
            // 这是一个下拉按钮ToolStripMenuItem
            // 
            this.这是一个下拉按钮ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下拉按钮选项1ToolStripMenuItem,
            this.下拉按钮选项2ToolStripMenuItem});
            this.这是一个下拉按钮ToolStripMenuItem.Name = "这是一个下拉按钮ToolStripMenuItem";
            this.这是一个下拉按钮ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.这是一个下拉按钮ToolStripMenuItem.Text = "这是一个下拉按钮";
            // 
            // 下拉按钮选项1ToolStripMenuItem
            // 
            this.下拉按钮选项1ToolStripMenuItem.Name = "下拉按钮选项1ToolStripMenuItem";
            this.下拉按钮选项1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.下拉按钮选项1ToolStripMenuItem.Text = "下拉按钮选项1";
            // 
            // 下拉按钮选项2ToolStripMenuItem
            // 
            this.下拉按钮选项2ToolStripMenuItem.Name = "下拉按钮选项2ToolStripMenuItem";
            this.下拉按钮选项2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.下拉按钮选项2ToolStripMenuItem.Text = "下拉按钮选项2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem 这是一个分离按钮ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分离按钮分支1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分离按钮分支2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分离按钮选项2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 这是一个下拉按钮ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下拉按钮选项1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下拉按钮选项2ToolStripMenuItem;
    }
}

