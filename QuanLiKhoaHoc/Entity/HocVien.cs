using System.ComponentModel.DataAnnotations;

namespace QuanLiKhoaHoc.Entity;

public class HocVien
{
    public int HocVienId { get; private set; }
    [MaxLength(20)]
    [MinLength(2)]
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }
    public string QueQuan { get; set; }
    public string DiaChi { get; set; }
    public string SoDienThoai { get; set; }
    public int KhoaHocId { get; set; }
    public KhoaHoc KhoaHoc { get; set; }


    public HocVien(string hoTen, DateTime ngaySinh, string queQuan, string diaChi, string soDienThoai, int khoaHocId)
    {
        HoTen = hoTen;
        NgaySinh = ngaySinh;
        QueQuan = queQuan;
        DiaChi = diaChi;
        SoDienThoai = soDienThoai;
        KhoaHocId = khoaHocId;
    }

    public HocVien(int hocVienId, string hoTen, DateTime ngaySinh, string queQuan, string diaChi, string soDienThoai, int khoaHocId)
    {
        HocVienId = hocVienId;
        HoTen = hoTen;
        NgaySinh = ngaySinh;
        QueQuan = queQuan;
        DiaChi = diaChi;
        SoDienThoai = soDienThoai;
        KhoaHocId = khoaHocId;
    }
}