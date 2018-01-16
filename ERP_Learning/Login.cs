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

namespace ERP_Learning
{
    public partial class Login : Form
    {
        DataBase db = new DataBase();
        SqlDataReader sdr = null; 

        public Login()
        {
            InitializeComponent();
        }

        private void textUser_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textPwd.Focus(); 
            }
        }

        private void textPwd_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butLogin_Click(sender, e); 
            }
        }

        //Login
        private void butLogin_Click(object sender, EventArgs e)
        {
            this.errInfo.Clear();

            if (string.IsNullOrEmpty(this.textUser.Text.Trim()))
            {
                try
                {
                    this.errInfo.SetError(this.textUser, "用户账号不能为空!");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }
            }

            if (string.IsNullOrEmpty(this.textPwd.Text.Trim()))
            {
                try
                {
                    this.errInfo.SetError(this.textPwd, "用户密码不能为空!");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }
            }

            string strSql = "SELECT * FROM dbo.[User] u JOIN dbo.Role r ON r.RoleID = u.RoleID";
            strSql += " WHERE u.UserName ='" + textUser.Text.Trim();
            strSql += "' AND u.UserPwd = '" + textPwd.Text.Trim() +"'";

            try
            {
                sdr =   db.GetDataReader(strSql);
                sdr.Read();

                if (sdr.HasRows)
                {
                    FormMain formMain = new FormMain();
                    this.Hide();
                    PropertyClass.UserID = sdr["UserID"].ToString();
                    PropertyClass.UserName = sdr["UserName"].ToString();
                    PropertyClass.UserPwd = sdr["UserPwd"].ToString();
                    PropertyClass.Role = sdr["ShortName"].ToString();

                    formMain.Show();
                }

                else
                {
                    MessageBox.Show("用户名或者密码不正确！", "软件提示");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");

            }
            finally
            {
                sdr.Close();
            }


        }

        //Reset 
        private void butReset_Click(object sender, EventArgs e)
        {
            textUser.Text = "";
            textPwd.Text = "";
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void butLogin_Click_1(object sender, EventArgs e)
        //{

        //}

        ////private void butReset_Click(object sender, EventArgs e)
        //{

        //}
    }
}
