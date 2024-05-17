using System;

namespace PBL3.Models
{
    public class Khach
    {
        public int ID_khach { get; set; }
        public string Ma_goi_tap { get; set; }
        public string Ma_HLV { get; set; }
        public string Ho_ten { get; set; }
        public DateTime Ngay_sinh { get; set; }
        public string Gioi_tinh { get; set; }
        public string? So_dien_thoai { get; set; }
        public string Email { get; set; }
        public DateTime? Ngay_tham_gia { get; set; }
        public string Dia_chi { get; set; }
        public static bool cmpID(Khach s1, Khach s2)
        {
            if (s1.ID_khach > s2.ID_khach) return true;
            return false;
        }
        public static bool CompareByMaGoiTap(Khach s1, Khach s2)
        {
            return string.Compare(s1.Ma_goi_tap, s2.Ma_goi_tap, StringComparison.Ordinal) > 0;
        }
        public static bool CompareByMaHLV(Khach s1, Khach s2)
        {
            return string.Compare(s1.Ma_HLV, s2.Ma_HLV, StringComparison.Ordinal) > 0;
        }
        public static bool CompareByHoTen(Khach s1, Khach s2)
        {
            return string.Compare(s1.Ho_ten, s2.Ho_ten, StringComparison.Ordinal) > 0;
        }
        public static bool CompareByNgaySinh(Khach s1, Khach s2)
        {
            return s1.Ngay_sinh > s2.Ngay_sinh;
        }
        public static bool CompareByGioiTinh(Khach s1, Khach s2)
        {
            return string.Compare(s1.Gioi_tinh, s2.Gioi_tinh, StringComparison.Ordinal) > 0;
        }
        public static bool CompareBySoDienThoai(Khach s1, Khach s2)
        {
            return string.Compare(s1.So_dien_thoai, s2.So_dien_thoai, StringComparison.Ordinal) > 0;
        }
        public static bool CompareByNgayThamGia(Khach s1, Khach s2)
        {
            if (!s1.Ngay_tham_gia.HasValue && !s2.Ngay_tham_gia.HasValue) return false;
            if (!s1.Ngay_tham_gia.HasValue) return false;
            if (!s2.Ngay_tham_gia.HasValue) return true;
            return s1.Ngay_tham_gia.Value > s2.Ngay_tham_gia.Value;
        }
        public static bool CompareByDiaChi(Khach s1, Khach s2)
        {
            return string.Compare(s1.Dia_chi, s2.Dia_chi, StringComparison.Ordinal) > 0;
        }



    }
}
