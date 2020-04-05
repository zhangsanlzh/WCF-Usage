namespace WindowsFormsApplication1
{
    partial class usrCtrlProviderWordOp
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TotalOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhyUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalOrder,
            this.SecondOrder,
            this.Date,
            this.CompanyName,
            this.Scope,
            this.WhyUse,
            this.LinkMan,
            this.PhoneNum,
            this.Address});
            this.dataGridView1.Location = new System.Drawing.Point(13, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(865, 393);
            this.dataGridView1.TabIndex = 7;
            // 
            // TotalOrder
            // 
            this.TotalOrder.DataPropertyName = "TotalOrder";
            this.TotalOrder.HeaderText = "总序";
            this.TotalOrder.Name = "TotalOrder";
            this.TotalOrder.ReadOnly = true;
            this.TotalOrder.Width = 60;
            // 
            // SecondOrder
            // 
            this.SecondOrder.DataPropertyName = "SecondOrder";
            this.SecondOrder.HeaderText = "分序";
            this.SecondOrder.Name = "SecondOrder";
            this.SecondOrder.ReadOnly = true;
            this.SecondOrder.Width = 60;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "评定日期";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "公司名称";
            this.CompanyName.Name = "CompanyName";
            // 
            // Scope
            // 
            this.Scope.DataPropertyName = "Scope";
            this.Scope.HeaderText = "经营范围";
            this.Scope.Name = "Scope";
            // 
            // WhyUse
            // 
            this.WhyUse.DataPropertyName = "WhyUse";
            this.WhyUse.HeaderText = "合作内容";
            this.WhyUse.Name = "WhyUse";
            // 
            // LinkMan
            // 
            this.LinkMan.DataPropertyName = "LinkMan";
            this.LinkMan.HeaderText = "联系人";
            this.LinkMan.Name = "LinkMan";
            // 
            // PhoneNum
            // 
            this.PhoneNum.DataPropertyName = "PhoneNum";
            this.PhoneNum.HeaderText = "联系电话";
            this.PhoneNum.Name = "PhoneNum";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "单位地址";
            this.Address.Name = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // usrCtrlProviderWordOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "usrCtrlProviderWordOp";
            this.Size = new System.Drawing.Size(889, 434);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scope;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhyUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
