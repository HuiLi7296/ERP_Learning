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
using ERP_Learning.DataClass;
using System.Data.SqlClient;

namespace ERP_Learning.HR
{
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }

        CommonUse commUse = new CommonUse();
        DataBase db = new DataBase();


        private void FormDepartment_Load (object sender, EventArgs e)
        {
            commUse.BuildTree(treeView1,null, "部门信息", "Department", "DepartmentID", "DepartmentName");

            this.txtDeptID.Enabled = false;
            this.txtDeptName.Enabled = false;
            this.buttonSave.Enabled = false;

        }

        private void TextBox_Select ()
        {
            txtDeptID.Text = this.treeView1.SelectedNode.Tag.ToString();
            txtDeptName.Text = this.treeView1.SelectedNode.Text;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string tDeptid = "";
            tDeptid = this.treeView1.SelectedNode.Tag.ToString();
            txtDeptID.Text = tDeptid;

            string tDeptName = "";
            tDeptName = this.treeView1.SelectedNode.Text;
            txtDeptName.Text = tDeptName;
        }

        private void enable_TV()
        {
            this.txtDeptID.Enabled = false;
            this.txtDeptName.Enabled = false;
            this.treeView1.Enabled = true;
        }
        private void disable_TV()
        {
            this.txtDeptID.Enabled = false;
            this.txtDeptName.Enabled = true;
            this.treeView1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            txtDeptName.Text = null;
            txtDeptID.Text = null;

            //this.txtDeptID.Enabled = false;
            //this.txtDeptName.Enabled = true;
            //this.treeView1.Enabled = false;
            disable_TV();
            this.buttonSave.Enabled = true;

        }
        private void buttonMod_Click(object sender, EventArgs e)
        {

            //this.txtDeptID.Enabled = false;
            //this.treeView1.Enabled = false;
            //this.txtDeptName.Enabled = true;
            disable_TV();
            this.buttonSave.Enabled = true;

        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            string strSql = "Delete From Department Where DepartmentID = " + txtDeptID.Text ; 

            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    if (db.ExecDataBySql(strSql)>0)
                    {
                        MessageBox.Show("删除成功！", "软件提示");

                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "软件提示");

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }

            }

            txtDeptName.Text = null;
            txtDeptID.Text = null;
            commUse.BuildTree(treeView1, null, "部门信息", "Department", "DepartmentID", "DepartmentName"); 

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //string deptID = txtDeptID.Text;
            //string deptName = txtDeptName.Text;

            SqlParameter deptId = new SqlParameter("@DepartmentID", SqlDbType.Int);
            SqlParameter deptName = new SqlParameter("@DepartmentName", SqlDbType.NVarChar);

            if (txtDeptID.Text == null || txtDeptID.Text =="")
            {
                deptId.Value = DBNull.Value;
            }
            else
            {
                deptId.Value =Int32.Parse(txtDeptID.Text);
            }
            
            deptName.Value = txtDeptName.Text;

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(deptId);
            parameters.Add(deptName);


            SqlParameter[] inputParameters = parameters.ToArray();


            DataTable sdr = db.ExecDataBySP("setDepartment", inputParameters);


            if (sdr.Rows.Count > 0)
            {
                MessageBox.Show("设置成功！", "软件提示");
            }

            else
            {
                MessageBox.Show("设置失败！", "软件提示");
            }


            commUse.BuildTree(treeView1, null, "部门信息", "Department", "DepartmentID", "DepartmentName");
            enable_TV();

            this.buttonSave.Enabled = false;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
