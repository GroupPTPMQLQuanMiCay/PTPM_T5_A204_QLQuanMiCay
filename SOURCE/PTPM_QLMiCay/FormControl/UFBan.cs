using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormControl.Forms;
using BLL_DAL;

namespace FormControl
{
    public partial class UFBan : UserControl
    {
        DAL_Ban b = new DAL_Ban();
        TaiKhoan taikhoan = null;
        public UFBan()
        {
            
            InitializeComponent();
            createLoadBan();
        }
        public UFBan(TaiKhoan tk_nv)
        {
            
            InitializeComponent();
            taikhoan = tk_nv;
            createLoadBan();
        }

        private void btnChinhSuaBan_Click(object sender, EventArgs e)
        {
            frmChinhSuaBan frm = new frmChinhSuaBan();
            frm.Show();
        }

        public void createLoadBan()
        {
            tableLayoutPanel1.Controls.Clear();
            int dem = 0;
            //List<int> d = b.loadBanHD();
            foreach (int i in b.loadBanHD())
            {
                Button bt = new Button();
                dem++;
                if (dem != i)
                {

                    for (int j = dem; j <= i; j++)
                    {
                        Button bt2 = new Button();
                        Image image;
                        if (dem < i)
                        {
                            dem++;
                            image = Image.FromFile(@"D:\1.Univer\Semester 7\Smart Application Software Development\PTPM\PTPM_T5_A204_QLQuanMiCay\SOURCE\PTPM_QLMiCay\CustomControl\Icon\table_full.png");
                            //bt2.Tag = j;
                        }
                        else
                            image = Image.FromFile(@"D:\1.Univer\Semester 7\Smart Application Software Development\PTPM\PTPM_T5_A204_QLQuanMiCay\SOURCE\PTPM_QLMiCay\CustomControl\Icon\table_empty.png");

                        bt2.Image = image;
                        bt2.ImageAlign = ContentAlignment.TopCenter;
                        bt2.TextAlign = ContentAlignment.BottomCenter;
                        bt2.FlatStyle = FlatStyle.Flat;
                        bt2.FlatAppearance.BorderSize = 0;
                        bt2.ForeColor = Color.Red;
                        bt2.Size = new Size(219, 178);
                        bt2.Text = "Bàn " + j;
                        bt2.Font = new Font("Arial", 12, FontStyle.Bold);
                        bt2.Tag = j;
                        tableLayoutPanel1.Controls.Add(bt2);
                        bt2.Click += bt_Click;

                    }
                }
                else
                {

                    Image image = Image.FromFile(@"D:\1.Univer\Semester 7\Smart Application Software Development\PTPM\PTPM_T5_A204_QLQuanMiCay\SOURCE\PTPM_QLMiCay\CustomControl\Icon\table_empty.png");
                    bt.Image = image;
                    bt.ImageAlign = ContentAlignment.TopCenter;
                    bt.TextAlign = ContentAlignment.BottomCenter;
                    bt.FlatStyle = FlatStyle.Flat;
                    bt.FlatAppearance.BorderSize = 0;
                    bt.ForeColor = Color.Red;
                    bt.Size = new Size(219, 178);
                    bt.Text = "Bàn " + i;
                    bt.Font = new Font("Arial", 12, FontStyle.Bold);
                    bt.Tag = i;
                    tableLayoutPanel1.Controls.Add(bt);

                }
                bt.Click += bt_Click;

            }
        }
        private void btnDSbanTrong_Click(object sender, EventArgs e)
        {
            createLoadBan();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            int soBan = (int)bt.Tag ;
            
            frmChonMon frm = new frmChonMon(soBan,taikhoan);
            frm.Show();
        }

        private void BanTrong_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            foreach (int i in b.loadBanHD())
            {
                Button bt = new Button();
                Image image = Image.FromFile(@"D:\1.Univer\Semester 7\Smart Application Software Development\PTPM\PTPM_T5_A204_QLQuanMiCay\SOURCE\PTPM_QLMiCay\CustomControl\Icon\table_empty.png");
                bt.Image = image;
                bt.ImageAlign = ContentAlignment.TopCenter;
                bt.TextAlign = ContentAlignment.BottomCenter;
                bt.FlatStyle = FlatStyle.Flat;
                bt.FlatAppearance.BorderSize = 0;
                bt.ForeColor = Color.Red;
                bt.Size = new Size(219, 178);
                bt.Text = "Bàn " + i;
                bt.Font = new Font("Arial", 12, FontStyle.Bold);
               
                tableLayoutPanel1.Controls.Add(bt);
            }
        }
    }
}
