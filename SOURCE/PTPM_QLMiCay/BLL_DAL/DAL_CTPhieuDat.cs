namespace BLL_DAL
{
    public class DAL_CTPhieuDat
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();
        private static int INVALID_PARAMETER = -1;
        private static int ERROR_ON_EXECUTION = -2;
        private static int SUCCESS = 1;
        public DAL_CTPhieuDat() { }

        public int insert(int pdatId, int nlId, int soLuong, double gia)
        {
            CTPhieuDat ctpd = new CTPhieuDat();
            ctpd.PD_Id = pdatId;
            ctpd.NL_Id = nlId;
            ctpd.soluong = soLuong;
            ctpd.NL_Gia = gia;
            try
            {
                _context.CTPhieuDats.InsertOnSubmit(ctpd);
                _context.SubmitChanges();
                return SUCCESS;
            } catch
            {
                return ERROR_ON_EXECUTION;
            }
        }
    }
}
