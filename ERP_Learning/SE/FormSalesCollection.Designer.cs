namespace ERP_Learning.SE
{
    partial class FormSalesCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesCollection));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolModify = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxCondition = new System.Windows.Forms.ToolStripComboBox();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolSearch = new System.Windows.Forms.ToolStripButton();
            this.toolrefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.groupPurchaseOrder = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCollectedAmount = new System.Windows.Forms.TextBox();
            this.dtSalesOut = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalesOutID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPurchaseDetail = new System.Windows.Forms.GroupBox();
            this.dgvPO = new System.Windows.Forms.DataGridView();
            this.收款单编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收款单日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.订单编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.订单日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.客户 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.收款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.订单总额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupPurchaseOrder.SuspendLayout();
            this.groupPurchaseDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPO)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolCancel,
            this.toolAdd,
            this.toolModify,
            this.toolDelete,
            this.toolStripLabel1,
            this.cbxCondition,
            this.txtSearch,
            this.toolSearch,
            this.toolrefresh,
            this.toolStripSeparator1,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSave
            // 
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(52, 22);
            this.toolSave.Text = "保存";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(52, 22);
            this.toolCancel.Text = "取消";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(52, 22);
            this.toolAdd.Tag = "";
            this.toolAdd.Text = "添加";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolModify
            // 
            this.toolModify.Image = ((System.Drawing.Image)(resources.GetObject("toolModify.Image")));
            this.toolModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolModify.Name = "toolModify";
            this.toolModify.Size = new System.Drawing.Size(52, 22);
            this.toolModify.Text = "修改";
            this.toolModify.Click += new System.EventHandler(this.toolModify_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolDelete.Image")));
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(52, 22);
            this.toolDelete.Text = "删除";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "查询条件：";
            // 
            // cbxCondition
            // 
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Size = new System.Drawing.Size(121, 25);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // toolSearch
            // 
            this.toolSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolSearch.Image")));
            this.toolSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSearch.Name = "toolSearch";
            this.toolSearch.Size = new System.Drawing.Size(52, 22);
            this.toolSearch.Text = "查找";
            this.toolSearch.Click += new System.EventHandler(this.toolSearch_Click);
            // 
            // toolrefresh
            // 
            this.toolrefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolrefresh.Image")));
            this.toolrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolrefresh.Name = "toolrefresh";
            this.toolrefresh.Size = new System.Drawing.Size(52, 22);
            this.toolrefresh.Text = "刷新";
            this.toolrefresh.Click += new System.EventHandler(this.toolrefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(52, 22);
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // groupPurchaseOrder
            // 
            this.groupPurchaseOrder.Controls.Add(this.label5);
            this.groupPurchaseOrder.Controls.Add(this.txtCollectedAmount);
            this.groupPurchaseOrder.Controls.Add(this.dtSalesOut);
            this.groupPurchaseOrder.Controls.Add(this.label10);
            this.groupPurchaseOrder.Controls.Add(this.txtSalesOutID);
            this.groupPurchaseOrder.Controls.Add(this.label11);
            this.groupPurchaseOrder.Controls.Add(this.cbxCustomer);
            this.groupPurchaseOrder.Controls.Add(this.cbxProduct);
            this.groupPurchaseOrder.Controls.Add(this.label6);
            this.groupPurchaseOrder.Controls.Add(this.label4);
            this.groupPurchaseOrder.Controls.Add(this.txtTotalAmount);
            this.groupPurchaseOrder.Controls.Add(this.label3);
            this.groupPurchaseOrder.Controls.Add(this.dtOrder);
            this.groupPurchaseOrder.Controls.Add(this.label2);
            this.groupPurchaseOrder.Controls.Add(this.txtOrderID);
            this.groupPurchaseOrder.Controls.Add(this.label1);
            this.groupPurchaseOrder.Location = new System.Drawing.Point(12, 57);
            this.groupPurchaseOrder.Name = "groupPurchaseOrder";
            this.groupPurchaseOrder.Size = new System.Drawing.Size(788, 227);
            this.groupPurchaseOrder.TabIndex = 10;
            this.groupPurchaseOrder.TabStop = false;
            this.groupPurchaseOrder.Text = "销售收款单";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "收款金额";
            // 
            // txtCollectedAmount
            // 
            this.txtCollectedAmount.Location = new System.Drawing.Point(328, 145);
            this.txtCollectedAmount.Name = "txtCollectedAmount";
            this.txtCollectedAmount.Size = new System.Drawing.Size(137, 20);
            this.txtCollectedAmount.TabIndex = 22;
            // 
            // dtSalesOut
            // 
            this.dtSalesOut.Location = new System.Drawing.Point(328, 38);
            this.dtSalesOut.Name = "dtSalesOut";
            this.dtSalesOut.Size = new System.Drawing.Size(137, 20);
            this.dtSalesOut.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "收款单日期";
            // 
            // txtSalesOutID
            // 
            this.txtSalesOutID.Location = new System.Drawing.Point(78, 38);
            this.txtSalesOutID.Name = "txtSalesOutID";
            this.txtSalesOutID.Size = new System.Drawing.Size(100, 20);
            this.txtSalesOutID.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "收款单编号";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(617, 41);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(100, 21);
            this.cbxCustomer.TabIndex = 4;
            // 
            // cbxProduct
            // 
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(617, 82);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(100, 21);
            this.cbxProduct.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "订单总额";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "客户";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(75, 142);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "产品";
            // 
            // dtOrder
            // 
            this.dtOrder.Location = new System.Drawing.Point(328, 82);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(137, 20);
            this.dtOrder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "订单日期";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(75, 82);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单编号";
            // 
            // groupPurchaseDetail
            // 
            this.groupPurchaseDetail.Controls.Add(this.dgvPO);
            this.groupPurchaseDetail.Location = new System.Drawing.Point(12, 300);
            this.groupPurchaseDetail.Name = "groupPurchaseDetail";
            this.groupPurchaseDetail.Size = new System.Drawing.Size(788, 192);
            this.groupPurchaseDetail.TabIndex = 11;
            this.groupPurchaseDetail.TabStop = false;
            this.groupPurchaseDetail.Text = "销售收款单列表";
            // 
            // dgvPO
            // 
            this.dgvPO.AllowUserToAddRows = false;
            this.dgvPO.AllowUserToDeleteRows = false;
            this.dgvPO.CausesValidation = false;
            this.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.收款单编号,
            this.收款单日期,
            this.订单编号,
            this.订单日期,
            this.产品,
            this.客户,
            this.收款金额,
            this.订单总额});
            this.dgvPO.Location = new System.Drawing.Point(3, 16);
            this.dgvPO.Name = "dgvPO";
            this.dgvPO.ReadOnly = true;
            this.dgvPO.Size = new System.Drawing.Size(782, 173);
            this.dgvPO.TabIndex = 0;
            this.dgvPO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPO_CellClick);

            // 
            // 收款单编号
            // 
            this.收款单编号.DataPropertyName = "SalesCollectionid";
            this.收款单编号.HeaderText = "收款单编号";
            this.收款单编号.Name = "收款单编号";
            this.收款单编号.ReadOnly = true;
            // 
            // 收款单日期
            // 
            this.收款单日期.DataPropertyName = "SalesCollectionDate";
            this.收款单日期.HeaderText = "收款单日期";
            this.收款单日期.Name = "收款单日期";
            this.收款单日期.ReadOnly = true;
            // 
            // 订单编号
            // 
            this.订单编号.DataPropertyName = "SalesOrderID";
            this.订单编号.HeaderText = "订单编号";
            this.订单编号.Name = "订单编号";
            this.订单编号.ReadOnly = true;
            // 
            // 订单日期
            // 
            this.订单日期.DataPropertyName = "CreateDate";
            this.订单日期.HeaderText = "订单日期";
            this.订单日期.Name = "订单日期";
            this.订单日期.ReadOnly = true;
            // 
            // 产品
            // 
            this.产品.DataPropertyName = "ProductName";
            this.产品.HeaderText = "产品";
            this.产品.Name = "产品";
            this.产品.ReadOnly = true;
            // 
            // 客户
            // 
            this.客户.DataPropertyName = "CustomerName";
            this.客户.HeaderText = "客户";
            this.客户.Name = "客户";
            this.客户.ReadOnly = true;
            // 
            // 收款金额
            // 
            this.收款金额.DataPropertyName = "CollectedAmount";
            this.收款金额.HeaderText = "收款金额";
            this.收款金额.Name = "收款金额";
            this.收款金额.ReadOnly = true;
            // 
            // 订单总额
            // 
            this.订单总额.DataPropertyName = "TotalAmount";
            this.订单总额.HeaderText = "订单总额";
            this.订单总额.Name = "订单总额";
            this.订单总额.ReadOnly = true;
            // 
            // FormSalesCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 582);
            this.Controls.Add(this.groupPurchaseDetail);
            this.Controls.Add(this.groupPurchaseOrder);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormSalesCollection";
            this.Text = "FormSalesCollection";
            this.Load += new System.EventHandler(this.FormSalesCollection_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupPurchaseOrder.ResumeLayout(false);
            this.groupPurchaseOrder.PerformLayout();
            this.groupPurchaseDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolModify;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbxCondition;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton toolSearch;
        private System.Windows.Forms.ToolStripButton toolrefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.GroupBox groupPurchaseOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCollectedAmount;
        private System.Windows.Forms.DateTimePicker dtSalesOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalesOutID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupPurchaseDetail;
        private System.Windows.Forms.DataGridView dgvPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收款单编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收款单日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单日期;
        private System.Windows.Forms.DataGridViewComboBoxColumn 产品;
        private System.Windows.Forms.DataGridViewComboBoxColumn 客户;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收款金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单总额;
    }
}