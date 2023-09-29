using DataHelper.DTO.NguyenLieu;
using DataHelper.Entity;
using System;
using System.Collections.Generic;
using System.Data;

namespace FormControl.Converter
{
    public class NguyenLieuConverter
    {
        public static NguyenLieu toNguyenLieuEntity(NguyenLieuDto dto)
        {
            NguyenLieu nlieu = new NguyenLieu();
            nlieu.ncc_Id(dto.nl_nccId);
            nlieu.nl_SoLuong(dto.nl_SoLuong);
            nlieu.nl_DonViTinh(dto.nl_DonViTinh());
            nlieu.nl_Ten(dto.nl_Ten());
            return nlieu;
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
