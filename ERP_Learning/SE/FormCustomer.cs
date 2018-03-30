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


namespace ERP_Learning.SE
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        CommonUse commUse = new CommonUse();
        DataBase db = new DataBase();

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            commUse.BuildTree(treeView1, null, "客户信息", "Customer", "CustomerID", "CustomerName");

            this.txtCusID.Enabled = false;
            this.txtCusName.Enabled = false;
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.textBox3.Enabled = false;
            this.buttonSave.Enabled = false;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string tCusID = "";
            tCusID = this.treeView1.SelectedNode.Tag.ToString();
            txtCusID.Text = tCusID;

            string tCusName = "";
            tCusName = this.treeView1.SelectedNode.Text;
            txtCusName.Text = tCusName;

            SqlParameter cusId = new SqlParameter("@CustomerID", SqlDbType.Int);
            cusId.Value = tCusID;// Int32.Parse(txtCusID.Text);

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(cusId);
            SqlParameter[] inputParameters = parameters.ToArray();
            DataTable sdr = db.ExecDataBySP("getCustomer", inputParameters);
            if (sdr.Rows.Count > 0)
            {
                DataRow dr = sdr.Rows[0];

                textBox1.Text = dr["Address"].ToString();
                textBox2.Text = dr["Phone"].ToString();
                textBox3.Text = dr["Email"].ToString();
            }
                


        }

        private void enable_TV()
        {
            this.txtCusID.Enabled = false;
            this.txtCusName.Enabled = false;
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.textBox3.Enabled = false;
            this.treeView1.Enabled = true;
        }
        private void disable_TV()
        {
            this.txtCusID.Enabled = false;
            this.txtCusName.Enabled = true;
            this.textBox1.Enabled = true;
            this.textBox2.Enabled = true;
            this.textBox3.Enabled = true;
            this.treeView1.Enabled = false;
        }


        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            txtCusName.Text = null;
            txtCusID.Text = null;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            disable_TV();
            this.buttonSave.Enabled = true;

        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            disable_TV();
            this.buttonSave.Enabled = true;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string strSql = "Delete From Customer Where CustomerID = " + txtCusID.Text;

            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    if (db.ExecDataBySql(strSql) > 0)
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

            txtCusName.Text = null;
            txtCusID.Text = null;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;

            commUse.BuildTree(treeView1, null, "客户信息", "Customer", "CustomerID", "CustomerName");

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlParameter cusId = new SqlParameter("@CustomerID", SqlDbType.Int);
            SqlParameter cusName = new SqlParameter("@CustomerName", SqlDbType.NVarChar);
            SqlParameter cusAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
            SqlParameter cusPhone = new SqlParameter("@Phone", SqlDbType.VarChar);
            SqlParameter cusEmail = new SqlParameter("@Email", SqlDbType.VarChar);

            if (txtCusID.Text == null || txtCusID.Text == "")
            {
                cusId.Value = DBNull.Value;
            }
            else
            {
                cusId.Value = Int32.Parse(txtCusID.Text);
            }

            cusName.Value = txtCusName.Text;
            cusAddress.Value = textBox1.Text;
            cusPhone.Value = textBox2.Text;
            cusEmail.Value = textBox3.Text; 

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(cusId);
            parameters.Add(cusName);
            parameters.Add(cusAddress);
            parameters.Add(cusPhone);
            parameters.Add(cusEmail);


            SqlParameter[] inputParameters = parameters.ToArray();


            DataTable sdr = db.ExecDataBySP("setCustomer", inputParameters);


            if (sdr.Rows.Count > 0)
            {
                MessageBox.Show("设置成功！", "软件提示");
            }

            else
            {
                MessageBox.Show("设置失败！", "软件提示");
            }

            commUse.BuildTree(treeView1, null, "客户信息", "Customer", "CustomerID", "CustomerName");
 
            enable_TV();

            this.buttonSave.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
