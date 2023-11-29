using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Data.SqlClient;

namespace BLL_DAL
{
    public class DAL_QLNguoiDung
    {
        public DAL_QLNguoiDung() { }

        public List<string> getServerName()
        {
            List<string> lstServer = new List<string>();
            var registryViewArray = new[] { RegistryView.Registry32, RegistryView.Registry64 };

            foreach (var registryView in registryViewArray)
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                using (var key = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server"))
                {
                    var instances = (string[])key?.GetValue("InstalledInstances");
                    if (instances != null)
                    {
                        foreach (var element in instances)
                        {
                            if (element == "MSSQLSERVER")
                                lstServer.Add(System.Environment.MachineName);
                            else
                                lstServer.Add(System.Environment.MachineName + @"\" + element);

                        }
                    }
                }
            }
            return lstServer;
        }

        public DataTable getDBName(string tServer, string tUser, string tPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
                "Data Source=" + tServer + ";User ID=" + tUser + "; pwd = " + tPass);
            da.Fill(dt);
            return dt;
        }

        public void saveConfig(string tServer, string tUser, string tPass, string tDBName)
        {
            BLL_DAL.Properties.Settings.Default.QLQuanMiCayConnectionString = BLL_DAL.Properties.Settings.Default.QLQuanMiCayConnectionString1 = "Data Source=" + tServer + ";Initial Catalog=" + tDBName + ";User ID="
                    + tUser + "; pwd = " + tPass + "";
            BLL_DAL.Properties.Settings.Default.Save();
        }
    }
}
