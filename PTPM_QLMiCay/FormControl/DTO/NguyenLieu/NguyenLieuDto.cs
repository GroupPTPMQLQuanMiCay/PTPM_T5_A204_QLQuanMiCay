namespace DataHelper.DTO.NguyenLieu
{
    public class NguyenLieuDto
    {
        private int NL_Id;
        private string NL_Ten { get; set;}
        private string NL_Donvitinh { get; set;}
        private double NL_Gia { get; set; }

        public int nl_Id() { return NL_Id; }
        public void nl_Id(int Id) { NL_Id = Id; }
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
            return NL_Donvitinh;
        }
        public void nl_DonViTinh(string dvt)
        {
            NL_Donvitinh = dvt;
        }
        public double nl_Gia()
        {
            return NL_Gia;
        }
        public void nl_Gia(double gia)
        {
            NL_Gia = gia;
        }
    }
}
