// See https://aka.ms/new-console-template for more information

using QuanLiKhoaHoc.Entity;
using QuanLiKhoaHoc.Entity.DTO;
using QuanLiKhoaHoc.Service.impl;

Console.WriteLine("Hello, World!");
AppDBContext dbContext = new AppDBContext();

KhoaHocService khoaHocService = new KhoaHocService(dbContext);

List<TongTien> tongTiens= khoaHocService.TinhThuNhapCacThangTrongNam(2023);

foreach (var n in tongTiens)
{
    Console.WriteLine($"{n.Thang} tài chính {n.Money}");
}