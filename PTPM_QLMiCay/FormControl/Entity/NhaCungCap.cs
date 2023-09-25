﻿using DataHelper.Entity;

namespace FormControl.Entity
{
    public class NhaCungCap : BaseEntity
    {
        private string NCC_Ten;
        private string NCC_SDT;
        private string NCC_DiaChi;

        public string ncc_Ten() { return NCC_Ten; }
        public void ncc_Ten(string ncc) {  NCC_Ten = ncc; }
        public string ncc_SDT() { return NCC_SDT; }
        public void ncc_SDT(string sdt) { NCC_SDT = sdt; }
        public string ncc_DiaChi() { return NCC_DiaChi; }
        public void ncc_DiaChi(string diaChi) { NCC_DiaChi = diaChi; }
    }
}
