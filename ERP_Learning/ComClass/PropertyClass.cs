using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Learning.ComClass
{
    public class PropertyClass
    {
        private static string m_UserID;

        public static string UserID
        {
            get
            {
                return m_UserID;
            }
            set
            {
                m_UserID = value; 
            }
        }

        private static string m_UserName;

        public static string UserName
        {
            get
            {
                return m_UserName;
            }
            set
            {
                m_UserName = value;
            }
        }


        private static string m_UserPwd;

        public static string UserPwd
        {
            get
            {
                return m_UserPwd;
            }
            set
            {
                m_UserPwd = value;
            }
        }

        private static string m_Role;

        public static string Role
        {
            get
            {
                return m_Role;
            }
            set
            {
                m_Role = value;
            }
        }

    }
}
