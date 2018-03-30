using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_Learning.DataClass;
using ERP_Learning.ComClass;
using System.Data.SqlClient;

namespace ERP_Learning.SE
{
    public partial class FormSalesCollection : Form
    {
        DataBase db = new DataBase();
        CommonUse commUse = new CommonUse();
        public FormSalesCollection()
        {
            InitializeComponent();
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolModify.Enabled = !this.toolModify.Enabled;
            this.toolDelete.Enabled = !this.toolDelete.Enabled;

            this.dgvPO.DataError += delegate (object sender, DataGridViewDataErrorEventArgs e) { };

        }

        private void FormSalesCollection_Load(object sender, EventArgs e)
        {
            //Product
            DataSet Product = new DataSet();
            Product = db.GetDataSet("select ProductID,ProductName from Product", "Product");
            cbxProduct.DataSource = Product.Tables["Product"];
            cbxProduct.DisplayMember = "ProductName";
            cbxProduct.ValueMember = "ProductID";
            DataGridViewComboBoxColumn dgvcbxProduct = (DataGridViewComboBoxColumn)this.dgvPO.Columns[4];
            dgvcbxProduct.DataSource = Product.Tables["Product"];
            dgvcbxProduct.DisplayMember = "ProductName";


            //customer
            DataSet customer = new DataSet();
            customer = db.GetDataSet("select * from Customer", "Customer");
            cbxCustomer.DataSource = customer.Tables["Customer"];
            cbxCustomer.DisplayMember = "CustomerName";
            cbxCustomer.ValueMember = "CustomerID";
            DataGridViewComboBoxColumn dgvcbxCustomer = (DataGridViewComboBoxColumn)this.dgvPO.Columns[5];
            dgvcbxCustomer.DataSource = customer.Tables["Customer"];
            dgvcbxCustomer.DisplayMember = "CustomerName";

            ControlStatusSaveCancel();
            ControlStatus();
            this.BindDataGridView("", "");
            this.BindToolStripComboBox();
            this.cbxCondition.SelectedIndex = -1;
            toolStrip1.Tag = "";
        }


        private void ControlStatusSaveCancel()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
        }

        private void ControlStatus()
        {

            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolModify.Enabled = !this.toolModify.Enabled;
            this.toolDelete.Enabled = !this.toolDelete.Enabled;

            this.txtSalesOutID.Enabled = false;
            this.txtOrderID.Enabled = false;
            this.dtOrder.Enabled = false;
            this.dtSalesOut.Enabled = !this.dtSalesOut.Enabled;
            this.cbxProduct.Enabled = false;
            this.cbxCustomer.Enabled = false;
            //this.txtPrice.Enabled = !this.txtPrice.Enabled;
            this.txtTotalAmount.Enabled = false;
            this.txtCollectedAmount.Enabled = !this.txtCollectedAmount.Enabled;
            //this.cbxEmployee.Enabled = !this.cbxEmployee.Enabled;
            //this.txtAmount.Enabled = false;
            //this.cbxAudit.Enabled = !this.cbxAudit.Enabled;

        }

        private void ClearControls()
        {
            this.txtOrderID.Text = "";
            this.dtOrder.Value = DateTime.Today;
            this.cbxProduct.SelectedIndex = -1;
            this.cbxCustomer.SelectedIndex = -1;
            this.txtCollectedAmount.Text = "";
            this.txtTotalAmount.Text = "";

        }

        private void BindToolStripComboBox()
        {
            this.cbxCondition.Items.Add("单据编号");
            this.cbxCondition.Items.Add("单据日期");
        }


        private void FillControls()
        {
            this.txtSalesOutID.Text = this.dgvPO[0, this.dgvPO.CurrentCell.RowIndex].Value.ToString();
            this.txtOrderID.Text = this.dgvPO[2, this.dgvPO.CurrentCell.RowIndex].Value.ToString();
            this.dtSalesOut.Value = Convert.ToDateTime(this.dgvPO[1, this.dgvPO.CurrentCell.RowIndex].Value);
            this.dtOrder.Value = Convert.ToDateTime(this.dgvPO[3, this.dgvPO.CurrentCell.RowIndex].Value);
            this.cbxProduct.Text = this.dgvPO[4, this.dgvPO.CurrentCell.RowIndex].Value.ToString();
            this.cbxCustomer.Text = this.dgvPO[5, this.dgvPO.CurrentCell.RowIndex].Value.ToString();
            this.txtTotalAmount.Text = this.dgvPO[7, this.dgvPO.CurrentCell.RowIndex].Value.ToString();
            this.txtCollectedAmount.Text = this.dgvPO[6, this.dgvPO.CurrentCell.RowIndex].Value.ToString();


        }

        private void ParametersAddValueForAdd(SqlCommand Cmd)
        {
            Cmd.Parameters.Clear();

            Cmd.Parameters.AddWithValue("@SalesOrderID", Convert.ToInt32(txtOrderID.Text.ToString()));
            //Cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt16(txtTotalAmount.Text.ToString()));
            Cmd.Parameters.AddWithValue("@Amount", Convert.ToInt16(txtCollectedAmount.Text.ToString()));

        }
        private void BindDataGridView(string OrderID, string OrderDate)
        {
            SqlCommand Cmd = new SqlCommand("getSalesCollection", db.Conn);
            Cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                if (!string.IsNullOrEmpty(OrderID))

                {
                    Cmd.Parameters.AddWithValue("@SalesCollectionID", OrderID);

                }

                if (!string.IsNullOrEmpty(OrderDate))

                {
                    Cmd.Parameters.AddWithValue("@OrderDate", OrderDate);

                }

                SqlDataAdapter SalesCollection = new SqlDataAdapter();
                DataTable PO = new DataTable();
                SalesCollection.SelectCommand = Cmd;
                SalesCollection.Fill(PO);

                this.dgvPO.DataSource = PO;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw;
            }


        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ControlStatusSaveCancel();
            ClearControls();
            this.txtOrderID.Enabled = true;
            toolStrip1.Tag = "ADD";
        }

        private void toolModify_Click(object sender, EventArgs e)
        {
            ControlStatusSaveCancel();
            ControlStatus();
            toolStrip1.Tag = "MOD";
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            db.Conn.Open();
            int row;
            SqlCommand Cmd = new SqlCommand("deleteSalesCollection", db.Conn);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@SalesCollectionID", Convert.ToInt32(txtSalesOutID.Text));

            var returnValue = Cmd.Parameters.Add("@Return", SqlDbType.Int);
            returnValue.Direction = ParameterDirection.ReturnValue;

            row = Cmd.ExecuteNonQuery();
            int re = (int)returnValue.Value;

            db.Conn.Close();
            if (row > 0)
            {
                MessageBox.Show("删除成功", "软件提示");
                ClearControls();
                //ControlStatus();
                //ControlStatusSaveCancel();
                toolStrip1.Tag = "";
                this.BindDataGridView("", "");
            }

            else
            {
                if (re == 1)
                {
                    MessageBox.Show("订单已审核, 无法删除", "软件提示");
                }
                MessageBox.Show("删除失败！", "软件提示");
            }
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();
                int row;
                if (toolStrip1.Tag.ToString() == "ADD")
                {
                    SqlCommand Cmd = new SqlCommand("addSalesCollection", db.Conn);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    this.ParametersAddValueForAdd(Cmd);
                    row = Cmd.ExecuteNonQuery();
                }


                else
                {
                    SqlCommand Cmd = new SqlCommand("updateSalesCollection", db.Conn);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.AddWithValue("@SalesCollectionID", Convert.ToInt32(txtSalesOutID.Text));
                    Cmd.Parameters.AddWithValue("@CreateDate", Convert.ToDateTime(dtOrder.Value));
                    Cmd.Parameters.AddWithValue("@Amount", Convert.ToInt16(txtCollectedAmount.Text.ToString()));
      

                    row = Cmd.ExecuteNonQuery();
                }

                db.Conn.Close();
                if (row > 0)
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    ClearControls();
                    ControlStatus();
                    ControlStatusSaveCancel();
                    toolStrip1.Tag = "";
                    this.BindDataGridView("", "");
                }

                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                MessageBox.Show("保存失败！", "软件提示");
                ClearControls();
                ControlStatus();
                ControlStatusSaveCancel();
                //throw ex;           

            }
            finally
            {

                toolStrip1.Tag = "";
                this.BindDataGridView("", "");
                db.Conn.Close();

            }
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControls();
            toolStrip1.Tag = "";
            ControlStatusSaveCancel();
        }
        private void dgvPO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPO.RowCount > 0)
            {
                FillControls();
            }
        }

        private void toolSearch_Click(object sender, EventArgs e)
        {
            string strcondition = this.cbxCondition.Items[this.cbxCondition.SelectedIndex].ToString();
            string OrderID;
            string OrderDate;

            switch (strcondition)
            {
                //    this.cbxCondition.Items.Add("单据编号");
                //this.cbxCondition.Items.Add("单据日期");
                case "单据编号":
                    OrderID = txtSearch.Text.Trim();
                    this.BindDataGridView(OrderID, "");
                    break;

                case "单据日期":
                    OrderDate = txtSearch.Text.Trim();
                    this.BindDataGridView("", OrderDate);
                    break;

                default:
                    break;

            }

        }

        private void toolrefresh_Click(object sender, EventArgs e)
        {
            this.BindDataGridView("", "");

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
