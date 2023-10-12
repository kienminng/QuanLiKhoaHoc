using Microsoft.EntityFrameworkCore;
using QuanLiKhoaHoc.Entity;
using QuanLiKhoaHoc.Entity.DTO;

namespace QuanLiKhoaHoc.Service.impl;

public class KhoaHocService : IKhoaHocService
{
    private readonly AppDBContext DbContext;

    public KhoaHocService(AppDBContext dbContext)
    {
        DbContext = new AppDBContext();
    }

    public string AddNew(KhoaHoc khoaHoc)
    {
        try
        {
            DbContext.KhoaHocs.Add(khoaHoc);
            DbContext.SaveChanges();
            return "add success";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public string Update(KhoaHoc khoaHoc)
    {
        try
        {
            DbContext.KhoaHocs.Update(khoaHoc);
            DbContext.SaveChanges();
            return "update success";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public IEnumerable<KhoaHoc> GetAll()
    {
        return DbContext.KhoaHocs.ToList();
    }

    public string Delete(int id)
    {
        try
        {
            KhoaHoc khoaHoc = FindById(id);
            DbContext.KhoaHocs.Remove(khoaHoc);
            DbContext.SaveChanges();
            return "delete succes";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    public KhoaHoc? FindById(int id)
    {
        return DbContext.KhoaHocs.Find(id);
    }

    public double TinhDoanhThuTrongCacThang(int month, int year)
    {
        var result = DbContext.KhoaHocs
            .Where(kh => kh.NgayBatDau.Year == year && kh.NgayBatDau.Month == month)
            .Select(kh => new
            {
                TongTien = kh.DanhSachHocVien.Count() * kh.HocPhi
            }).ToList();
        double TongTenTrongThang = 0;

        foreach (var n in result)
        {
            TongTenTrongThang += n.TongTien;
        }

        return TongTenTrongThang;
    }

    public List<TongTien> TinhThuNhapCacThangTrongNam(int year)
    {
        List<TongTien> tongTiens = new List<TongTien>();
        for (int i = 1; i < 13; i++)
        {
            double money = TinhDoanhThuTrongCacThang(i, year);
            TongTien tongTien = new TongTien(i, year, money);
            tongTiens.Add(tongTien);
        }
        return tongTiens;
    }
}