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
        public static fCauHinh formCauHinh = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            formDangNhap = new fDangNhap();
            Application.Run(formDangNhap);
            
        }
    }
}
