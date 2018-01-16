using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace ERP_Learning.ComClass
{
    public class OperatorFile
    {
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filepath);

        public OperatorFile()
        {

        }

        public static string GetIniFileString(string section, string key, string def, string filepath)
        {
            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString(section, key, def, temp, 1024, filepath);
            return temp.ToString();

           
        }
    }
}
