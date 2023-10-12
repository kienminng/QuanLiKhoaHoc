using QuanLiKhoaHoc.Entity;

namespace QuanLiKhoaHoc.Service.impl;

public class NgayHocService : INgayHocService
{
    private readonly AppDBContext DbContext;

    public NgayHocService(AppDBContext dbContext)
    {
        DbContext = new AppDBContext();
    }

    public string AddNew(NgayHoc ngayHoc)
    {
        try
        {
            DbContext.NgayHocs.Add(ngayHoc);
            DbContext.SaveChanges();
            return "add success";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    public string Update(NgayHoc ngayHoc)
    {
        try
        {
            DbContext.NgayHocs.Update(ngayHoc);
            DbContext.SaveChanges();
            return "update success";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public IEnumerable<NgayHoc> GetAll()
    {
        return DbContext.NgayHocs.ToList();
    }

    public string Delete(int id)
    {
        NgayHoc ngayHoc = FindById(id);
        DbContext.NgayHocs.Remove(ngayHoc);
        return "delete success";
    }

    public NgayHoc? FindById(int id)
    {
        return DbContext.NgayHocs.Find(id);
    }
}