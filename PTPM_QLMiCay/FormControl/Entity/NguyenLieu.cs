namespace DataHelper.Entity
{
    public class NguyenLieu : BaseEntity
    {
        private string NL_Ten;
        private string NL_DonViTinh;
        private int NL_SoLuong;
        private int NCC_Id;

        public string nl_Ten()
        {
            return NL_Ten;
        }
        public void nl_Ten(string ten)
        {
            NL_Ten = ten;
        }
        public string nl_DonViTinh()
        {
            return NL_DonViTinh;
        }
        public void nl_DonViTinh(string dvt)
        {
            NL_DonViTinh = dvt;
        }
        public int nl_SoLuong()
        {
            return NL_SoLuong;
        }
        public void nl_SoLuong(int soluong)
        {
            NL_SoLuong = soluong;
        }
        public int ncc_Id()
        {
            return NCC_Id;
        }
        public void ncc_Id(int nccId)
        {
            NCC_Id = nccId;
        }
    }
}
