using DataHelper.DTO.NguyenLieu;
using DataHelper.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormControl.Converter
{
    public class NguyenLieuConverter
    {
        public static List<NguyenLieu> toListNguyenLieuEntity(DataTable dt)
        {
            List<NguyenLieu> listNguyenLieu = new List<NguyenLieu>();
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    NguyenLieu nl = new NguyenLieu();
                    nl.ID(int.Parse(row["NL_Id"].ToString()));
                    nl.nl_Ten(row["NL_Ten"].ToString());
                    nl.nl_DonViTinh(row["NL_DonViTinh"].ToString());
                    nl.nl_SoLuong(int.Parse(row["NL_SoLuong"].ToString()));
                    nl.ncc_Id(int.Parse(row["NCC_Id"].ToString()));
                    listNguyenLieu.Add(nl);
                }
                return listNguyenLieu;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<NguyenLieuDto> toListNguyenLieuDto(DataTable dt)
        {
            List<NguyenLieuDto> listNguyenLieu = new List<NguyenLieuDto>();
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    NguyenLieuDto nl = new NguyenLieuDto();
                    nl.nl_Id(int.Parse(row["NL_Id"].ToString()));
                    nl.nl_Ten(row["NL_Ten"].ToString());
                    nl.nl_DonViTinh(row["NL_DonViTinh"].ToString());
                    nl.nl_Gia(double.Parse(row["NL_Gia"].ToString()));
                    listNguyenLieu.Add(nl);
                }
                return listNguyenLieu;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
