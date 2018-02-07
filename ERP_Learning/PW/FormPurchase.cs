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

namespace ERP_Learning.PW
{
    public partial class FormPurchase : Form
    {
        DataBase db = new DataBase();
        CommonUse commUse = new CommonUse();

        public FormPurchase()
        {
            InitializeComponent();
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolModify.Enabled = !this.toolModify.Enabled;
            this.toolDelete.Enabled = !this.toolDelete.Enabled;

            this.dgvPO.DataError += delegate (object sender, DataGridViewDataErrorEventArgs e) { };

        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            //Meterial
            DataSet material = new DataSet();
            material = db.GetDataSet("select MaterialID,MaterialName from Material", "Material");
            cbxMaterial.DataSource = material.Tables["Material"];
            cbxMaterial.DisplayMember = "MaterialName";
            cbxMaterial.ValueMember = "MaterialID";
            DataGridViewComboBoxColumn dgvcbxMaterial = (DataGridViewComboBoxColumn)this.dgvPO.Columns[2];
            dgvcbxMaterial.DataSource = material.Tables["Material"];
            dgvcbxMaterial.DisplayMember = "MaterialName";
            

            //Vendor
            DataSet vendor = new DataSet();
            vendor = db.GetDataSet("select * from Vendor", "Vendor");
            cbxVendor.DataSource = vendor.Tables["Vendor"];
            cbxVendor.DisplayMember = "VendorName";
            cbxVendor.ValueMember = "VendorID";
            DataGridViewComboBoxColumn dgvcbxVendor = (DataGridViewComboBoxColumn)this.dgvPO.Columns[3];
            dgvcbxVendor.DataSource = vendor.Tables["Vendor"];
            dgvcbxVendor.DisplayMember = "VendorName";

            //Employee
            DataSet employee = new DataSet();
            employee = db.GetDataSet("select * from Employee", "Employee");
            cbxEmployee.DataSource = employee.Tables["Employee"];
            cbxEmployee.DisplayMember = "EmployeeName";
            cbxEmployee.ValueMember = "EmployeeID";
            DataGridViewComboBoxColumn dgvcbxEmployee = (DataGridViewComboBoxColumn)this.dgvPO.Columns[6];
            dgvcbxEmployee.DataSource = employee.Tables["Employee"];
            dgvcbxEmployee.DisplayMember = "EmployeeName";


            //Audit
            DataTable audit = new DataTable();
            audit.Columns.Add("IsAudit");
            audit.Columns.Add("auditcolumn");
            audit.Rows.Add(false, "未审核");
            audit.Rows.Add(true, "已审核");
            cbxAudit.DataSource = audit;
            cbxAudit.DisplayMember = "auditcolumn";
            cbxAudit.ValueMember = "IsAudit";
            DataGridViewComboBoxColumn dgvcbxAudit = (DataGridViewComboBoxColumn)dgvPO.Columns[8];
            dgvcbxAudit.DataSource = audit;
            dgvcbxAudit.DisplayMember = "auditcolumn";
            //dgvcbxAudit.ValueMember = "IsAudit";


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
            this.txtOrderID.Enabled = false;
            this.dtOrder.Enabled = !this.dtOrder.Enabled;
            this.cbxMaterial.Enabled = !this.cbxMaterial.Enabled;
            this.cbxVendor.Enabled = !this.cbxVendor.Enabled;
            this.txtPrice.Enabled = !this.txtPrice.Enabled;
            this.txtQuantity.Enabled = !this.txtQuantity.Enabled;
            this.cbxEmployee.Enabled = !this.cbxEmployee.Enabled;
            this.txtAmount.Enabled = false;
            this.cbxAudit.Enabled = !this.cbxAudit.Enabled;

        }

        private void ClearControls()
        {
            this.txtOrderID.Text = "";
            this.dtOrder.Value = DateTime.Today;
            this.cbxMaterial.SelectedIndex = -1;
            this.cbxVendor.SelectedIndex = -1;
            this.txtPrice.Text = "";
            this.txtQuantity.Text = "";
            this.cbxEmployee.SelectedIndex = -1;
            this.txtAmount.Text = "";
            this.cbxAudit.SelectedIndex = -1;
        }

        private void BindToolStripComboBox()
        {
            this.cbxCondition.Items.Add("单据编号");
            this.cbxCondition.Items.Add("单据日期");
        }

        private void FillControls()
        {
            this.txtOrderID.Text = this.dgvPO[0, this.dgvPO.CurrentCell.RowIndex].Value.ToString();
            this.dtOrder.Value = Convert.ToDateTime(this.dgvPO[1, this.dgvPO.CurrentCell.RowIndex].Value);
            this.cbxMaterial.Text = this.dgvPO[2, this.dgvPO.CurrentCell.RowIndex].Value.ToString();
            this.cbxVendor.Text = this.dgvPO[3, this.dgvPO.CurrentCell.RowIndex].Value.ToString();
            this.txtPrice.Text = this.dgvPO[4, this.dgvPO.CurrentCell.RowIndex].Value.ToString();
            this.txtQuantity.Text = this.dgvPO[5, this.dgvPO.CurrentCell.RowIndex].Value.ToString();
            this.cbxEmployee.Text = this.dgvPO[6, this.dgvPO.CurrentCell.RowIndex].Value.ToString();
            this.txtAmount.Text = this.dgvPO[7, this.dgvPO.CurrentCell.RowIndex].Value.ToString();
            this.cbxAudit.Text = this.dgvPO[8, this.dgvPO.CurrentCell.RowIndex].Value.ToString();

        }

        private void ParametersAddValueForAdd(SqlCommand Cmd)
        {
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@MaterialID", cbxMaterial.SelectedValue);
            Cmd.Parameters.AddWithValue("@VendorID", cbxVendor.SelectedValue);
            Cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal( txtPrice.Text.ToString()));
            Cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt16(txtQuantity.Text.ToString()));
            Cmd.Parameters.AddWithValue("@EmployeeID", cbxEmployee.SelectedValue);
            Cmd.Parameters.AddWithValue("@IsAudit",  cbxAudit.SelectedValue);
        }
        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ControlStatusSaveCancel();
            ClearControls();
            toolStrip1.Tag = "ADD";

        }
        private void toolModify_Click(object sender, EventArgs e)
        {
            ControlStatusSaveCancel();
            ControlStatus();
            toolStrip1.Tag = "MOD";

        }

        private void toolSave_Click(object sender, EventArgs e)
        {

            db.Conn.Open();
            int row;
            if (toolStrip1.Tag.ToString() == "ADD")
            {
                SqlCommand Cmd = new SqlCommand("addPurchaseOrder", db.Conn);
                Cmd.CommandType = CommandType.StoredProcedure;
                this.ParametersAddValueForAdd(Cmd);
                row = Cmd.ExecuteNonQuery();
            }


            else
            {
                SqlCommand Cmd = new SqlCommand("updatePurchaseOrder", db.Conn);
                Cmd.CommandType = CommandType.StoredProcedure;
                this.ParametersAddValueForAdd(Cmd);
                Cmd.Parameters.AddWithValue("@PurchaseOrderID", Convert.ToInt32( txtOrderID.Text));
                Cmd.Parameters.AddWithValue("@CreateDate", Convert.ToDateTime(dtOrder.Value));

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
                this.BindDataGridView("","");
            }

            else
            {
                MessageBox.Show("保存失败！", "软件提示");
            }
            
        }

        private void BindDataGridView(string OrderID, string OrderDate)
        {
            SqlCommand Cmd = new SqlCommand("getPurchaseOrder", db.Conn);
            Cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                if (!string.IsNullOrEmpty(OrderID))
                //{
                //    Cmd.Parameters.AddWithValue("@PurchaseOrderID", DBNull.Value);
                //}
                //else
                {
                    Cmd.Parameters.AddWithValue("@PurchaseOrderID", OrderID);

                }

                if (!string.IsNullOrEmpty(OrderDate))
                //{
                //    Cmd.Parameters.AddWithValue("@PurchaseDate", DBNull.Value);
                //}
                //else
                {
                    Cmd.Parameters.AddWithValue("@PurchaseDate", OrderDate);

                }

                SqlDataAdapter PurchaseOrder = new SqlDataAdapter();
                DataTable PO = new DataTable();
                PurchaseOrder.SelectCommand = Cmd;
                PurchaseOrder.Fill(PO);

                this.dgvPO.DataSource = PO;
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw; 
            }
           
 
        }

     

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControls();
            toolStrip1.Tag = "";
            ControlStatusSaveCancel();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            db.Conn.Open();
            int row; 
            SqlCommand Cmd = new SqlCommand("deletePurchaseOrder", db.Conn);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@PurchaseOrderID", Convert.ToInt32(txtOrderID.Text));

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
                this.BindDataGridView("","");
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

        private void dgvPO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPO.RowCount > 0)
            {
                FillControls();
            }
        }

        private void toolrefresh_Click(object sender, EventArgs e)
        {
            this.BindDataGridView("","");

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    OrderID =  txtSearch.Text.Trim();
                    this.BindDataGridView(OrderID, "");
                    break;

                case "单据日期":
                    OrderDate = txtSearch.Text.Trim();
                    this.BindDataGridView("",OrderDate);
                    break;

                default:
                    break;

            }
        }

        private void toolSearch_Click_1(object sender, EventArgs e)
        {

        }
    }
}
