using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_Learning.ComClass;
using ERP_Learning.HR;
using ERP_Learning.PW;

namespace ERP_Learning
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormEmployee employee = new FormEmployee();
            employee.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmployee employee = new FormEmployee();
            employee.StartPosition = FormStartPosition.CenterScreen;
            employee.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void 部门管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartment Dept = new FormDepartment();
            Dept.StartPosition = FormStartPosition.CenterScreen;
            Dept.Show();
        }

        private void 员工基本信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployee employee = new FormEmployee();
            employee.StartPosition = FormStartPosition.CenterScreen;
            employee.Show();
        }

        private void 采购订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPurchase purchase = new FormPurchase();
            purchase.StartPosition = FormStartPosition.CenterScreen;
            purchase.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPurchase purchase = new FormPurchase();
            purchase.StartPosition = FormStartPosition.CenterScreen;
            purchase.Show();
        }
    }
}
