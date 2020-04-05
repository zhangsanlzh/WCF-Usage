namespace WindowsFormsApplication1
{
    partial class frmRegistration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinglePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyCountUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPriceUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportanceLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 531);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.ContractID,
            this.CompanyName,
            this.GoodsName,
            this.Specifications,
            this.SinglePrice,
            this.PriceUnit,
            this.BuyCount,
            this.BuyCountUnit,
            this.TotalPrice,
            this.TotalPriceUnit,
            this.BuyType,
            this.ImportanceLevel,
            this.Auditor,
            this.Reason,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(773, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "签订日期";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ContractID
            // 
            this.ContractID.DataPropertyName = "ContractID";
            this.ContractID.HeaderText = "合同编号";
            this.ContractID.Name = "ContractID";
            this.ContractID.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "单位名称";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // GoodsName
            // 
            this.GoodsName.DataPropertyName = "GoodsName";
            this.GoodsName.HeaderText = "采购内容";
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.ReadOnly = true;
            // 
            // Specifications
            // 
            this.Specifications.DataPropertyName = "Specifications";
            this.Specifications.HeaderText = "规格型号";
            this.Specifications.Name = "Specifications";
            this.Specifications.ReadOnly = true;
            // 
            // SinglePrice
            // 
            this.SinglePrice.DataPropertyName = "SinglePrice";
            this.SinglePrice.HeaderText = "采购单价";
            this.SinglePrice.Name = "SinglePrice";
            this.SinglePrice.ReadOnly = true;
            // 
            // PriceUnit
            // 
            this.PriceUnit.DataPropertyName = "PriceUnit";
            this.PriceUnit.HeaderText = "单价单位";
            this.PriceUnit.Name = "PriceUnit";
            this.PriceUnit.ReadOnly = true;
            // 
            // BuyCount
            // 
            this.BuyCount.DataPropertyName = "BuyCount";
            this.BuyCount.HeaderText = "采购数量";
            this.BuyCount.Name = "BuyCount";
            this.BuyCount.ReadOnly = true;
            // 
            // BuyCountUnit
            // 
            this.BuyCountUnit.DataPropertyName = "BuyCountUnit";
            this.BuyCountUnit.HeaderText = "数量单位";
            this.BuyCountUnit.Name = "BuyCountUnit";
            this.BuyCountUnit.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "发生金额";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // TotalPriceUnit
            // 
            this.TotalPriceUnit.DataPropertyName = "TotalPriceUnit";
            this.TotalPriceUnit.HeaderText = "金额单位";
            this.TotalPriceUnit.Name = "TotalPriceUnit";
            this.TotalPriceUnit.ReadOnly = true;
            // 
            // BuyType
            // 
            this.BuyType.DataPropertyName = "BuyType";
            this.BuyType.HeaderText = "采购类型";
            this.BuyType.Name = "BuyType";
            this.BuyType.ReadOnly = true;
            // 
            // ImportanceLevel
            // 
            this.ImportanceLevel.DataPropertyName = "ImportanceLevel";
            this.ImportanceLevel.HeaderText = "重要程度";
            this.ImportanceLevel.Name = "ImportanceLevel";
            this.ImportanceLevel.ReadOnly = true;
            // 
            // Auditor
            // 
            this.Auditor.DataPropertyName = "Auditor";
            this.Auditor.HeaderText = "外审";
            this.Auditor.Name = "Auditor";
            this.Auditor.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "原因";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "描述";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 531);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegistration";
            this.Text = "frmRegistration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinglePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyCountUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPriceUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportanceLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}