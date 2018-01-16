using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;
//using crys
using ERP_Learning.DataClass; 

namespace ERP_Learning.ComClass
{
    public class CommonUse
    {
        DataBase db = new DataBase(); 

        public CommonUse()
        {

        }

        public void BuildTree(TreeView tv, ImageList imgList, string rootName, string strTable, string strCode, string strName)
        {
            string strSql = null;
            DataSet ds = null;
            DataTable dt = null;
            TreeNode rootNode = null;
            TreeNode childNode = null;
            strSql = "select " + strCode + ", " + strName + " from " + strTable;
            tv.Nodes.Clear();
            tv.ImageList = imgList;
            rootNode = new TreeNode();
            rootNode.Tag = null;
            rootNode.Text = rootName;

            rootNode.ImageIndex = 1;
            rootNode.SelectedImageIndex = 0; 

            try
            {
                ds = db.GetDataSet(strSql, strTable);
                dt = ds.Tables[strTable]; 

                foreach (DataRow row in dt.Rows)
                {
                    childNode = new TreeNode();
                    childNode.Tag = row[strCode];
                    childNode.Text = row[strName].ToString();
                    childNode.ImageIndex = 1;
                    childNode.SelectedImageIndex = 0;
                    rootNode.Nodes.Add(childNode); 
                }
                tv.Nodes.Add(rootNode);
                tv.ExpandAll(); 

            }
            catch (Exception e )
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e; 
            }

        }

        public void DataGridViewReset(DataGridView dgv)
        {
            if (dgv.DataSource != null)
            {
                //若DataGridView绑定的数据源为DataTable
                if (dgv.DataSource.GetType() == typeof(DataTable))
                {
                    DataTable dt = dgv.DataSource as DataTable;
                    dt.Clear();
                }

                //若DataGridView绑定的数据源为BindingSource
                if (dgv.DataSource.GetType() == typeof(BindingSource))
                {
                    BindingSource bs = dgv.DataSource as BindingSource;
                    DataTable dt = bs.DataSource as DataTable;
                    dt.Clear();
                }
            }
        }

    }
}
