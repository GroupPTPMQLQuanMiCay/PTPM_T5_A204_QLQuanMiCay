using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.DTO
{
    public class CTPhieuDatDTO
    {
        private string nl_name;
        private string nl_dvt;
        private int nl_sl;
        private long nl_donGia;
        private string _stt;
        private long nl_thanhTien;

        public string STT
        {
            get { return _stt; }
            set { _stt = value; }
        }

        public CTPhieuDatDTO(string nl_name, string nl_dvt,  int nl_sl, long nl_donGia)
        {
            Nl_name = nl_name;
            Nl_dvt = nl_dvt;
            Nl_sl = nl_sl;
            Nl_donGia = nl_donGia;
        }

        public string Nl_name { get => nl_name; set => nl_name = value; }
        public string Nl_dvt { get => nl_dvt; set => nl_dvt = value; }
        public int Nl_sl { get => nl_sl; set => nl_sl = value; }
        public long Nl_donGia { get => nl_donGia; set => nl_donGia = value; }
        public long Nl_thanhTien { get => nl_thanhTien; set => nl_thanhTien = value; }
    }
}
