using System.ComponentModel.DataAnnotations;

namespace QuanLiKhoaHoc.Entity;

public class KhoaHoc
{
    public int KhoaHocId { get; private set; }
    [MaxLength(10)]
    public string TenKhoaHoc { get; set; }
    public string MoTa { get; set; }
    [MaxLength(10000000)]
    public double HocPhi { get; set; }
    public DateTime NgayBatDau { get; set; }
    public DateTime NgayKetThuc { get; set; }
    
    [MaxLength(15)]
    public HashSet<NgayHoc> DanhSachNgayHoc { get; set; } 
    public HashSet<HocVien> DanhSachHocVien { get; set; }

    public KhoaHoc(int khoaHocId, string tenKhoaHoc, string moTa, double hocPhi, DateTime ngayBatDau, DateTime ngayKetThuc)
    {
        KhoaHocId = khoaHocId;
        TenKhoaHoc = tenKhoaHoc;
        MoTa = moTa;
        HocPhi = hocPhi;
        NgayBatDau = ngayBatDau;
        NgayKetThuc = ngayKetThuc;
    }

    public KhoaHoc(string tenKhoaHoc, string moTa, double hocPhi, DateTime ngayBatDau, DateTime ngayKetThuc)
    {
        TenKhoaHoc = tenKhoaHoc;
        MoTa = moTa;
        HocPhi = hocPhi;
        NgayBatDau = ngayBatDau;
        NgayKetThuc = ngayKetThuc;
    }
    
    
}