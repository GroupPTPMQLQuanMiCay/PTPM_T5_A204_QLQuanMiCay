using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace BLL_DAL
{
    public class DAL_NhaCungCap
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();
        private static int INVALID_PARAMETER = -1;
        private static int ERROR_ON_EXECUTION = -2;
        private static int SUCCESS = 1;

        public DAL_NhaCungCap() { }

        public List<NhaCungCap> getAllSupplierFull()
        {
            return _context.NhaCungCaps.Where(ncc => ncc.isDeleted == false)
                                       .ToList();
        }

        public object getAllSupplier()
        {
            return _context.NhaCungCaps.Where(ncc => ncc.isDeleted == false)
                                       .Select(ncc => new {ncc.NCC_Id, ncc.NCC_Ten, ncc.NCC_DiaChi, ncc.NCC_SDT})
                                       .ToList();
        }

        public object getSupplierByName(string name)
        {
            return _context.NhaCungCaps.Where(ncc => ncc.isDeleted == false && ncc.NCC_Ten.Contains(name))
                                       .Select(ncc => new { ncc.NCC_Id, ncc.NCC_Ten, ncc.NCC_DiaChi, ncc.NCC_SDT })
                                       .ToList();
        }

        public int add(string creater, string ten, string diaChi, string sdt)
        {
            if(string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(sdt))
            {
                return INVALID_PARAMETER;
            }

            try
            {
                NhaCungCap supplier = new NhaCungCap();
                supplier.NCC_Ten = ten;
                supplier.NCC_DiaChi = diaChi;
                supplier.NCC_SDT = sdt;
                supplier.createdBy = creater;
                supplier.createdAt = System.DateTime.Now;
                supplier.updatedBy = creater;
                supplier.updatedAt = System.DateTime.Now;
                supplier.isDeleted = false;
                _context.NhaCungCaps.InsertOnSubmit(supplier);
                _context.SubmitChanges();
                return SUCCESS;
            } catch
            {
                return INVALID_PARAMETER;
            }
        }

        public int update(string updater, string id, string ten, string diaChi, string sdt)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diaChi) 
                                                                            || string.IsNullOrEmpty(sdt))
            {
                return INVALID_PARAMETER;
            }

            try
            {
                int supplierID = int.Parse(id);
                var supplier = _context.NhaCungCaps.Where(sup => sup.NCC_Id == supplierID && sup.isDeleted == false)
                                                   .FirstOrDefault();
                if(supplier != null)
                {
                    supplier.NCC_Ten = ten;
                    supplier.NCC_DiaChi = diaChi;
                    supplier.NCC_SDT = sdt;
                    supplier.updatedBy = updater;
                    supplier.updatedAt = System.DateTime.Now;
                    supplier.isDeleted = false;
                    _context.SubmitChanges();
                    return SUCCESS;
                } else
                {
                    return ERROR_ON_EXECUTION;
                }
            }
            catch
            {
                return INVALID_PARAMETER;
            }
        }

        public int delete(string updater, string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return INVALID_PARAMETER;
            }

            try
            {
                int supplierID = int.Parse(id);
                var supplier = _context.NhaCungCaps.Where(sup => sup.NCC_Id == supplierID && sup.isDeleted == false)
                                                   .FirstOrDefault();
                if (supplier != null)
                {
                    supplier.updatedBy = updater;
                    supplier.updatedAt = System.DateTime.Now;
                    supplier.isDeleted = true;
                    _context.SubmitChanges();
                    return SUCCESS;
                }
                else
                {
                    return ERROR_ON_EXECUTION;
                }
            }
            catch
            {
                return INVALID_PARAMETER;
            }
        }
    }
}
