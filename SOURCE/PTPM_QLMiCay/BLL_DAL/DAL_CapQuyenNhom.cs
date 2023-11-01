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

        public DAL_CapQuyenNhom()
        {

        }

        public DataGridView load(DataGridView dgv, string NQID)
        {
            var tableNames = qmc.ExecuteQuery<string>
                ("select name from sys.tables where name != 'sysdiagrams' and name != '__MigrationHistory'")
                .ToList();

            foreach (var tableName in tableNames)
            {
                string name = string.Empty;
                bool select, insert, delete, update;
                select = insert = delete = update = false;

                List<string> quyen = qmc.CapQuyenNhoms.Where(
                    t => t.NQ_Id.Equals(NQID) && t.Quyen.DienGiai.Contains(tableName))
                    .Select(t => t.Quyen.DienGiai)
                    .ToList();
                foreach(string s in quyen)
                {
                    if (s.Contains("select"))
                        select = true;
                    if (s.Contains("insert"))
                        insert = true;
                    if (s.Contains("delete"))
                        delete = true;
                    if (s.Contains("update"))
                        update = true;
                }
                var r = new object[] { tableName, select, insert, delete, update };
                dgv.Rows.Add(r);
            }
            return dgv;
        }

        public bool checkExist(string NQID, string quyenID)
        {
            CapQuyenNhom cqn = qmc.CapQuyenNhoms.Where(
                t => t.NQ_Id.Equals(NQID) && t.Quyen_Id.Equals(quyenID))
                .FirstOrDefault();
            if (cqn != null)
                return true;
            return false;
        }
        public bool addCapQuyenNhom(string NQID, List<string> quyenIDs)
        {
            try
            {
                List<string> deletes = qmc.CapQuyenNhoms.Where(
                    t => t.NQ_Id.Equals(NQID))
                    .Select(t => t.Quyen_Id)
                    .ToList();
                foreach(string delete in deletes)
                {
                    if (!quyenIDs.Contains(delete))
                        deleteCapQuyenNhom(NQID, delete);
                }
            }
            catch
            {
                return false;
            }

            try
            {
                foreach(string quyenID in quyenIDs)
                {
                    if (!checkExist(NQID, quyenID))
                        addCapQuyenNhom(NQID, quyenID);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool addCapQuyenNhom(string NQID, string quyenID)
        {
            try
            {
                qmc.CapQuyenNhoms.InsertOnSubmit(new CapQuyenNhom(){
                    NQ_Id = NQID,
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

        public bool deleteCapQuyenNhom(string NQID, string quyenID)
        {
            try
            {
                CapQuyenNhom cqn = qmc.CapQuyenNhoms.Where(
                t => t.NQ_Id.Equals(NQID) && t.Quyen_Id.Equals(quyenID))
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
    }
}
