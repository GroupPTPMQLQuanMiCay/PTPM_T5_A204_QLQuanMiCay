using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControl.FormCustom;
using BLL_DAL;
using CustomControl.ControlCustom;
using Microsoft.VisualBasic;

namespace FormControl.Forms
{
    public partial class frmChonMon : FormEntity
    {
        private Mon monCurrent = null;
        public frmChonMon()
        {
            InitializeComponent();
            createBtnAllMon();
            createBtnDanhMuc();
        }

        public void createBtnAllMon()
        {
            DAL_Mon mdal = new DAL_Mon();
            //List<Mon> l = mdal.LoadAllMon();
            flowLayoutPanel1.Controls.Clear();
            foreach (Mon i in mdal.LoadAllMon())
            {
                Button bt = new Button();
                Image image = Image.FromFile(@"D:\1.Univer\Semester 7\Smart Application Software Development\PTPM\PTPM_T5_A204_QLQuanMiCay\SOURCE\PTPM_QLMiCay\CustomControl\Images\" + i.M_IMG + "");
                bt.BackgroundImage = image;
                bt.ImageAlign = ContentAlignment.TopCenter;
                bt.TextAlign = ContentAlignment.BottomCenter;
                bt.FlatStyle = FlatStyle.Flat;
                bt.FlatAppearance.BorderSize = 0;
                bt.Size = new Size(219, 178);
                bt.Text =  i.M_Ten + "\nGiá:" + i.M_Gia+" VNĐ";
                bt.Font = new Font("Arial", 12, FontStyle.Bold);
                bt.BackgroundImageLayout = ImageLayout.Stretch;
                bt.Tag = i;
                flowLayoutPanel1.Controls.Add(bt);
                bt.Click += bt_Click;
            }
            
        }
        public void createBtnDanhMuc()
        {
            DAL_DanhMuc dmdal = new DAL_DanhMuc();
            fpnelTop.Controls.Clear();
            Button btALL = new Button();
            btALL.Text = "Tất cả";
            btALL.Size = new Size(154, 27);
            btALL.Font = new Font("Arial", 12, FontStyle.Bold);
            fpnelTop.Controls.Add(btALL);
            btALL.Click += btdm_Click;
            foreach (DanhMuc i in dmdal.LoadAllDM())
            {
                Button btdm = new Button();
                btdm.Size = new Size(154, 27);
                btdm.Text = i.DM_Ten;
                btdm.Font = new Font("Arial", 11, FontStyle.Bold);
                btdm.BackgroundImageLayout = ImageLayout.Stretch;
                fpnelTop.Controls.Add(btdm);
                btdm.Tag = i.DM_Id;
                btdm.Click += btdm_Click;
               
            }
            Button btGoiY = new Button();
            btGoiY.Text = "Gợi ý";
            btGoiY.Size = new Size(154, 27);
            btGoiY.Font = new Font("Arial", 12, FontStyle.Bold);
            fpnelTop.Controls.Add(btGoiY);
            btGoiY.Click += btdm_Click;

        }
        public void loadMonByIDDM(int id)
        {
            DAL_Mon mdal = new DAL_Mon();
            flowLayoutPanel1.Controls.Clear();
            foreach (Mon i in mdal.getMonByIDDM(id))
            {
                Button bt = new Button();
                Image image = Image.FromFile(@"D:\1.Univer\Semester 7\Smart Application Software Development\PTPM\PTPM_T5_A204_QLQuanMiCay\SOURCE\PTPM_QLMiCay\CustomControl\Images\" + i.M_IMG + "");
                bt.BackgroundImage = image;
                bt.ImageAlign = ContentAlignment.TopCenter;
                bt.TextAlign = ContentAlignment.BottomCenter;
                bt.FlatStyle = FlatStyle.Flat;
                bt.FlatAppearance.BorderSize = 0;
                bt.Size = new Size(219, 178);
                bt.Text = i.M_Ten + "\nGiá:" + i.M_Gia + " VNĐ";
                bt.Font = new Font("Arial", 12, FontStyle.Bold);
                bt.BackgroundImageLayout = ImageLayout.Stretch;
                flowLayoutPanel1.Controls.Add(bt);
                bt.Click += bt_Click;

            }
        }

        void btdm_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Text == "Tất cả")
            {
                createBtnAllMon();
            }
            else
            {
                int dmId = (int)clickedButton.Tag;
                loadMonByIDDM(dmId);
            }
            
        }

        public void addODer()
        {
            //DataTable monTable = new DataTable();
            //monTable.Columns.Add("Tên Món", typeof(string));
            //monTable.Columns.Add("Giá", typeof(string));
            //monTable.Columns.Add("Số Lượng", typeof(int));
            //dgvOD.DataSource = monTable;
            //Controls.Add(dgvOD);
        }

       private bool KiemTraTonTaiName(string name)
        {
            
            return dgvOD.Rows.Cast<DataGridViewRow>().Any(row =>
            {
                if (!row.IsNewRow)
                {
                    string nameCuaDong = row.Cells["Ten_Mon"].Value.ToString();
                    return string.Equals(name, nameCuaDong, StringComparison.OrdinalIgnoreCase);
                }
                return false;
            });
        }
        private int currentOrderNumber = 1;
        void bt_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt != null)
            {
                Mon mon = bt.Tag as Mon;
                if (KiemTraTonTaiName(mon.M_Ten) == false)
                {
                    
                    int rowIndex = dgvOD.Rows.Add();
                    
                    DataGridViewRow row = dgvOD.Rows[rowIndex];
                    row.Cells["STT_Mon"].Value = currentOrderNumber;
                    currentOrderNumber++;
                    row.Cells["Ten_Mon"].Value = mon.M_Ten.ToString();
                    row.Cells["DonGia"].Value = mon.M_Gia.ToString();
                    row.Cells["SoLuong"].Value = 1;
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    row.Cells["Gia"].Value = donGia * soLuong;

                    dgvOD.Refresh();
                }
 
            }

        }

        private void dgvOD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOD.Columns["SoLuong"].Index)
            {
                DataGridViewRow row = dgvOD.Rows[e.RowIndex];
                decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                row.Cells["Gia"].Value = donGia * soLuong;
            }
        }
    }
}
