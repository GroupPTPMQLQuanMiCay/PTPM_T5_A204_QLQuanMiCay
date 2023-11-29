using System;

namespace Report.DTO
{
    public class PhieuDatDTO
    {
        private int pd_Id;
        private DateTime pd_Date;
        private string sentSupplierBy;

        public PhieuDatDTO(int pd_Id, DateTime pd_Date, string sentSupplierBy)
        {
            PD_Id = pd_Id;
            PD_Date = pd_Date;
            SentSupplierBy = sentSupplierBy;
        }

        public int PD_Id { get => pd_Id; set => pd_Id = value; }
        public DateTime PD_Date { get => pd_Date; set => pd_Date = value; }
        public string SentSupplierBy { get => sentSupplierBy; set => sentSupplierBy = value; }
    }
}
