namespace ERP_Learning
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFormPurchase = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.人力资源管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工基本信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购入库单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售出库单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售收款单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HRGroup = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.PurchaseGroup = new System.Windows.Forms.GroupBox();
            this.buttonFormStorage = new System.Windows.Forms.Button();
            this.SaleGroup = new System.Windows.Forms.GroupBox();
            this.buttonFormSalesOrder = new System.Windows.Forms.Button();
            this.buttonFormSalesOutbound = new System.Windows.Forms.Button();
            this.buttonFormSalesCollection = new System.Windows.Forms.Button();
            this.buttonFormCustomer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.HRGroup.SuspendLayout();
            this.PurchaseGroup.SuspendLayout();
            this.SaleGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "员工档案管理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFormPurchase
            // 
            this.buttonFormPurchase.Location = new System.Drawing.Point(52, 44);
            this.buttonFormPurchase.Name = "buttonFormPurchase";
            this.buttonFormPurchase.Size = new System.Drawing.Size(245, 38);
            this.buttonFormPurchase.TabIndex = 1;
            this.buttonFormPurchase.Text = "采购订单管理";
            this.buttonFormPurchase.UseVisualStyleBackColor = true;
            this.buttonFormPurchase.Click += new System.EventHandler(this.buttonFormPurchase_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人力资源管理ToolStripMenuItem,
            this.采购管理ToolStripMenuItem,
            this.销售管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 人力资源管理ToolStripMenuItem
            // 
            this.人力资源管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.部门管理ToolStripMenuItem,
            this.员工基本信息管理ToolStripMenuItem});
            this.人力资源管理ToolStripMenuItem.Name = "人力资源管理ToolStripMenuItem";
            this.人力资源管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.人力资源管理ToolStripMenuItem.Text = "人力资源管理";
            // 
            // 部门管理ToolStripMenuItem
            // 
            this.部门管理ToolStripMenuItem.Name = "部门管理ToolStripMenuItem";
            this.部门管理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.部门管理ToolStripMenuItem.Text = "部门信息";
            this.部门管理ToolStripMenuItem.Click += new System.EventHandler(this.部门管理ToolStripMenuItem_Click);
            // 
            // 员工基本信息管理ToolStripMenuItem
            // 
            this.员工基本信息管理ToolStripMenuItem.Name = "员工基本信息管理ToolStripMenuItem";
            this.员工基本信息管理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.员工基本信息管理ToolStripMenuItem.Tag = "FormEmployee";
            this.员工基本信息管理ToolStripMenuItem.Text = "员工基本信息";
            this.员工基本信息管理ToolStripMenuItem.Click += new System.EventHandler(this.员工基本信息管理ToolStripMenuItem_Click);
            // 
            // 采购管理ToolStripMenuItem
            // 
            this.采购管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.采购订单ToolStripMenuItem,
            this.采购入库单ToolStripMenuItem});
            this.采购管理ToolStripMenuItem.Name = "采购管理ToolStripMenuItem";
            this.采购管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.采购管理ToolStripMenuItem.Text = "采购管理";
            // 
            // 采购订单ToolStripMenuItem
            // 
            this.采购订单ToolStripMenuItem.Name = "采购订单ToolStripMenuItem";
            this.采购订单ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.采购订单ToolStripMenuItem.Text = "采购订单";
            this.采购订单ToolStripMenuItem.Click += new System.EventHandler(this.采购订单ToolStripMenuItem_Click);
            // 
            // 采购入库单ToolStripMenuItem
            // 
            this.采购入库单ToolStripMenuItem.Name = "采购入库单ToolStripMenuItem";
            this.采购入库单ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.采购入库单ToolStripMenuItem.Text = "采购入库单";
            // 
            // 销售管理ToolStripMenuItem
            // 
            this.销售管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售订单ToolStripMenuItem,
            this.销售出库单ToolStripMenuItem,
            this.销售收款单ToolStripMenuItem,
            this.客户管理ToolStripMenuItem});
            this.销售管理ToolStripMenuItem.Name = "销售管理ToolStripMenuItem";
            this.销售管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.销售管理ToolStripMenuItem.Text = "销售管理";
            // 
            // 销售订单ToolStripMenuItem
            // 
            this.销售订单ToolStripMenuItem.Name = "销售订单ToolStripMenuItem";
            this.销售订单ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.销售订单ToolStripMenuItem.Text = "销售订单";
            // 
            // 销售出库单ToolStripMenuItem
            // 
            this.销售出库单ToolStripMenuItem.Name = "销售出库单ToolStripMenuItem";
            this.销售出库单ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.销售出库单ToolStripMenuItem.Text = "销售出库单";
            // 
            // 销售收款单ToolStripMenuItem
            // 
            this.销售收款单ToolStripMenuItem.Name = "销售收款单ToolStripMenuItem";
            this.销售收款单ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.销售收款单ToolStripMenuItem.Text = "销售收款单";
            // 
            // 客户管理ToolStripMenuItem
            // 
            this.客户管理ToolStripMenuItem.Name = "客户管理ToolStripMenuItem";
            this.客户管理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.客户管理ToolStripMenuItem.Text = "客户管理";
            // 
            // HRGroup
            // 
            this.HRGroup.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HRGroup.Controls.Add(this.button3);
            this.HRGroup.Controls.Add(this.button1);
            this.HRGroup.Location = new System.Drawing.Point(12, 39);
            this.HRGroup.Name = "HRGroup";
            this.HRGroup.Size = new System.Drawing.Size(353, 236);
            this.HRGroup.TabIndex = 3;
            this.HRGroup.TabStop = false;
            this.HRGroup.Text = "人力资源管理";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 38);
            this.button3.TabIndex = 0;
            this.button3.Text = "部门管理";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonFormDept_Click);
            // 
            // PurchaseGroup
            // 
            this.PurchaseGroup.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PurchaseGroup.Controls.Add(this.buttonFormStorage);
            this.PurchaseGroup.Controls.Add(this.buttonFormPurchase);
            this.PurchaseGroup.Location = new System.Drawing.Point(12, 327);
            this.PurchaseGroup.Name = "PurchaseGroup";
            this.PurchaseGroup.Size = new System.Drawing.Size(353, 277);
            this.PurchaseGroup.TabIndex = 4;
            this.PurchaseGroup.TabStop = false;
            this.PurchaseGroup.Text = "采购管理";
            // 
            // buttonFormStorage
            // 
            this.buttonFormStorage.Location = new System.Drawing.Point(52, 156);
            this.buttonFormStorage.Name = "buttonFormStorage";
            this.buttonFormStorage.Size = new System.Drawing.Size(245, 38);
            this.buttonFormStorage.TabIndex = 1;
            this.buttonFormStorage.Text = "采购入库单管理";
            this.buttonFormStorage.UseVisualStyleBackColor = true;
            this.buttonFormStorage.Click += new System.EventHandler(this.buttonFormStorage_Click);
            // 
            // SaleGroup
            // 
            this.SaleGroup.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SaleGroup.Controls.Add(this.buttonFormSalesOrder);
            this.SaleGroup.Controls.Add(this.buttonFormSalesOutbound);
            this.SaleGroup.Controls.Add(this.buttonFormSalesCollection);
            this.SaleGroup.Controls.Add(this.buttonFormCustomer);
            this.SaleGroup.Location = new System.Drawing.Point(513, 39);
            this.SaleGroup.Name = "SaleGroup";
            this.SaleGroup.Size = new System.Drawing.Size(344, 565);
            this.SaleGroup.TabIndex = 5;
            this.SaleGroup.TabStop = false;
            this.SaleGroup.Text = "销售管理";
            // 
            // buttonFormSalesOrder
            // 
            this.buttonFormSalesOrder.Location = new System.Drawing.Point(50, 151);
            this.buttonFormSalesOrder.Name = "buttonFormSalesOrder";
            this.buttonFormSalesOrder.Size = new System.Drawing.Size(245, 38);
            this.buttonFormSalesOrder.TabIndex = 4;
            this.buttonFormSalesOrder.Text = "销售订单管理";
            this.buttonFormSalesOrder.UseVisualStyleBackColor = true;
            this.buttonFormSalesOrder.Click += new System.EventHandler(this.buttonFormSalesOrder_Click);
            // 
            // buttonFormSalesOutbound
            // 
            this.buttonFormSalesOutbound.Location = new System.Drawing.Point(50, 332);
            this.buttonFormSalesOutbound.Name = "buttonFormSalesOutbound";
            this.buttonFormSalesOutbound.Size = new System.Drawing.Size(245, 38);
            this.buttonFormSalesOutbound.TabIndex = 3;
            this.buttonFormSalesOutbound.Text = "销售出库单管理";
            this.buttonFormSalesOutbound.UseVisualStyleBackColor = true;
            this.buttonFormSalesOutbound.Click += new System.EventHandler(this.buttonFormSalesOutbound_Click);
            // 
            // buttonFormSalesCollection
            // 
            this.buttonFormSalesCollection.Location = new System.Drawing.Point(50, 444);
            this.buttonFormSalesCollection.Name = "buttonFormSalesCollection";
            this.buttonFormSalesCollection.Size = new System.Drawing.Size(245, 38);
            this.buttonFormSalesCollection.TabIndex = 2;
            this.buttonFormSalesCollection.Text = "销售收款单管理";
            this.buttonFormSalesCollection.UseVisualStyleBackColor = true;
            this.buttonFormSalesCollection.Click += new System.EventHandler(this.buttonFormSalesCollection_Click);
            // 
            // buttonFormCustomer
            // 
            this.buttonFormCustomer.Location = new System.Drawing.Point(50, 63);
            this.buttonFormCustomer.Name = "buttonFormCustomer";
            this.buttonFormCustomer.Size = new System.Drawing.Size(245, 38);
            this.buttonFormCustomer.TabIndex = 1;
            this.buttonFormCustomer.Text = "客户管理";
            this.buttonFormCustomer.UseVisualStyleBackColor = true;
            this.buttonFormCustomer.Click += new System.EventHandler(this.buttonFormCustomer_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 631);
            this.Controls.Add(this.SaleGroup);
            this.Controls.Add(this.PurchaseGroup);
            this.Controls.Add(this.HRGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.HRGroup.ResumeLayout(false);
            this.PurchaseGroup.ResumeLayout(false);
            this.SaleGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonFormPurchase;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 人力资源管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工基本信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购入库单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售出库单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售收款单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户管理ToolStripMenuItem;
        private System.Windows.Forms.GroupBox HRGroup;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox PurchaseGroup;
        private System.Windows.Forms.Button buttonFormStorage;
        private System.Windows.Forms.GroupBox SaleGroup;
        private System.Windows.Forms.Button buttonFormSalesOrder;
        private System.Windows.Forms.Button buttonFormSalesOutbound;
        private System.Windows.Forms.Button buttonFormSalesCollection;
        private System.Windows.Forms.Button buttonFormCustomer;
    }
}