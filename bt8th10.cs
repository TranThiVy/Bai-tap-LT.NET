using System;
using System.Collections.Generic;

abstract class PhuongTien
{
    public string TenPhuongTien { get; set; }
    public string LoaiNhienLieu { get; set; }

    public abstract void DiChuyen();
}

interface IThongTinThem
{
    int TocDoToiDa();
    float MucTieuThuNhienLieu();
}

class XeHoi : PhuongTien, IThongTinThem
{
    public XeHoi(string ten, string loaiNhienLieu)
    {
        TenPhuongTien = ten;
        LoaiNhienLieu = loaiNhienLieu;
    }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} di chuyen bang dong co.");
    }

    public int TocDoToiDa()
    {
        return 200;
    }

    public float MucTieuThuNhienLieu()
    {
        return 8.5f;
    }
}

class XeDap : PhuongTien, IThongTinThem
{
    public XeDap(string ten)
    {
        TenPhuongTien = ten;
        LoaiNhienLieu = "Khong su dung nhien lieu";
    }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} di chuyen bang suc nguoi.");
    }

    public int TocDoToiDa()
    {
        return 25;
    }

    public float MucTieuThuNhienLieu()
    {
        return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<PhuongTien> danhSachPhuongTien = new List<PhuongTien>
        {
            new XeHoi("Toyota", "Xang"),
            new XeDap("Xe dap the thao")
        };

        foreach (PhuongTien phuongTien in danhSachPhuongTien)
        {
            Console.WriteLine($"Ten phuong tien: {phuongTien.TenPhuongTien}");
            Console.WriteLine($"Loai nhien lieu: {phuongTien.LoaiNhienLieu}");
            phuongTien.DiChuyen();

            if (phuongTien is IThongTinThem thongTinThem)
            {
                Console.WriteLine($"Toc do toi da: {thongTinThem.TocDoToiDa()} km/h");

                if (phuongTien is XeHoi)
                {
                    Console.WriteLine($"Muc tieu thu nhien lieu: {thongTinThem.MucTieuThuNhienLieu()} lit/100km");
                }
            }

            Console.WriteLine();
        }
    }
}
