using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class DAL_NhomQuyen_NguoiDung
    {
        QLQuanMiCayDataContext qmc = new QLQuanMiCayDataContext();

        public DAL_NhomQuyen_NguoiDung()
        {
        }

        public DataGridView load(DataGridView dgv, string NGID)
        {
            DAL_NhomQuyen dal_nq = new DAL_NhomQuyen();
            List<NhomQuyen> allNQ = (List<NhomQuyen>)dal_nq.loadNhomQuyen();
            List<string> nq = layNhomQuyenTheoNguoiDung(NGID);
            foreach(NhomQuyen item in allNQ)
            {
                bool check = false;
                if (nq.Contains(item.NQ_Id))
                    check = true;
                var r = new object[] { item.NQ_HienThi, check };
                dgv.Rows.Add(r);
            }
            return dgv;
        }

        public List<string> layNhomQuyenTheoNguoiDung(string NGID)
        {
            return qmc.NhomQuyen_NguoiDungs.Where(t => t.NG_Id.Equals(NGID)).Select(t => t.NQ_Id).ToList();
        }

        public bool checkExist(string NGID, string NQID)
        {
            NhomQuyen_NguoiDung nq_nd = qmc.NhomQuyen_NguoiDungs.Where(
                t => t.NG_Id.Equals(NGID) && t.NQ_Id.Equals(NQID))
                .FirstOrDefault();
            if (nq_nd != null)
                return true;
            return false;
        }
        public bool addNhomQuyen_NguoiDung(string NGID, List<string> nhomQuyenIDs)
        {
            try
            {
                List<string> deletes = qmc.NhomQuyen_NguoiDungs.Where(
                    t => t.NG_Id.Equals(NGID))
                    .Select(t => t.NQ_Id)
                    .ToList();
                foreach (string delete in deletes)
                {
                    if (!nhomQuyenIDs.Contains(delete))
                        deleteNhomQuyen_NguoiDung(NGID, delete);
                }
            }
            catch
            {
                return false;
            }

            try
            {
                foreach (string quyenID in nhomQuyenIDs)
                {
                    if (!checkExist(NGID, quyenID))
                        addNhomQuyen_NguoiDung(NGID, quyenID);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool addNhomQuyen_NguoiDung(string NGID, string NQID)
        {
            try
            {
                qmc.NhomQuyen_NguoiDungs.InsertOnSubmit(new NhomQuyen_NguoiDung()
                {
                    NG_Id = NGID,
                    NQ_Id = NQID
                });
                qmc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteNhomQuyen_NguoiDung(string NGID, string NQID)
        {
            try
            {
                NhomQuyen_NguoiDung nq_nd = qmc.NhomQuyen_NguoiDungs.Where(
                t => t.NG_Id.Equals(NGID) && t.NQ_Id.Equals(NQID))
                .FirstOrDefault();
                qmc.NhomQuyen_NguoiDungs.DeleteOnSubmit(nq_nd);
                qmc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
