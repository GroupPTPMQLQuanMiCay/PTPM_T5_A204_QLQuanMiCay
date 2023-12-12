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
using Bunifu.Framework.UI;


namespace FormControl.Forms
{
    public partial class frmChonMon : FormEntity
    {
       
        private TaiKhoan taikhoan = null;
        private int tableNumber;

        ThuatToan _thuatToan = new ThuatToan();

        public frmChonMon(int tableNumber)
        {
            InitializeComponent();
            this.tableNumber = tableNumber;
            txtBan.Text = this.tableNumber.ToString();
            createBtnAllMon();
            createBtnDanhMuc();

        }
        public frmChonMon(int tableNumber, TaiKhoan tk_nv)
        {
            InitializeComponent();
            taikhoan = tk_nv;
            this.tableNumber = tableNumber;
            txtBan.Text = this.tableNumber.ToString();
            createBtnAllMon();
            createBtnDanhMuc();

        }

        public int setTableNumber(int soBan)
        {
            return soBan;
        }
        public void createBtnMon(List<Mon> mons)
        {
            foreach (Mon i in mons)
            {
                Image image = Image.FromFile(@"D:\1.Univer\Semester 7\Smart Application Software Development\PTPM\PTPM_T5_A204_QLQuanMiCay\SOURCE\PTPM_QLMiCay\CustomControl\Images\"+i.M_IMG +"");
                BunifuTileButton button = new BunifuTileButton();
                button.Image = image;
                button.BackColor = Color.Transparent;
                button.Size = new Size(400, 250);
                button.LabelText = i.M_Ten + "\nGiá:" + i.M_Gia + " VNĐ";
                button.Font = new Font("Arial", 12, FontStyle.Bold);
                button.ForeColor = Color.Black;
                button.color = Color.Transparent;
                button.colorActive = Color.GhostWhite;
                button.Padding= new Padding(0,0,0,20);
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Tag = i;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += bt_Click;

            }
        }
        public void createBtnAllMon()
        {
            DAL_Mon mdal = new DAL_Mon();
            //List<Mon> l = mdal.LoadAllMon();
            flowLayoutPanel1.Controls.Clear();
            createBtnMon(mdal.LoadAllMon());
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
            createBtnMon(mdal.getMonByIDDM(id));
        }

        public void loadMonGoiY()
        {
            List<string> tenMons = new List<string>();
            foreach (DataGridViewRow item in dgvOD.Rows)
            {
                tenMons.Add(item.Cells[1].Value.ToString());
            }

            flowLayoutPanel1.Controls.Clear();
            List<Mon> monGoiY = _thuatToan.GetTop5MonGoiY(tenMons);
            createBtnMon(monGoiY);
        }

        void btdm_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Text == "Tất cả")
            {
                createBtnAllMon();
            }
            else if (clickedButton.Text == "Gợi ý")
            {
                loadMonGoiY();
            }
            else
            {
                int dmId = (int)clickedButton.Tag;
                loadMonByIDDM(dmId);
            }
            
        }

        //public void addODer()
        //{
        //    //DataTable monTable = new DataTable();
        //    //monTable.Columns.Add("Tên Món", typeof(string));
        //    //monTable.Columns.Add("Giá", typeof(string));
        //    //monTable.Columns.Add("Số Lượng", typeof(int));
        //    //dgvOD.DataSource = monTable;
        //    //Controls.Add(dgvOD);
        //}

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
       private void UpdateTotalPrice()
       {
           decimal total = 0;

           foreach (DataGridViewRow row in dgvOD.Rows)
           {
               if (!row.IsNewRow)
               {

                   if (row.Cells["Gia"].Value != null)
                   {
                       total += Convert.ToDecimal(row.Cells["Gia"].Value);
                   }
               }
           }

           txtThanhTien.Text = total.ToString();
       }
        private int currentOrderNumber = 1;
        void bt_Click(object sender, EventArgs e)
        {
            BunifuTileButton bt = sender as BunifuTileButton;
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
                    row.Tag = mon;
                    UpdateTotalPrice();
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
                UpdateTotalPrice();
            }
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            DAL_HoaDon dalHd = new DAL_HoaDon();    
            DAL_Order dalOr = new DAL_Order();
            //DataGridViewRow row = dgvOD.CurrentRow;
            HoaDon hd = dalHd.insert(taikhoan.TK_NhanVien,tableNumber);
            foreach(DataGridViewRow row in dgvOD.Rows)
            {

                string tenMon = row.Cells["Ten_Mon"].Value.ToString();
                int SoLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                int DonGia = int.Parse(row.Cells["DonGia"].Value.ToString());
                int Gia = int.Parse(row.Cells["Gia"].Value.ToString());
                string GhiChu = "";
                DateTime ThoiGian = DateTime.Now;
                dalOr.insertOrder(tenMon, hd.HD_Id, SoLuong, ThoiGian, DonGia);
               
            }    

            MessageBox.Show("Gọi món thành công~~");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int ttien = int.Parse(txtThanhTien.Text.ToString());
            DAL_HoaDon dalHd = new DAL_HoaDon();
            dalHd.PayHD(tableNumber, ttien);
            MessageBox.Show("Bàn "+tableNumber+" đã thanh toán thành công!");
        }

        private void frmChonMon_Load(object sender, EventArgs e)
        {
            DAL_HoaDon dalHd = new DAL_HoaDon();
            DAL_Order dalOr = new DAL_Order();
            HoaDon hd = dalHd.getLatestHD(tableNumber);

            if (hd == null)
            {
                dgvOD.Rows.Clear();
                return;
            }
            if (hd.HD_TrangThai == 0)
            {
                

                List<OrDer> or = dalOr.getOrderList(hd.HD_Id);
                for(int i = 0; i < or.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvOD);
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = or[i].M_Ten;
                    row.Cells[2].Value = or[i].O_Gia;
                    row.Cells[3].Value = or[i].O_SoLuong;
                    row.Cells[4].Value = or[i].O_Gia * or[i].O_SoLuong;
                    dgvOD.Rows.Add(row);
                    UpdateTotalPrice();
                }
                loadTableEmty();

            }
            else
            {
                dgvOD.Rows.Clear();
            }
             
        }

        public void loadTableEmty()
        {
            DAL_Ban dalBan = new DAL_Ban(); 

            List<int> banList = dalBan.loadBanHD(); 
            CboBanTrong.DataSource = banList;
            CboBanTrong.DisplayMember = "B_SoBan";

            
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            try
            {
                DAL_Order dalOR = new DAL_Order();
                DAL_HoaDon dalHD = new DAL_HoaDon();

                int newtable = int.Parse(CboBanTrong.SelectedValue.ToString());
                int oldtable = tableNumber;
                HoaDon hd_oldTable = dalHD.getLatestHD(oldtable);
                List<OrDer> order_oldTable = dalOR.getOrderList(hd_oldTable.HD_Id);


                //thêm cái hóa đơn cho bàn cần chuyển tới.
                HoaDon hd_newtable = dalHD.insert(taikhoan.TK_NhanVien, newtable);
                foreach (var or in order_oldTable)
                {
                    dalOR.insertOrder(or.M_Ten, hd_newtable.HD_Id, or.O_SoLuong, or.O_ThoiGian, or.O_DonGia);
                }

                //Xóa thoongg tin bàn củ
                foreach (var or in order_oldTable)
                {
                    dalOR.removeMon(hd_oldTable.HD_Id, or.M_Ten);

                }
                dalHD.removeHD(hd_oldTable.HD_Id);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
       
    }
}
