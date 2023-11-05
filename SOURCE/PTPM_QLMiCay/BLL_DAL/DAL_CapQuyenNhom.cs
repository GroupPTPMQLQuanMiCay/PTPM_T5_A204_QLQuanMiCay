using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class DAL_CapQuyenNhom
    {
        QLQuanMiCayDataContext qmc = new QLQuanMiCayDataContext();
        DAL_Quyen dal_quyen = new DAL_Quyen();
        public DAL_CapQuyenNhom()
        {

        }

        public DataGridView load(DataGridView dgv, string NQID)
        {
            var manHinhs = qmc.ManHinhs.Select(t => t.MH_HienThi).ToList();

            for (int i = 0; i < manHinhs.Count; i++)
            {
                string manHinh = manHinhs[i];

                string quyen = qmc.CapQuyenNhoms
                    .Where(t => t.NQ_Id.Equals(NQID) && t.ManHinh.MH_HienThi.Equals(manHinh))
                    .Select(t => t.Quyen.DienGiai)
                    .FirstOrDefault();

                if (quyen == null)
                    quyen = "Không Có Quyền";

                dgv.Rows.Add(new object[] { manHinh, quyen });
            }

            return dgv;
        }

        
        public bool checkExist(string NQID, string MHID, string quyenID)
        {
            CapQuyenNhom cqn = qmc.CapQuyenNhoms.Where(
                t => t.NQ_Id.Equals(NQID) && t.MH_Id.Equals(MHID) && t.Quyen_Id.Equals(quyenID))
                .FirstOrDefault();
            if (cqn != null)
                return true;
            return false;
        }
        public bool checkDelete (string quyenID)
        {
            if (quyenID.Equals("1"))
                return true;
            return false;
        }

        public CapQuyenNhom getItemDelete(List<CapQuyenNhom> list, CapQuyenNhom check)
        {
            foreach (CapQuyenNhom item in list)
            {
                if (item.NQ_Id.Equals(check.NQ_Id) && item.MH_Id.Equals(check.MH_Id) && !item.Quyen_Id.Equals(check.Quyen_Id))
                    return item;
            }
            return null;
        }

        public bool addCapQuyenNhom(List<CapQuyenNhom> listNew)
        {
            try
            {
                List<CapQuyenNhom> list = layQuyenManHinh(listNew[0].NQ_Id);
                foreach (CapQuyenNhom item in listNew)
                {
                    if (checkDelete(item.Quyen_Id))
                    {
                        CapQuyenNhom delete = getItemDelete(list, item);
                        if (delete != null)
                            deleteCapQuyenNhom(delete.NQ_Id, delete.MH_Id, delete.Quyen_Id);
                    }
                    else if (!checkExist(item.NQ_Id, item.MH_Id, item.Quyen_Id))
                        addCapQuyenNhom(item.NQ_Id, item.MH_Id, item.Quyen_Id);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool addCapQuyenNhom(string NQID, string MHID, string quyenID)
        {
            try
            {
                qmc.CapQuyenNhoms.InsertOnSubmit(new CapQuyenNhom(){
                    NQ_Id = NQID,
                    MH_Id = MHID,
                    Quyen_Id = quyenID
                });
                qmc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCapQuyenNhom(string NQID, string MHID, string quyenID)
        {
            try
            {
                CapQuyenNhom cqn = qmc.CapQuyenNhoms.Where(
                t => t.NQ_Id.Equals(NQID) && t.MH_Id.Equals(MHID) && t.Quyen_Id.Equals(quyenID))
                .FirstOrDefault();
                qmc.CapQuyenNhoms.DeleteOnSubmit(cqn);
                qmc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<CapQuyenNhom> layQuyenManHinh(string NQID)
        {
            return qmc.CapQuyenNhoms.Where(t => t.NQ_Id.Equals(NQID)).Select(t => t).ToList();
        }

        public List<CapQuyenNhom> laySeletedQuyenManHinh(string NQID, DataGridView dgv)
        {
            List<CapQuyenNhom> list = new List<CapQuyenNhom>();
            foreach (DataGridViewRow r in dgv.Rows)
            {
                string manHinh = r.Cells[0].Value.ToString();
                string quyen = r.Cells[1].Value.ToString();

                CapQuyenNhom cpn = new CapQuyenNhom();
                cpn.NQ_Id = NQID;
                cpn.MH_Id = qmc.ManHinhs.Where(t => t.MH_HienThi.Equals(manHinh)).Select(t => t.MH_Id).FirstOrDefault();
                cpn.Quyen_Id = qmc.Quyens.Where(t => t.DienGiai.Equals(quyen)).Select(t => t.Quyen_Id).FirstOrDefault();

                list.Add(cpn);
            }
            return list;
        }

        public int getQuyenID(string NQID, string MHID)
        {
            string ID = qmc.CapQuyenNhoms.Where(
                t => t.NQ_Id.Equals(NQID) && t.MH_Id.Equals(MHID))
                .Select(t => t.Quyen_Id)
                .FirstOrDefault();

            int id = 0;
            if (ID != null)
                id = int.Parse(ID);
            return id;
        }
    }
}
