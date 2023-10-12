using Microsoft.EntityFrameworkCore.ChangeTracking;
using QuanLiKhoaHoc.Entity;

namespace QuanLiKhoaHoc.Service.impl;

public class HocVienService : IHocVienService
{
    private AppDBContext DbContext;

    public HocVienService(AppDBContext dbContext)
    {
        DbContext = new AppDBContext();
    }

    public string AddNew(HocVien hocVien)
    {
        try
        {
            DbContext.HocViens.Add(hocVien);
            DbContext.SaveChanges();
            return "add succes";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return "add false";
        }
    }

    public string UpdateHv(HocVien hocVien)
    {
         DbContext.HocViens.Update(hocVien);
         DbContext.SaveChanges();
         return "update success";
    }

    public IEnumerable<HocVien> GetAll()
    {
        return DbContext.HocViens.ToList();
    }

    public void Delete(int id)
    {
        HocVien hocVien = FindById(id);
        DbContext.HocViens.Remove(hocVien);
        DbContext.SaveChanges();
    }

    public HocVien? FindById(int id)
    {
        return DbContext.HocViens.Find(id);
    }

    public IEnumerable<HocVien> FindAllByNameAndKhoaHoc(string name,KhoaHoc khoaHoc)
    {
        return DbContext.HocViens.Where(x => x.HoTen.Contains(name)
                                             & x.KhoaHoc == khoaHoc).ToList();
    }
    
    
    
}