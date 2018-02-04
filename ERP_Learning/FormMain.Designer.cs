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
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.人力资源管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工基本信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购入库单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客服分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售出库单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售收款单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.财务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购费用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售费用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "员工档案管理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "采购订单管理";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人力资源管理ToolStripMenuItem,
            this.采购管理ToolStripMenuItem,
            this.客户管理ToolStripMenuItem,
            this.销售管理ToolStripMenuItem,
            this.财务管理ToolStripMenuItem});
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
            this.采购订单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.采购订单ToolStripMenuItem.Text = "采购订单";
            this.采购订单ToolStripMenuItem.Click += new System.EventHandler(this.采购订单ToolStripMenuItem_Click);
            // 
            // 采购入库单ToolStripMenuItem
            // 
            this.采购入库单ToolStripMenuItem.Name = "采购入库单ToolStripMenuItem";
            this.采购入库单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.采购入库单ToolStripMenuItem.Text = "采购入库单";
            // 
            // 客户管理ToolStripMenuItem
            // 
            this.客户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客户信息管理ToolStripMenuItem,
            this.客服分类ToolStripMenuItem});
            this.客户管理ToolStripMenuItem.Name = "客户管理ToolStripMenuItem";
            this.客户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.客户管理ToolStripMenuItem.Text = "客户管理";
            // 
            // 客户信息管理ToolStripMenuItem
            // 
            this.客户信息管理ToolStripMenuItem.Name = "客户信息管理ToolStripMenuItem";
            this.客户信息管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.客户信息管理ToolStripMenuItem.Text = "客户信息";
            // 
            // 客服分类ToolStripMenuItem
            // 
            this.客服分类ToolStripMenuItem.Name = "客服分类ToolStripMenuItem";
            this.客服分类ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.客服分类ToolStripMenuItem.Text = "客服分类";
            // 
            // 销售管理ToolStripMenuItem
            // 
            this.销售管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售订单ToolStripMenuItem,
            this.销售出库单ToolStripMenuItem,
            this.销售收款单ToolStripMenuItem});
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
            // 财务管理ToolStripMenuItem
            // 
            this.财务管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.采购费用ToolStripMenuItem,
            this.销售费用ToolStripMenuItem});
            this.财务管理ToolStripMenuItem.Name = "财务管理ToolStripMenuItem";
            this.财务管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.财务管理ToolStripMenuItem.Text = "财务管理";
            // 
            // 采购费用ToolStripMenuItem
            // 
            this.采购费用ToolStripMenuItem.Name = "采购费用ToolStripMenuItem";
            this.采购费用ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.采购费用ToolStripMenuItem.Text = "采购费用";
            // 
            // 销售费用ToolStripMenuItem
            // 
            this.销售费用ToolStripMenuItem.Name = "销售费用ToolStripMenuItem";
            this.销售费用ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.销售费用ToolStripMenuItem.Text = "销售费用";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 631);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 人力资源管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工基本信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购入库单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客服分类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售出库单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售收款单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 财务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购费用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售费用ToolStripMenuItem;
    }
}