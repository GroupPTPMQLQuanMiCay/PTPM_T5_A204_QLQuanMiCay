using PTPM_QLMiCay.GUI;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;



namespace PTPM_QLMiCay
{
    static class Program
    {
        public static fDangNhap formDangNhap = null;
        public static fTrangChu formTrangChu = null;
        public static fTest ftest = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formTrangChu = new fTrangChu();
            Application.Run(formTrangChu);
            
        }
    }
}
