using Microsoft.EntityFrameworkCore.ChangeTracking;
using QuanLiKhoaHoc.Entity;

namespace QuanLiKhoaHoc.Service;

public interface INgayHocService
{
    string AddNew(NgayHoc ngayHoc);

    string Update(NgayHoc ngayHoc);

    IEnumerable<NgayHoc> GetAll();

    string Delete(int id);

    NgayHoc? FindById(int id);
}