namespace WindowsFormsApplication1
{
    partial class frmProviderCatalog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.usrCtrlProviderWordOp4 = new WindowsFormsApplication1.usrCtrlProviderWordOp();
            this.usrCtrlProviderWordOp3 = new WindowsFormsApplication1.usrCtrlProviderWordOp();
            this.usrCtrlProviderWordOp2 = new WindowsFormsApplication1.usrCtrlProviderWordOp();
            this.usrCtrlProviderWordOp1 = new WindowsFormsApplication1.usrCtrlProviderWordOp();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.usrCtrlProviderWordOp4);
            this.panel1.Controls.Add(this.usrCtrlProviderWordOp3);
            this.panel1.Controls.Add(this.usrCtrlProviderWordOp2);
            this.panel1.Controls.Add(this.usrCtrlProviderWordOp1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 625);
            this.panel1.TabIndex = 2;
            // 
            // usrCtrlProviderWordOp4
            // 
            this.usrCtrlProviderWordOp4.Location = new System.Drawing.Point(1, 1307);
            this.usrCtrlProviderWordOp4.Name = "usrCtrlProviderWordOp4";
            this.usrCtrlProviderWordOp4.Size = new System.Drawing.Size(889, 434);
            this.usrCtrlProviderWordOp4.TabIndex = 4;
            this.usrCtrlProviderWordOp4.Type = "label2";
            this.usrCtrlProviderWordOp4.Year = "label1";
            // 
            // usrCtrlProviderWordOp3
            // 
            this.usrCtrlProviderWordOp3.Location = new System.Drawing.Point(3, 877);
            this.usrCtrlProviderWordOp3.Name = "usrCtrlProviderWordOp3";
            this.usrCtrlProviderWordOp3.Size = new System.Drawing.Size(889, 434);
            this.usrCtrlProviderWordOp3.TabIndex = 3;
            this.usrCtrlProviderWordOp3.Type = "label2";
            this.usrCtrlProviderWordOp3.Year = "label1";
            // 
            // usrCtrlProviderWordOp2
            // 
            this.usrCtrlProviderWordOp2.Location = new System.Drawing.Point(3, 447);
            this.usrCtrlProviderWordOp2.Name = "usrCtrlProviderWordOp2";
            this.usrCtrlProviderWordOp2.Size = new System.Drawing.Size(889, 434);
            this.usrCtrlProviderWordOp2.TabIndex = 2;
            this.usrCtrlProviderWordOp2.Type = "label2";
            this.usrCtrlProviderWordOp2.Year = "label1";
            // 
            // usrCtrlProviderWordOp1
            // 
            this.usrCtrlProviderWordOp1.Location = new System.Drawing.Point(3, 7);
            this.usrCtrlProviderWordOp1.Name = "usrCtrlProviderWordOp1";
            this.usrCtrlProviderWordOp1.Size = new System.Drawing.Size(898, 434);
            this.usrCtrlProviderWordOp1.TabIndex = 0;
            this.usrCtrlProviderWordOp1.Type = "label2";
            this.usrCtrlProviderWordOp1.Year = "label1";
            // 
            // ProviderCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 625);
            this.Controls.Add(this.panel1);
            this.Name = "ProviderCatalog";
            this.Text = "合格供方目录";
            this.Load += new System.EventHandler(this.ProviderCatalog_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private usrCtrlProviderWordOp usrCtrlProviderWordOp1;
        private System.Windows.Forms.Panel panel1;
        private usrCtrlProviderWordOp usrCtrlProviderWordOp2;
        private usrCtrlProviderWordOp usrCtrlProviderWordOp3;
        private usrCtrlProviderWordOp usrCtrlProviderWordOp4;
    }
}

