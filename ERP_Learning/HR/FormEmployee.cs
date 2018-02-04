using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ERP_Learning.DataClass;
using ERP_Learning.ComClass; 


namespace ERP_Learning.HR
{
    public partial class FormEmployee : Form
    {
        DataBase db = new DataBase();
        CommonUse commUse = new CommonUse(); 

        public FormEmployee()
        {
            InitializeComponent();
            this.dgvEmployeeInfo.DataError += delegate (object sender, DataGridViewDataErrorEventArgs e) { };
        }

        private void ControlStatusSaveCancel ()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
        }
        private void ControlStatus()
        {
            //this.toolSave.Enabled = this.toolSave.Enabled;
            //this.toolCancel.Enabled = this.toolCancel.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolModify.Enabled = !this.toolModify.Enabled;
            this.toolDelete.Enabled = !this.toolDelete.Enabled;


            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeName.Enabled = !this.txtEmployeeName.Enabled;
            this.txtAddress.Enabled = !this.txtAddress.Enabled;
            this.txtAge.Enabled = false;
            this.txtEmail.Enabled = !this.txtEmail.Enabled;
            this.txtIDNum.Enabled = !this.txtIDNum.Enabled;
            this.txtJob.Enabled = !this.txtJob.Enabled;
            this.txtPhone.Enabled = !this.txtPhone.Enabled;
            this.cbxActive.Enabled = !this.cbxActive.Enabled;
            this.cbxDeptCode.Enabled = !this.cbxDeptCode.Enabled;
            this.cbxEduLvl.Enabled = !this.cbxEduLvl.Enabled;
            this.cbxGender.Enabled = !this.cbxGender.Enabled;
            this.dtpBirthday.Enabled = !this.dtpBirthday.Enabled;
            this.dtpEntryDate.Enabled = !this.dtpEntryDate.Enabled;

            //this.txtEmployeeName.ReadOnly = !this.txtEmployeeName.ReadOnly;
            //this.cbxDeptCode.Enabled = !this.cbxDeptCode.Enabled;
            //this.txtAge.ReadOnly = true;
            //this.cbxGender.Enabled = !this.cbxGender.Enabled;
            //this.cbxEduLvl.Enabled = !this.cbxEduLvl.Enabled;
            //this.txtJob.ReadOnly = !this.txtJob.ReadOnly;
            //this.dtpEntryDate.Enabled = !this.dtpEntryDate.Enabled;


        }

        private void ClearControls()
        {
            this.txtEmployeeID.Text = "";
            this.txtAge.Text = "";
            this.txtEmployeeName.Text = "";
            this.txtJob.Text = "";
            this.txtPhone.Text = "";
            this.cbxDeptCode.SelectedIndex = -1;
            this.cbxEduLvl.SelectedIndex = -1;
            this.cbxGender.SelectedIndex = -1;
            this.dtpEntryDate.Value = Convert.ToDateTime("2010-01-01");
            this.dtpBirthday.Value = Convert.ToDateTime("1980-1-1");
            this.txtEmail.Text = "";
            this.txtAddress.Text = "";
            this.txtIDNum.Text = "";
            this.cbxActive.SelectedIndex = -1; 




        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            DataSet dept = new DataSet();
            dept = db.GetDataSet("select * from Department", "Department");
            cbxDeptCode.DataSource = dept.Tables["Department"];
            cbxDeptCode.DisplayMember = "DepartmentName";

            DataGridViewComboBoxColumn dgvcbxDept = (DataGridViewComboBoxColumn)this.dgvEmployeeInfo.Columns[10];
            dgvcbxDept.DataSource = dept.Tables["Department"];
            dgvcbxDept.DisplayMember = "DepartmentName";




            DataSet edu = new DataSet();
            edu = db.GetDataSet("select * from EducationLevel", "EducationLevel");
            cbxEduLvl.DataSource = edu.Tables["EducationLevel"];
            cbxEduLvl.DisplayMember = "EducationLevel";

            DataGridViewComboBoxColumn dgvcbxEdu = (DataGridViewComboBoxColumn)dgvEmployeeInfo.Columns[13];
            dgvcbxEdu.DataSource = edu.Tables["EducationLevel"];
            dgvcbxEdu.DisplayMember = "EducationLevel";




            DataTable gender = new DataTable();
            gender.Columns.Add("ID");
            gender.Columns.Add("gender");
            gender.Rows.Add(0, "男");
            gender.Rows.Add(1, "女");
            cbxGender.DataSource = gender;
            cbxGender.DisplayMember = "gender";

            DataGridViewComboBoxColumn dgvcbxGender = (DataGridViewComboBoxColumn)dgvEmployeeInfo.Columns[4];
            dgvcbxGender.DataSource = gender;
            dgvcbxGender.DisplayMember = "gender";




            DataTable active = new DataTable();
            active.Columns.Add("ID");
            active.Columns.Add("active");
            active.Rows.Add(0, "离职");
            active.Rows.Add(1, "在职");

            cbxActive.DataSource = active;
            cbxActive.DisplayMember = "active";

            DataGridViewComboBoxColumn dgvcbxActive = (DataGridViewComboBoxColumn)dgvEmployeeInfo.Columns[2];
            dgvcbxActive.DataSource = active;
            dgvcbxActive.DisplayMember = "active";

            //ControlStatus();
            this.toolSave.Enabled = false;
            this.toolCancel.Enabled = false;

            BindDataGridView("");
            toolStrip1.Tag = "";

            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeName.Enabled = false;
            this.txtAddress.Enabled = false;
            this.txtAge.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtIDNum.Enabled = false;
            this.txtJob.Enabled = false;
            this.txtPhone.Enabled = false;
            this.cbxActive.Enabled = false;
            this.cbxDeptCode.Enabled = false;
            this.cbxEduLvl.Enabled = false;
            this.cbxGender.Enabled = false;
            this.dtpBirthday.Enabled = false;
            this.dtpEntryDate.Enabled = false;


            this.BindToolStripComboBox();
            this.cbxCondition.SelectedIndex = 0;
            toolStrip1.Tag = "";


        }
        private void BindToolStripComboBox()
        {
            this.cbxCondition.Items.Add("员工名称");
            this.cbxCondition.Items.Add("职位");

        }


        private void FillControls()
        {
            
            
            this.txtEmployeeID.Text = this.dgvEmployeeInfo[0, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value.ToString();
            this.txtEmployeeName.Text = this.dgvEmployeeInfo[1, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value.ToString();
            this.cbxActive.Text = this.dgvEmployeeInfo[2, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value.ToString();
            this.txtIDNum.Text = this.dgvEmployeeInfo[3, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value.ToString();
            this.cbxGender.Text = this.dgvEmployeeInfo[4, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value.ToString();
            this.cbxDeptCode.Text = this.dgvEmployeeInfo[10, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value.ToString();


            this.cbxEduLvl.Text = this.dgvEmployeeInfo[13, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value.ToString();
            this.txtJob.Text = this.dgvEmployeeInfo[12, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value.ToString();
            this.dtpEntryDate.Value = Convert.ToDateTime(this.dgvEmployeeInfo[8, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value);
            this.dtpBirthday.Value = Convert.ToDateTime(this.dgvEmployeeInfo[11, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value);

            this.txtPhone.Text = this.dgvEmployeeInfo[6, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value.ToString();
            
            this.txtEmail.Text = this.dgvEmployeeInfo[5, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value.ToString();
            this.txtAddress.Text = this.dgvEmployeeInfo[7, this.dgvEmployeeInfo.CurrentCell.RowIndex].Value.ToString();

            var today = DateTime.Today;
            var age = today.Year - this.dtpBirthday.Value.Year;
            this.txtAge.Text = age.ToString();



        }


        private void BindDataGridView(string strWhere)
        {
            string strsql = null;

            strsql = "SELECT e.EmployeeID ,e.EmployeeName ,CASE	WHEN	IsActive = 1 THEN '在职' ELSE'离职'END IsActive, e.IDNumber ,   CASE	 WHEN e.Gender = 0 THEN '男' ELSE '女'END Gender  ,  e.Email ,e.Phone ,e.Address , e.EntryDate , e.ChangeDate , d.DepartmentName,e.BirthDay ,";
            strsql += "e.Position ,           el.EducationLevel 	FROM dbo.Employee e JOIN dbo.Department d ON	d.DepartmentID = e.DepartmentID " ; 
            strsql += "JOIN dbo.EducationLevel el ON el.EducationLevelID = e.EducationLevelID " + strWhere; 

            try
            {
                this.dgvEmployeeInfo.DataSource = db.GetDataSet(strsql, "Employee").Tables["Employee"]; 

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

        private void ParametersAddValue(SqlCommand Cmd)
        {
            Cmd.Parameters.Clear();
            //Cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim());
            Cmd.Parameters.AddWithValue("@EmployeeName", txtEmployeeName.Text.Trim());

            Cmd.Parameters.AddWithValue("@DepartmentName", cbxDeptCode.Text.ToString());
            Cmd.Parameters.AddWithValue("@EducationLevel", cbxEduLvl.Text.ToString());
            Cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());

            Cmd.Parameters.AddWithValue("@IDNumber", txtIDNum.Text.Trim());
            Cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            Cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
            Cmd.Parameters.AddWithValue("@Position", txtJob.Text.Trim());
            Cmd.Parameters.AddWithValue("@EntryDate", dtpEntryDate.Value);
            Cmd.Parameters.AddWithValue("@BirthDay", dtpBirthday.Value);

            Cmd.Parameters.AddWithValue("@IsActive", cbxActive.SelectedIndex);
            Cmd.Parameters.AddWithValue("@Gender", cbxGender.SelectedIndex);
        }
        
       

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeInfo_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
            //ClearControls();
            toolStrip1.Tag = "MOD";

        }

        private void toolSave_Click(object sender, EventArgs e)
        {

            db.Conn.Open();
            int row;
            if (toolStrip1.Tag.ToString() == "ADD")
            {
                SqlCommand Cmd = new SqlCommand("addEmployee", db.Conn);
                Cmd.CommandType = CommandType.StoredProcedure;
                this.ParametersAddValue(Cmd);
                row = Cmd.ExecuteNonQuery();
            }

            
            else
            {
                SqlCommand Cmd = new SqlCommand("updateEmployee", db.Conn);
                Cmd.CommandType = CommandType.StoredProcedure;
                this.ParametersAddValue(Cmd);
                Cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim());
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
                this.BindDataGridView("");
            }

            else
            {
                MessageBox.Show("保存失败！", "软件提示");
            }



        }

        private void dgvEmployeeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (toolStrip1.Tag.ToString() == "MOD")
            //{
                if (dgvEmployeeInfo.RowCount > 0 )
                {
                    FillControls();
                }
            //}
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControls();
            toolStrip1.Tag = "";
            ControlStatusSaveCancel();



        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.BindDataGridView("");
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            string strSql = "Delete From Employee Where EmployeeID = " + txtEmployeeID.Text ;

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
            ClearControls();
            this.BindDataGridView("");

        }

        private void toolSearch_Click(object sender, EventArgs e)
        {
            string strWhere = String.Empty;
            string strConditonName = String.Empty;

            strConditonName = this.cbxCondition.Items[this.cbxCondition.SelectedIndex].ToString();
            switch (strConditonName)
            {
                case "员工名称":

                    strWhere = " WHERE EmployeeName LIKE '%" + txtSearch.Text.Trim() + "%'";
                    this.BindDataGridView(strWhere);
                    break;

                case "职位":

                    strWhere = " WHERE Position LIKE '%" + txtSearch.Text.Trim() + "%'";
                    this.BindDataGridView(strWhere);
                    break;

                default:
                    break;
            }
        }
    }
}
