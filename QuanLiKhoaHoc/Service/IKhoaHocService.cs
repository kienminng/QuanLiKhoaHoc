using Microsoft.EntityFrameworkCore.ChangeTracking;
using QuanLiKhoaHoc.Entity;

namespace QuanLiKhoaHoc.Service;

public interface IKhoaHocService
{
    string AddNew(KhoaHoc khoaHoc);

    string Update(KhoaHoc khoaHoc);

    IEnumerable<KhoaHoc> GetAll();

    string Delete(int id);

    KhoaHoc? FindById(int id);
}