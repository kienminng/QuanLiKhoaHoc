namespace QuanLiKhoaHoc.Entity.DTO;

public class TongTien
{
    public int Thang { get; set; }
    public int Nam { get; set; }
    public double Money { get; set; }

    public TongTien(int thang, int nam, double money)
    {
        Thang = thang;
        Nam = nam;
        Money = money;
    }
}