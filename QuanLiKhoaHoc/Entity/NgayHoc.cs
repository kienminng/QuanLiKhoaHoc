namespace QuanLiKhoaHoc.Entity;

public class NgayHoc
{
    public int NgayHocId { get; private set; }
    public string NoiDung { get; set; }
    public string GhiChu { get; set; }
    
    public int KhoaHocId { get; set; }
    public KhoaHoc KhoaHoc;

    public NgayHoc(int ngayHocId, string noiDung, string ghiChu, int khoaHocId)
    {
        NgayHocId = ngayHocId;
        NoiDung = noiDung;
        GhiChu = ghiChu;
        KhoaHocId = khoaHocId;
    }

    public NgayHoc(string noiDung, string ghiChu, int khoaHocId)
    {
        NoiDung = noiDung;
        GhiChu = ghiChu;
        KhoaHocId = khoaHocId;
    }
}