using System;

namespace PBL3.Models
{
    public class Hoa_don
    {
        public string Ma_hoa_don { get; set; }
        public string Ma_goi_tap { get; set; }
        public string Ma_le_tan { get; set; }
        public DateTime Ngay_xuat_hoa_don { get; set; }
        public string Ten_khach_hang { get; set; }
        public string Ten_goi_tap { get; set; }
        public DateTime Thoi_han { get; set; }
        public string? Ten_HLV { get; set; }
        public float Thanh_tien { get; set; }
        
        public void UpdateThoiHan()
        {
            switch (Ten_goi_tap)
            {
                case "01 tháng":
                    Thoi_han = Ngay_xuat_hoa_don.AddMonths(1);
                    break;
                case "03 tháng":
                    Thoi_han = Ngay_xuat_hoa_don.AddMonths(3);
                    break;
                case "06 tháng":
                    Thoi_han = Ngay_xuat_hoa_don.AddMonths(6);
                    break;
                case "12 tháng":
                    Thoi_han = Ngay_xuat_hoa_don.AddMonths(12);
                    break;
                case "01 Buổi":
                    Thoi_han = Ngay_xuat_hoa_don;
                    break;
                default:
                    Thoi_han = Ngay_xuat_hoa_don;
                    break;
            }
        }
    }
    
}

