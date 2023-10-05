namespace FormControl.DTO.NhaCungCap
{
    public class NhaCungCapDto
    {
        private int NCC_Id;
        private string NCC_Ten;
        private string NCC_SDT;
        private string NCC_DiaChi;

        public NhaCungCapDto() { }

        public NhaCungCapDto(int NCC_Id, string NCC_Ten)
        {
            ncc_Id(NCC_Id);
            ncc_Ten(NCC_Ten);
        }

        public int ncc_Id() { return NCC_Id; }
        public void ncc_Id(int Id) { NCC_Id = Id; }
        public string ncc_Ten() { return NCC_Ten; }
        public void ncc_Ten(string ncc) { NCC_Ten = ncc; }
        public string ncc_SDT() { return NCC_SDT; }
        public void ncc_SDT(string sdt) { NCC_SDT = sdt; }
        public string ncc_DiaChi() { return NCC_DiaChi; }
        public void ncc_DiaChi(string diaChi) { NCC_DiaChi = diaChi; }
    }
}
