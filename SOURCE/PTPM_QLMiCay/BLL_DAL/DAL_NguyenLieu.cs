using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL_DAL
{
    public class DAL_NguyenLieu
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public DAL_NguyenLieu() { }

        public object getAllIncredient()
        {
            return _context.NguyenLieus.Where(nl => nl.isDeleted == false).Select(i => new { i.NL_Id, i.NL_Ten, i.NL_DonViTinh, i.NL_SoLuong })
                            .ToList();
        }

        public NguyenLieu getIncredientById(int Id)
        {
            return _context.NguyenLieus.Where(nl => nl.NL_Id == Id).FirstOrDefault();
        }

        public object getIncredientBySupplier(int Id)
        {
            return _context.NguyenLieus.Where(nl => nl.isDeleted == false).Where(i => i.NCC_Id == Id)
                            .Select(i => new {i.NL_Id, i.NL_Ten, i.NL_DonViTinh, i.NL_SoLuong})
                            .ToList();
        }

        public object getIncredientName(string incredientName)
        {
            return _context.NguyenLieus.Where(i => i.NL_Ten.Contains(incredientName) && i.isDeleted == false)
                            .Select(i => new { i.NL_Id, i.NL_Ten, i.NL_DonViTinh, i.NL_SoLuong })
                            .ToList();
        }

        public List<string> getAllDonViTinh()
        {
            return _context.NguyenLieus.Select(nl => nl.NL_DonViTinh).Distinct().ToList();
        }

        public bool insert(string ten, string donViTinh, string soLuong, string nccId, string nguoiDung)
        {
            try
            {
                int sl = int.Parse(soLuong);
                int nccID = int.Parse(nccId);
                NguyenLieu nl = new NguyenLieu();
                nl.NL_Ten = ten;
                nl.NL_DonViTinh = donViTinh;
                nl.NL_SoLuong = sl;
                nl.NCC_Id = nccID;
                nl.createdBy = nguoiDung;
                nl.createdAt = DateTime.Now;
                nl.updatedBy = nguoiDung;
                nl.updatedAt = DateTime.Now;
                _context.NguyenLieus.InsertOnSubmit(nl);
                _context.SubmitChanges();
                return true;
            } catch
            {
                return false;
            }
        }

        public bool update(string nl_id, string ten, string donViTinh, string soLuong, string nccId, string nguoiDung)
        {
            try
            {
                int nl_ID = int.Parse(nl_id);
                int sl = int.Parse(soLuong);
                int nccID = int.Parse(nccId);
                NguyenLieu nlieu = _context.NguyenLieus.Where(nl => nl.NL_Id == nl_ID).FirstOrDefault();
                if(nlieu != null)
                {
                    nlieu.NL_Ten = ten;
                    nlieu.NL_DonViTinh= donViTinh;
                    nlieu.NL_SoLuong= sl;
                    nlieu.NCC_Id = nccID;
                    nlieu.updatedBy = nguoiDung;
                    nlieu.updatedAt = DateTime.Now;
                    _context.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool delete(string nl_Id, string nguoiDung)
        {
            try
            {
                int nl_ID = int.Parse(nl_Id);
                NguyenLieu nlieu = _context.NguyenLieus.Where(nl => nl.NL_Id == nl_ID).FirstOrDefault();
                if (nlieu != null)
                {
                    nlieu.updatedBy = nguoiDung;
                    nlieu.updatedAt = DateTime.Now;
                    nlieu.isDeleted = true;
                    _context.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
