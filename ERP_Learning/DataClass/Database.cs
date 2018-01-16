using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using ERP_Learning.ComClass;

namespace ERP_Learning.DataClass
{
    public class DataBase
    {
        private SqlConnection m_Conn = null;
        private SqlCommand m_Cmd = null; 

        public DataBase()
        {
            string strServer = OperatorFile.GetIniFileString("Database", "Server", "", Application.StartupPath + "\\ERP_Learning.ini");
            string strUserID = OperatorFile.GetIniFileString("Database", "UserID", "", Application.StartupPath + "\\ERP_Learning.ini");
            string strPwd    = OperatorFile.GetIniFileString("Database", "Pwd", "", Application.StartupPath + "\\ERP_Learning.ini");
            string strDB     = OperatorFile.GetIniFileString("Database", "Database", "", Application.StartupPath + "\\ERP_Learning.ini");

            string strConn = "Server = " + strServer + "; Database = " + strDB +"; User id = " + strUserID + "; PWD =" + strPwd;

            try
            {
                m_Conn = new SqlConnection(strConn);
                m_Cmd = new SqlCommand();
                m_Cmd.Connection = m_Conn;

            }
            catch (Exception e)
            {
                throw e; 
            }
        }



        //public SqlConnection Conn
        //{
        //    get { return m_Conn; }
        //}


        //public SqlCommand Cmd
        //{
        //    get { return m_Cmd; }
        //}


        public int ExecDataBySql(string strSql)
        {
            int intReturnValue;

            m_Cmd.CommandType = CommandType.Text;
            m_Cmd.CommandText = strSql; 


            try
            {
                if (m_Conn.State ==ConnectionState.Closed)
                {
                    m_Conn.Open();
                }

                intReturnValue = m_Cmd.ExecuteNonQuery();
                                  
            }

            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                m_Conn.Close();
            }

            return intReturnValue;
        }


        public bool ExecDataBySqls(List<string> strSqls)
        {
            bool booIsSucceed;

            if (m_Conn.State ==ConnectionState.Closed)
            {
                m_Conn.Open();

            }

            SqlTransaction sqlTran = m_Conn.BeginTransaction();

            try
            {
                m_Cmd.Transaction = sqlTran;

                foreach (string item in strSqls)
                {
                    m_Cmd.CommandType = CommandType.Text;
                    m_Cmd.CommandText = item;
                    m_Cmd.ExecuteNonQuery();

                }

                sqlTran.Commit();
                booIsSucceed = true;
            }

            catch
            {
                sqlTran.Rollback();
                booIsSucceed = false;
            }

            finally
            {
                m_Conn.Close();
                strSqls.Clear();
            }

            return booIsSucceed; 
        }

        public DataSet GetDataSet(string strSql, string strTable)
        {
            DataSet ds = null;

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(strSql, m_Conn);
                ds = new DataSet();
                sda.Fill(ds, strTable);

            }

            catch (Exception e)
            {
                throw e;
            }

            return ds; 
        }

        public SqlDataReader GetDataReader (string strSql)
        {
            SqlDataReader sdr;

            m_Cmd.CommandType = CommandType.Text;
            m_Cmd.CommandText = strSql;

            try
            {
                if (m_Conn.State == ConnectionState.Closed)
                {
                    m_Conn.Open();
                }

                sdr = m_Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                
            }

            catch (Exception e )
            {
                throw e;
            }

            return sdr;

        }

        public object GetSingleObject(string strSql)
        {
            object obj = null;
            m_Cmd.CommandType = CommandType.Text;
            m_Cmd.CommandText = strSql; 

            try
            {
                if (m_Conn.State == ConnectionState.Closed)
                {
                    m_Conn.Open();

                }

                obj = m_Cmd.ExecuteScalar();

            }

            catch (Exception e )
            {
                throw e;
            }

            finally
            {
                m_Conn.Close();
            }
            return obj; 
        }

        public DataTable GetDataTable(string strSqlCode, string strTableName)
        {
            DataTable dt = null;
            SqlDataAdapter sda = null; 

            try
            {
                sda = new SqlDataAdapter(strSqlCode, m_Conn);
                dt = new DataTable(strTableName);
                sda.Fill(dt);
            
            }

            catch (Exception e)
            {
                throw e;
            }

            return dt;
        }

        public DataTable ExecDataBySP (string strProcedureName, SqlParameter[] inputParameters)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = null;

            try
            {
                m_Cmd.CommandType = CommandType.StoredProcedure;
                m_Cmd.CommandText = strProcedureName;
                sda = new SqlDataAdapter(m_Cmd);
                m_Cmd.Parameters.Clear();

                foreach (SqlParameter param in inputParameters)
                {
                    param.Direction = ParameterDirection.Input;
                    m_Cmd.Parameters.Add(param);
                }

                sda.Fill(dt);

            }

            catch (Exception e)
            {
                throw e;
            }

            return dt; 
        }


    }


}
