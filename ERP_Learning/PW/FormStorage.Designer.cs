namespace ERP_Learning.PW
{
    partial class FormStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStorage));
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
            this.groupStorageOrder = new System.Windows.Forms.GroupBox();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.cbxVendor = new System.Windows.Forms.ComboBox();
            this.cbxMaterial = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxAudit = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtWarrant = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWarrantID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPurchaseDetail = new System.Windows.Forms.GroupBox();
            this.dgvPO = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.入库单编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.订单编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.订单日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物料 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.供应商 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作员 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.是否审核 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupStorageOrder.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSave
            // 
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(52, 22);
            this.toolSave.Text = "保存";
            // 
            // toolCancel
            // 
            this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(52, 22);
            this.toolCancel.Text = "取消";
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(52, 22);
            this.toolAdd.Tag = "";
            this.toolAdd.Text = "添加";
            // 
            // toolModify
            // 
            this.toolModify.Image = ((System.Drawing.Image)(resources.GetObject("toolModify.Image")));
            this.toolModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolModify.Name = "toolModify";
            this.toolModify.Size = new System.Drawing.Size(52, 22);
            this.toolModify.Text = "修改";
            // 
            // toolDelete
            // 
            this.toolDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolDelete.Image")));
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(52, 22);
            this.toolDelete.Text = "删除";
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
            // 
            // toolrefresh
            // 
            this.toolrefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolrefresh.Image")));
            this.toolrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolrefresh.Name = "toolrefresh";
            this.toolrefresh.Size = new System.Drawing.Size(52, 22);
            this.toolrefresh.Text = "刷新";
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
            // 
            // groupStorageOrder
            // 
            this.groupStorageOrder.Controls.Add(this.cbxEmployee);
            this.groupStorageOrder.Controls.Add(this.cbxVendor);
            this.groupStorageOrder.Controls.Add(this.cbxMaterial);
            this.groupStorageOrder.Controls.Add(this.label9);
            this.groupStorageOrder.Controls.Add(this.label7);
            this.groupStorageOrder.Controls.Add(this.label6);
            this.groupStorageOrder.Controls.Add(this.label5);
            this.groupStorageOrder.Controls.Add(this.label4);
            this.groupStorageOrder.Controls.Add(this.cbxAudit);
            this.groupStorageOrder.Controls.Add(this.txtQuantity);
            this.groupStorageOrder.Controls.Add(this.txtPrice);
            this.groupStorageOrder.Controls.Add(this.label3);
            this.groupStorageOrder.Controls.Add(this.dtWarrant);
            this.groupStorageOrder.Controls.Add(this.label2);
            this.groupStorageOrder.Controls.Add(this.txtOrderID);
            this.groupStorageOrder.Controls.Add(this.txtWarrantID);
            this.groupStorageOrder.Controls.Add(this.label8);
            this.groupStorageOrder.Controls.Add(this.label1);
            this.groupStorageOrder.Location = new System.Drawing.Point(0, 60);
            this.groupStorageOrder.Name = "groupStorageOrder";
            this.groupStorageOrder.Size = new System.Drawing.Size(950, 227);
            this.groupStorageOrder.TabIndex = 5;
            this.groupStorageOrder.TabStop = false;
            this.groupStorageOrder.Text = "采购入库单";
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(315, 167);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(100, 21);
            this.cbxEmployee.TabIndex = 7;
            // 
            // cbxVendor
            // 
            this.cbxVendor.FormattingEnabled = true;
            this.cbxVendor.Location = new System.Drawing.Point(315, 97);
            this.cbxVendor.Name = "cbxVendor";
            this.cbxVendor.Size = new System.Drawing.Size(100, 21);
            this.cbxVendor.TabIndex = 5;
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.Location = new System.Drawing.Point(68, 97);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(100, 21);
            this.cbxMaterial.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "是否审核";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "操作员";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "供应商";
            // 
            // cbxAudit
            // 
            this.cbxAudit.FormattingEnabled = true;
            this.cbxAudit.Location = new System.Drawing.Point(605, 164);
            this.cbxAudit.Name = "cbxAudit";
            this.cbxAudit.Size = new System.Drawing.Size(100, 21);
            this.cbxAudit.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(605, 87);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "物    料";
            // 
            // dtWarrant
            // 
            this.dtWarrant.Location = new System.Drawing.Point(605, 37);
            this.dtWarrant.Name = "dtWarrant";
            this.dtWarrant.Size = new System.Drawing.Size(137, 20);
            this.dtWarrant.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "入库日期";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtWarrantID
            // 
            this.txtWarrantID.Location = new System.Drawing.Point(71, 37);
            this.txtWarrantID.Name = "txtWarrantID";
            this.txtWarrantID.Size = new System.Drawing.Size(100, 20);
            this.txtWarrantID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "入库单编号";
            // 
            // groupPurchaseDetail
            // 
            this.groupPurchaseDetail.Controls.Add(this.dgvPO);
            this.groupPurchaseDetail.Location = new System.Drawing.Point(0, 311);
            this.groupPurchaseDetail.Name = "groupPurchaseDetail";
            this.groupPurchaseDetail.Size = new System.Drawing.Size(962, 239);
            this.groupPurchaseDetail.TabIndex = 6;
            this.groupPurchaseDetail.TabStop = false;
            this.groupPurchaseDetail.Text = "采购订单列表";
            // 
            // dgvPO
            // 
            this.dgvPO.AllowUserToAddRows = false;
            this.dgvPO.AllowUserToDeleteRows = false;
            this.dgvPO.CausesValidation = false;
            this.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.入库单编号,
            this.订单编号,
            this.订单日期,
            this.物料,
            this.供应商,
            this.数量,
            this.单价,
            this.操作员,
            this.是否审核});
            this.dgvPO.Location = new System.Drawing.Point(3, 16);
            this.dgvPO.Name = "dgvPO";
            this.dgvPO.ReadOnly = true;
            this.dgvPO.Size = new System.Drawing.Size(947, 173);
            this.dgvPO.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "订单编号";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(315, 37);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(71, 167);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "单     价";
            // 
            // 入库单编号
            // 
            this.入库单编号.Frozen = true;
            this.入库单编号.HeaderText = "入库单编号";
            this.入库单编号.Name = "入库单编号";
            this.入库单编号.ReadOnly = true;
            // 
            // 订单编号
            // 
            this.订单编号.DataPropertyName = "PurchaseOrderID";
            this.订单编号.Frozen = true;
            this.订单编号.HeaderText = "订单编号";
            this.订单编号.Name = "订单编号";
            this.订单编号.ReadOnly = true;
            // 
            // 订单日期
            // 
            this.订单日期.DataPropertyName = "CreateDate";
            this.订单日期.HeaderText = "入库日期";
            this.订单日期.Name = "订单日期";
            this.订单日期.ReadOnly = true;
            // 
            // 物料
            // 
            this.物料.DataPropertyName = "MaterialName";
            this.物料.HeaderText = "物料";
            this.物料.Name = "物料";
            this.物料.ReadOnly = true;
            // 
            // 供应商
            // 
            this.供应商.DataPropertyName = "VendorName";
            this.供应商.HeaderText = "供应商";
            this.供应商.Name = "供应商";
            this.供应商.ReadOnly = true;
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "Quantity";
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.ReadOnly = true;
            // 
            // 单价
            // 
            this.单价.DataPropertyName = "UnitPrice";
            this.单价.HeaderText = "单价";
            this.单价.Name = "单价";
            this.单价.ReadOnly = true;
            // 
            // 操作员
            // 
            this.操作员.DataPropertyName = "EmployeeName";
            this.操作员.HeaderText = "操作员";
            this.操作员.Name = "操作员";
            this.操作员.ReadOnly = true;
            this.操作员.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.操作员.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 是否审核
            // 
            this.是否审核.DataPropertyName = "IsAudit";
            this.是否审核.HeaderText = "是否审核";
            this.是否审核.Items.AddRange(new object[] {
            "audit"});
            this.是否审核.Name = "是否审核";
            this.是否审核.ReadOnly = true;
            // 
            // FormStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 578);
            this.Controls.Add(this.groupPurchaseDetail);
            this.Controls.Add(this.groupStorageOrder);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormStorage";
            this.Text = "FormStorage";
            this.Load += new System.EventHandler(this.FormStorage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupStorageOrder.ResumeLayout(false);
            this.groupStorageOrder.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupStorageOrder;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.ComboBox cbxVendor;
        private System.Windows.Forms.ComboBox cbxMaterial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxAudit;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtWarrant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWarrantID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupPurchaseDetail;
        private System.Windows.Forms.DataGridView dgvPO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入库单编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单日期;
        private System.Windows.Forms.DataGridViewComboBoxColumn 物料;
        private System.Windows.Forms.DataGridViewComboBoxColumn 供应商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价;
        private System.Windows.Forms.DataGridViewComboBoxColumn 操作员;
        private System.Windows.Forms.DataGridViewComboBoxColumn 是否审核;
    }
}