using Microsoft.EntityFrameworkCore.ChangeTracking;
using QuanLiKhoaHoc.Entity;

namespace QuanLiKhoaHoc.Service;

public interface IHocVienService
{
    string AddNew(HocVien hocVien);

    string UpdateHv(HocVien hocVien);

    IEnumerable<HocVien> GetAll();

    void Delete(int id);

    HocVien? FindById(int id);
}